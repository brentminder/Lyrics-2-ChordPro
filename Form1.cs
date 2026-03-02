using System.Globalization;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Lyrics_2_ChordPro
{
    public partial class Form1 : Form
    {
        private bool _normalizingOriginalLyrics;

        public Form1()
        {
            InitializeComponent();
            // assign a musical-note icon generated at runtime
            this.Icon = CreateNoteIcon();

            txtOriginalLyrics.KeyDown += txtOriginalLyrics_KeyDown;

            // load last used folder from registry
            LoadFolderFromRegistry();

            // save last used folder when form is closing
            this.FormClosing += Form1_FormClosing;
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool DestroyIcon(IntPtr hIcon);

        private Icon CreateNoteIcon()
        {
            const int size = 32;
            using var bmp = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                using var font = new Font("Segoe UI Symbol", 20, FontStyle.Regular, GraphicsUnit.Pixel);
                var note = "\u266B"; // beamed eighth notes
                var layout = g.MeasureString(note, font);
                g.DrawString(note, font, Brushes.Black, (size - layout.Width) / 2f, (size - layout.Height) / 2f);
            }

            var hIcon = bmp.GetHicon();
            try
            {
                using var iconFromHandle = Icon.FromHandle(hIcon);
                var clone = (Icon)iconFromHandle.Clone();
                return clone;
            }
            finally
            {
                // release the original handle
                DestroyIcon(hIcon);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void txtOriginalLyrics_KeyDown(object sender, KeyEventArgs e)
        {
            var isPasteShortcut =
                (e.Control && e.KeyCode == Keys.V) ||
                (e.Shift && e.KeyCode == Keys.Insert);

            if (!isPasteShortcut || !Clipboard.ContainsText())
                return;

            var pastedText = Clipboard.GetText();
            var normalizedText = NormalizeNewLines(pastedText);

            txtOriginalLyrics.SelectedText = normalizedText;

            e.SuppressKeyPress = true;
            e.Handled = true;
        }

        private static string NormalizeNewLines(string text)
        {
            return text
                .Replace("\r\n", "\n")
                .Replace("\r", "\n")
                .Replace("\u2028", "\n") // line separator
                .Replace("\u2029", "\n") // paragraph separator
                .Replace("\u0085", "\n") // next line
                .Replace("\n", Environment.NewLine);
        }

        private void txtOriginalLyrics_TextChanged(object sender, EventArgs e)
        {
            RefreshLyrics();
        }

        private void RefreshLyrics()
        {
            if (_normalizingOriginalLyrics)
                return;

            var normalizedOriginalLyrics = NormalizeNewLines(txtOriginalLyrics.Text);

            if (!string.Equals(txtOriginalLyrics.Text, normalizedOriginalLyrics, StringComparison.Ordinal))
            {
                var caret = txtOriginalLyrics.SelectionStart;
                _normalizingOriginalLyrics = true;
                txtOriginalLyrics.Text = normalizedOriginalLyrics;
                txtOriginalLyrics.SelectionStart = Math.Min(caret, txtOriginalLyrics.TextLength);
                _normalizingOriginalLyrics = false;
            }

            txtFormattedLyrics.Text = FormatLyrics(normalizedOriginalLyrics);
        }

        private string FormatLyrics(string originalLyrics)
        {
            if (string.IsNullOrWhiteSpace(originalLyrics))
                return string.Empty;

            var lines = originalLyrics.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.None);

            var formattedLines = new StringBuilder();
            var textInfo = CultureInfo.CurrentCulture.TextInfo;

            var minutes = txtMinutes.Text.Trim();
            var seconds = txtSeconds.Text.Trim();
            formattedLines.AppendLine("{Duration:" + minutes + ":" + seconds + "}");

            Func<string, bool> isSectionLine = value =>
                value.StartsWith("intro", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("verse", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("bridge", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("hook", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("prechorus", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("pre-chorus", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("chorus", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("interlude", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("refrain", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("solo", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("guitar solo", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("outro", StringComparison.OrdinalIgnoreCase);

            Action<string> appendTitleCased = value =>
            {
                var normalized = value.Replace("prechorus", "pre-chorus", StringComparison.OrdinalIgnoreCase);
                var titleCased = textInfo.ToTitleCase(normalized.ToLowerInvariant());
                formattedLines.AppendLine();
                formattedLines.AppendLine("{soc:" + titleCased + "}");
            };

            foreach (var line in lines)
            {
                var trimmedLine = line.Trim();

                //parse title and artist from the header
                //eg: Lyrics of down by the water by liz phair
                if (trimmedLine.StartsWith("lyrics of ", StringComparison.OrdinalIgnoreCase) &&
                    !isSectionLine(trimmedLine))
                {
                    const string lyricsOf = "lyrics of ";
                    var metadata = trimmedLine[lyricsOf.Length..].Trim();
                    var byIndex = metadata.LastIndexOf(" by ", StringComparison.OrdinalIgnoreCase);

                    if (byIndex > 0)
                    {
                        var title = metadata[..byIndex].Trim();
                        var artist = metadata[(byIndex + 4)..].Trim();

                        if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(artist))
                        {
                            formattedLines.AppendLine("{title:" + title + "}");
                            formattedLines.AppendLine("{artist:" + artist + "}");
                            txtTitle.Text = title;
                            txtArtist.Text = artist;
                            continue;
                        }
                    }
                }

                if (isSectionLine(trimmedLine))
                    appendTitleCased(trimmedLine);
                else
                    formattedLines.AppendLine(trimmedLine);
            }

            return formattedLines.ToString();
        }

        private void btnMinute2_Click(object sender, EventArgs e)
        {
            txtMinutes.Text = "2";
        }
        private void btnMinute3_Click(object sender, EventArgs e)
        {
            txtMinutes.Text = "3";
        }
        private void btnMinute4_Click(object sender, EventArgs e)
        {
            txtMinutes.Text = "4";
        }

        private void btnMinute5_Click(object sender, EventArgs e)
        {
            txtMinutes.Text = "5";
        }

        private void txtSeconds_UpDown(object sender, KeyEventArgs e)
        {
            if (!int.TryParse(txtSeconds.Text, out var seconds))
                seconds = 0;

            var newValue = e.KeyCode switch
            {
                Keys.Up => Math.Min(59, seconds + 10),
                Keys.Down => Math.Max(0, seconds - 1),
                _ => (int?)null
            };

            if (!newValue.HasValue)
                return;

            txtSeconds.Text = newValue.Value.ToString("00");
            txtSeconds.SelectionStart = txtSeconds.TextLength;
            e.SuppressKeyPress = true;
            e.Handled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshLyrics();
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            var filename = txtTitle.Text + " - " + txtArtist.Text + ".txt";
            var path = Path.Combine(txtFolder.Text, filename);
            if (File.Exists(path))
            {
                var result = MessageBox.Show(
                    $"The file '{filename}' already exists. Overwrite it?",
                    "File Exists",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                if (result != DialogResult.OK)
                    return;
            }

            try
            {
                File.WriteAllText(path, txtFormattedLyrics.Text);
                MessageBox.Show($"File '{filename}' has been written successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtOriginalLyrics.Text = Clipboard.GetText();
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            SaveFolderToRegistry();
        }

        private void LoadFolderFromRegistry()
        {
            try
            {
                using var key = Registry.CurrentUser.OpenSubKey("Software\\Lyrics-2-ChordPro");
                if (key is null)
                    return;

                var value = key.GetValue("LastFolder") as string;
                if (!string.IsNullOrWhiteSpace(value))
                {
                    txtFolder.Text = value;
                }
            }
            catch
            {
                // ignore registry read errors
            }
        }

        private void SaveFolderToRegistry()
        {
            try
            {
                using var key = Registry.CurrentUser.CreateSubKey("Software\\Lyrics-2-ChordPro");
                if (key is null)
                    return;

                key.SetValue("LastFolder", txtFolder.Text ?? string.Empty, RegistryValueKind.String);
            }
            catch
            {
                // ignore registry write errors
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtTitle.Text + " - " + txtArtist.Text);
        }

    }
}
