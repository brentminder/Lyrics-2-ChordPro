using System.Globalization;
using System.Text;

namespace Lyrics_2_ChordPro
{
    public partial class Form1 : Form
    {
        private bool _normalizingOriginalLyrics;

        public Form1() {
            InitializeComponent();
            txtOriginalLyrics.KeyDown += txtOriginalLyrics_KeyDown;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                this.Close();
            }
        }

        private void txtOriginalLyrics_KeyDown(object sender, KeyEventArgs e) {
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

        private static string NormalizeNewLines(string text) {
            return text
                .Replace("\r\n", "\n")
                .Replace("\r", "\n")
                .Replace("\u2028", "\n") // line separator
                .Replace("\u2029", "\n") // paragraph separator
                .Replace("\u0085", "\n") // next line
                .Replace("\n", Environment.NewLine);
        }

        private void txtOriginalLyrics_TextChanged(object sender, EventArgs e) {
            RefreshLyrics();
        }

        private void RefreshLyrics() {
            if (_normalizingOriginalLyrics)
                return;

            var normalizedOriginalLyrics = NormalizeNewLines(txtOriginalLyrics.Text);

            if (!string.Equals(txtOriginalLyrics.Text, normalizedOriginalLyrics, StringComparison.Ordinal)) {
                var caret = txtOriginalLyrics.SelectionStart;
                _normalizingOriginalLyrics = true;
                txtOriginalLyrics.Text = normalizedOriginalLyrics;
                txtOriginalLyrics.SelectionStart = Math.Min(caret, txtOriginalLyrics.TextLength);
                _normalizingOriginalLyrics = false;
            }

            txtFormattedLyrics.Text = FormatLyrics(normalizedOriginalLyrics);
        }

        private string FormatLyrics(string originalLyrics) {
            if (string.IsNullOrWhiteSpace(originalLyrics))
                return string.Empty;

            var lines = originalLyrics.Split(
                new[] { "\r\n", "\n", "\r" },
                StringSplitOptions.None);

            var formattedLines = new StringBuilder();
            var textInfo = CultureInfo.CurrentCulture.TextInfo;

            formattedLines.AppendLine("{Duration:3:99}");

            Func<string, bool> isSectionLine = value =>
                value.StartsWith("intro", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("verse", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("bridge", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("prechorus", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("pre-chorus", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("chorus", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("interlude", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("refrain", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("solo", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("guitar solo", StringComparison.OrdinalIgnoreCase) ||
                value.StartsWith("outro", StringComparison.OrdinalIgnoreCase);

            Action<string> appendTitleCased = value => {
                var normalized = value.Replace("prechorus", "pre-chorus", StringComparison.OrdinalIgnoreCase);
                var titleCased = textInfo.ToTitleCase(normalized.ToLowerInvariant());
                formattedLines.AppendLine();
                formattedLines.AppendLine("{soc:" + titleCased + "}");
            };

            foreach (var line in lines) {
                var trimmedLine = line.Trim();

                if (isSectionLine(trimmedLine))
                    appendTitleCased(trimmedLine);
                else
                    formattedLines.AppendLine(trimmedLine);
            }

            return formattedLines.ToString();
        }

        private void btnMinute3_Click(object sender, EventArgs e) {
            txtMinutes.Text = "3";
        }

        private void btnMinute4_Click(object sender, EventArgs e) {
            txtMinutes.Text = "4";
        }

        private void btnMinute5_Click(object sender, EventArgs e) {
            txtMinutes.Text = "5";
        }

        private void txtSeconds_KeyDown(object sender, KeyEventArgs e) {
            if (!int.TryParse(txtSeconds.Text, out var seconds))
                seconds = 0;

            if (e.KeyCode == Keys.Up) {
                seconds = Math.Min(59, seconds + 10);
                txtSeconds.Text = seconds.ToString("00");
                txtSeconds.SelectionStart = txtSeconds.TextLength;
                e.SuppressKeyPress = true;
                e.Handled = true;
                return;
            }

            if (e.KeyCode == Keys.Down) {
                seconds = Math.Max(0, seconds - 1);
                txtSeconds.Text = seconds.ToString("00");
                txtSeconds.SelectionStart = txtSeconds.TextLength;
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtSeconds_KeyUp(object sender, KeyEventArgs e) {

        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            RefreshLyrics();
        }
    }
}
