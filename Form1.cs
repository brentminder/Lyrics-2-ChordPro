using Microsoft.Win32;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace Lyrics_2_ChordPro
{
    public partial class Form1 : Form
    {
        private bool _normalizingOriginalLyrics;

        private const string NoSetlist = "-All Songs-";
        private List<string> _songsByTitle = new();

        public Form1() {
            InitializeComponent();
            // try to use a project-provided icon (note.ico) so the pinned app has a proper icon;
            // fallback to the runtime-generated musical-note icon when the file is not present.
            try {
                var exeDir = AppContext.BaseDirectory;
                var iconPath = Path.Combine(exeDir, "note.ico");
                if (File.Exists(iconPath)) {
                    this.Icon = new Icon(iconPath);
                }
                else {
                    this.Icon = CreateNoteIcon();
                }
            }
            catch {
                this.Icon = CreateNoteIcon();
            }

            txtOriginalLyrics.KeyDown += txtOriginalLyrics_KeyDown;

            // load last used folder from registry
            LoadFolderFromRegistry();

            // save last used folder when form is closing
            this.FormClosing += Form1_FormClosing;

            // wire up Live Prompter Utils controls

            LoadLivePrompterUtils();
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool DestroyIcon(IntPtr hIcon);

        private Icon CreateNoteIcon() {
            const int size = 32;
            using var bmp = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bmp)) {
                g.Clear(Color.Transparent);
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                using var font = new Font("Segoe UI Symbol", 20, FontStyle.Regular, GraphicsUnit.Pixel);
                var note = "\u266B"; // beamed eighth notes
                var layout = g.MeasureString(note, font);
                g.DrawString(note, font, Brushes.Black, (size - layout.Width) / 2f, (size - layout.Height) / 2f);
            }

            var hIcon = bmp.GetHicon();
            try {
                using var iconFromHandle = Icon.FromHandle(hIcon);
                var clone = (Icon)iconFromHandle.Clone();
                return clone;
            }
            finally {
                // release the original handle
                DestroyIcon(hIcon);
            }
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

            Action<string> appendTitleCased = value => {
                var normalized = value.Replace("prechorus", "pre-chorus", StringComparison.OrdinalIgnoreCase);
                var titleCased = textInfo.ToTitleCase(normalized.ToLowerInvariant());
                formattedLines.AppendLine();
                formattedLines.AppendLine(titleCased + ":");
            };

            foreach (var line in lines) {
                var trimmedLine = line.Trim();

                //parse title and artist from the header

                //musixmatch.com eg: Lyrics of down by the water by liz phair
                if (trimmedLine.StartsWith("lyrics of ", StringComparison.OrdinalIgnoreCase) &&
                    !isSectionLine(trimmedLine)) {
                    const string lyricsOf = "lyrics of ";
                    var metadata = trimmedLine[lyricsOf.Length..].Trim();
                    var byIndex = metadata.LastIndexOf(" by ", StringComparison.OrdinalIgnoreCase);

                    if (byIndex > 0) {
                        var title = metadata[..byIndex].Trim();
                        var artist = metadata[(byIndex + 4)..].Trim();

                        if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(artist)) {
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

        private void btnMinute2_Click(object sender, EventArgs e) {
            txtMinutes.Text = "2";
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

        private void txtSeconds_UpDown(object sender, KeyEventArgs e) {
            if (!int.TryParse(txtSeconds.Text, out var seconds))
                seconds = 0;

            var newValue = e.KeyCode switch {
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

        private void btnRefresh_Click(object sender, EventArgs e) {
            RefreshLyrics();
        }

        private void btnWriteFile_Click(object sender, EventArgs e) {
            var filename = txtTitle.Text + " - " + txtArtist.Text + ".txt";
            var path = Path.Combine(txtChordProSongsFolder.Text, filename);
            if (File.Exists(path)) {
                var result = MessageBox.Show(
                    $"The file '{filename}' already exists. Overwrite it?",
                    "File Exists",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                if (result != DialogResult.OK)
                    return;
            }

            try {
                File.WriteAllText(path, txtFormattedLyrics.Text);
                MessageBox.Show($"File '{filename}' has been written successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show($"An error occurred while writing the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPaste_Click(object sender, EventArgs e) {
            txtOriginalLyrics.Text = Clipboard.GetText();
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e) {
            SaveFolderToRegistry();
        }

        private void LoadFolderFromRegistry() {
            try {
                using var key = Registry.CurrentUser.OpenSubKey("Software\\Lyrics-2-ChordPro");
                if (key is null)
                    return;

                var value = key.GetValue("LastFolder") as string;
                if (!string.IsNullOrWhiteSpace(value)) {
                    txtChordProSongsFolder.Text = value;
                }
            }
            catch {
                // ignore registry read errors
            }
        }

        private void SaveFolderToRegistry() {
            try {
                using var key = Registry.CurrentUser.CreateSubKey("Software\\Lyrics-2-ChordPro");
                if (key is null)
                    return;

                key.SetValue("LastFolder", txtChordProSongsFolder.Text ?? string.Empty, RegistryValueKind.String);
            }
            catch {
                // ignore registry write errors
            }
        }

        private void btnCopy_Click(object sender, EventArgs e) {
            Clipboard.SetText(txtTitle.Text + " - " + txtArtist.Text);
        }

        private void linkMusixMatch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenLink("https://www.musixmatch.com/search");
        }

        private void linkAzLyrics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenLink("https://www.azlyrics.com/");
        }

        private void linkGenius_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenLink("https://genius.com/search");
        }

        private void OpenLink(string url) {
            try {
                var psi = new System.Diagnostics.ProcessStartInfo {
                    FileName = url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex) {
                MessageBox.Show($"Unable to open link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMinutes_TextChanged(object sender, EventArgs e) {
            RefreshLyrics();
        }

        private void txtSeconds_TextChanged(object sender, EventArgs e) {
            RefreshLyrics();
        }

        #region Live Prompter Utils

        private bool _suppressLivePrompterEvents = false;

        private void LoadLivePrompterUtils() {
            // sync the folder paths
            txtChordProSongsFolder2.Text = txtChordProSongsFolder.Text;

            _suppressLivePrompterEvents = false;

            // populate setlists and load first item
            PopulateSetlists();
            RefreshLivePrompterUtils();
        }

        private void txtChordProSongsFolder_TextChanged(object sender, EventArgs e) {
            txtChordProSongsFolder2.Text = txtChordProSongsFolder.Text;
        }

        private void PopulateSetlists() {
            if (_suppressLivePrompterEvents)
                return;

            var songFolder = txtChordProSongsFolder.Text;
            if (string.IsNullOrWhiteSpace(songFolder) || !Directory.Exists(songFolder)) {
                lbSetlists.Items.Clear();
                return;
            }

            var setlistFolder = Path.Combine(songFolder, "Setlists");

            _suppressLivePrompterEvents = true;
            lbSetlists.Items.Clear();
            lbSetlists.Items.Add(NoSetlist);

            try {
                if (Directory.Exists(setlistFolder)) {
                    var setlistFiles = Directory.GetFiles(setlistFolder, "*.txt")
                        .Select(f => Path.GetFileNameWithoutExtension(f))
                        .OrderBy(name => name)
                        .ToList();

                    foreach (var file in setlistFiles) {
                        lbSetlists.Items.Add(file);
                    }
                }
            }
            catch {
                // ignore errors reading setlist folder
            }

            // select first item and cascade
            if (lbSetlists.Items.Count > 0) {
                lbSetlists.SelectedIndex = 0;
            }

            _suppressLivePrompterEvents = false;
        }

        private void RefreshLivePrompterUtils() {
            ClearSongs();
            LoadSongList();
            var allsongs = lbSetlists.SelectedIndex == 0;
            btnDeleteSetlistSongs.Enabled = !allsongs;
            btnSaveSetlistSongs.Enabled = !allsongs;

            if (allsongs && rbSongsByArtist.Checked) //LoadSongList will load in title order
                SortSongs();
        }

        private void btnSaveSetlistSongs_Click(object sender, EventArgs e) {

        }

        private void lbSetlists_SelectedIndexChanged(object sender, EventArgs e) {
            if (_suppressLivePrompterEvents)
                return;

            _suppressLivePrompterEvents = true;

            txtSetlistName.Text = lbSetlists.SelectedIndex > 0 ? lbSetlists.SelectedItem?.ToString() ?? string.Empty : string.Empty;
            RefreshLivePrompterUtils();

            _suppressLivePrompterEvents = false;
        }

        private void LoadSongList() {
            var selectedSetlist = lbSetlists.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedSetlist)) {
                return;
            }

            var songFolder = txtChordProSongsFolder.Text;
            if (string.IsNullOrWhiteSpace(songFolder) || !Directory.Exists(songFolder)) {
                return;
            }

            try {
                if (selectedSetlist == NoSetlist) {
                    rbSongsByTitle.Enabled = true;
                    rbSongsByArtist.Enabled = true;

                    LoadSongsByTitle(songFolder);
                    foreach (var song in _songsByTitle) {
                        lbSongs.Items.Add(song);
                    }
                }
                else {
                    // load from setlist file
                    var setlistFile = Path.Combine(songFolder, "Setlists", selectedSetlist + ".txt");
                    if (File.Exists(setlistFile)) {
                        var lines = File.ReadAllLines(setlistFile)
                            .Where(line => !string.IsNullOrWhiteSpace(line))
                            //.OrderBy DO NOT ORDER SETLISTS!!! order is set by user
                            .ToList();

                        foreach (var line in lines) {
                            lbSongs.Items.Add(line);
                        }
                    }
                }
            }
            catch {
                // ignore errors reading files
            }
        }

        private void LoadSongsByTitle(string songFolder) {
            if (string.IsNullOrWhiteSpace(songFolder) || !Directory.Exists(songFolder)) {
                return;
            }
            try {
                _songsByTitle.Clear();
                _songsByTitle.AddRange(Directory.GetFiles(songFolder, "*.txt")
                    .Where(f => Path.GetDirectoryName(f) == songFolder)
                    .Select(f => Path.GetFileNameWithoutExtension(f))
                    .OrderBy(n => n, StringComparer.OrdinalIgnoreCase)
                    .ToList());
            }
            catch {
                // ignore errors reading songs
            }
        }

        private void ClearSongs() {
            _suppressLivePrompterEvents = true;
            lbSongs.Items.Clear();
            txtSavedLyrics.Clear();
            btnSaveSong.Enabled = false;
            rbSongsByTitle.Enabled = false;
            rbSongsByArtist.Enabled = false;
            _suppressLivePrompterEvents = false;
        }

        private void rbSongsByTitle_CheckedChanged(object sender, EventArgs e) {
            if (_suppressLivePrompterEvents)
                return;

            SortSongs();
        }

        private void rbSongsByArtist_CheckedChanged(object sender, EventArgs e) {
            if (_suppressLivePrompterEvents)
                return;

            SortSongs();
        }

        private void SortSongs() {
            _suppressLivePrompterEvents = true;

            var byArtist = rbSongsByArtist.Checked;
            if (byArtist) {
                // swap title and artist, sort, then display
                var swapped = _songsByTitle.Select(song => {
                    var parts = song.Split(new[] { " - " }, StringSplitOptions.None);
                    if (parts.Length == 2) {
                        return parts[1].Trim() + " - " + parts[0].Trim();
                    }
                    return song;
                }).ToList();

                swapped.Sort(StringComparer.OrdinalIgnoreCase);

                lbSongs.Items.Clear();
                foreach (var song in swapped) {
                    lbSongs.Items.Add(song);
                }
            }
            else {
                lbSongs.Items.Clear();
                _songsByTitle.Sort(StringComparer.OrdinalIgnoreCase);
                foreach (var song in _songsByTitle) {
                    lbSongs.Items.Add(song);
                }
            }
            _suppressLivePrompterEvents = false;
        }

        private void txtSongFilter_TextChanged(object sender, EventArgs e) {
            if (_suppressLivePrompterEvents)
                return;

            var filter = txtSongFilter.Text.ToLower();
            var selectedSetlist = lbSetlists.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedSetlist)) {
                return;
            }

            var songFolder = txtChordProSongsFolder.Text;
            if (string.IsNullOrWhiteSpace(songFolder) || !Directory.Exists(songFolder)) {
                return;
            }

            _suppressLivePrompterEvents = true;
            lbSongs.Items.Clear();

            try {
                List<string> allSongs = new();

                if (selectedSetlist == NoSetlist) {
                    var songFiles = Directory.GetFiles(songFolder, "*.txt")
                        .Where(f => Path.GetDirectoryName(f) == songFolder)
                        .Select(f => Path.GetFileNameWithoutExtension(f))
                        .ToList();
                    allSongs = songFiles;
                }
                else {
                    var setlistFile = Path.Combine(songFolder, "Setlists", selectedSetlist + ".txt");
                    if (File.Exists(setlistFile)) {
                        allSongs = File.ReadAllLines(setlistFile)
                            .Where(line => !string.IsNullOrWhiteSpace(line))
                            .ToList();
                    }
                }

                // filter songs
                var filteredSongs = allSongs
                    .Where(song => song.ToLower().Contains(filter))
                    .ToList();

                // sort based on current radio button selection
                if (rbSongsByTitle.Checked) {
                    filteredSongs.Sort(StringComparer.OrdinalIgnoreCase);
                }
                else if (rbSongsByArtist.Checked) {
                    var swapped = filteredSongs.Select(song => {
                        var parts = song.Split(new[] { " - " }, StringSplitOptions.None);
                        if (parts.Length == 2) {
                            return parts[1].Trim() + " - " + parts[0].Trim();
                        }
                        return song;
                    }).ToList();
                    swapped.Sort(StringComparer.OrdinalIgnoreCase);
                    filteredSongs = swapped;
                }

                foreach (var song in filteredSongs) {
                    lbSongs.Items.Add(song);
                }
            }
            catch {
                // ignore errors
            }

            _suppressLivePrompterEvents = false;
        }

        private void lbSongs_SelectedIndexChanged(object sender, EventArgs e) {
            if (_suppressLivePrompterEvents)
                return;

            _suppressLivePrompterEvents = true;
            txtSavedLyrics.Clear();

            if (lbSongs.SelectedIndex >= 0) {
                var selectedSong = lbSongs.SelectedItem?.ToString();
                if (!string.IsNullOrWhiteSpace(selectedSong)) {
                    LoadLyricsForSong(selectedSong);
                }
            }

            _suppressLivePrompterEvents = false;
        }

        private void LoadLyricsForSong(string songName) {
            var songFolder = txtChordProSongsFolder.Text;
            if (string.IsNullOrWhiteSpace(songFolder) || !Directory.Exists(songFolder)) {
                return;
            }

            // remove artist prefix if sorting by artist
            var fileName = songName;
            if (rbSongsByArtist.Checked) {
                var parts = songName.Split(new[] { " - " }, StringSplitOptions.None);
                if (parts.Length == 2) {
                    fileName = parts[1].Trim() + " - " + parts[0].Trim();
                }
            }

            var filePath = Path.Combine(songFolder, fileName + ".txt");

            try {
                if (File.Exists(filePath)) {
                    txtSavedLyrics.Text = File.ReadAllText(filePath);
                }
            }
            catch {
                // ignore errors reading file
            }
        }

        private void btnAddNewSetlist_Click(object sender, EventArgs e) {
            var songFolder = txtChordProSongsFolder.Text;
            if (string.IsNullOrWhiteSpace(songFolder) || !Directory.Exists(songFolder)) {
                MessageBox.Show("Please set a valid songs folder.", "Invalid Folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var setlistFolder = Path.Combine(songFolder, "Setlists");
            try {
                Directory.CreateDirectory(setlistFolder);
                txtSetlistName.Text = "New Setlist";
                var setlistFile = Path.Combine(setlistFolder, txtSetlistName.Text + ".txt");

                if (File.Exists(setlistFile)) {
                    MessageBox.Show("Setlist already exists.", "Setlist Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                File.WriteAllText(setlistFile, "");
                PopulateSetlists();
                //MessageBox.Show($"Setlist '{txtSetlistName.Text}' created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show($"Error creating setlist: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloneSetlist_Click(object sender, EventArgs e) {
            var selectedSetlist = lbSetlists.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedSetlist) || selectedSetlist == NoSetlist) {
                MessageBox.Show("Please select a setlist to clone.", "No Setlist Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var newName = InputBox("Enter new setlist name:", "Clone Setlist");
            if (string.IsNullOrWhiteSpace(newName)) {
                return;
            }

            var songFolder = txtChordProSongsFolder.Text;
            if (string.IsNullOrWhiteSpace(songFolder) || !Directory.Exists(songFolder)) {
                return;
            }

            var setlistFolder = Path.Combine(songFolder, "Setlists");
            try {
                var sourcePath = Path.Combine(setlistFolder, selectedSetlist + ".txt");
                var destPath = Path.Combine(setlistFolder, newName + ".txt");

                if (!File.Exists(sourcePath)) {
                    MessageBox.Show("Source setlist not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (File.Exists(destPath)) {
                    MessageBox.Show("Setlist with that name already exists.", "Setlist Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                File.Copy(sourcePath, destPath);
                PopulateSetlists();
            }
            catch (Exception ex) {
                MessageBox.Show($"Error cloning setlist: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSavedLyrics_TextChanged(object sender, EventArgs e) {
            btnSaveSong.Enabled = true;
        }
        private void btnDeleteSetlist_Click(object sender, EventArgs e) {
            DeleteSetlist();
        }

        private void lbSetlists_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete) {
                DeleteSetlist();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void DeleteSetlist() {
            var selectedSetlist = lbSetlists.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedSetlist) || selectedSetlist == NoSetlist) {
                MessageBox.Show("Please select a setlist to delete.", "No Setlist Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                $"Delete setlist '{selectedSetlist}'?",
                "Confirm Delete",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result != DialogResult.OK) {
                return;
            }

            var songFolder = txtChordProSongsFolder.Text;
            if (string.IsNullOrWhiteSpace(songFolder) || !Directory.Exists(songFolder)) {
                return;
            }

            var setlistFolder = Path.Combine(songFolder, "Setlists");
            try {
                var setlistFile = Path.Combine(setlistFolder, selectedSetlist + ".txt");
                if (File.Exists(setlistFile)) {
                    File.Delete(setlistFile);
                }
                PopulateSetlists();
            }
            catch (Exception ex) {
                MessageBox.Show($"Error deleting setlist: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveSetlist_Click(object sender, EventArgs e) {
            var selectedSetlist = lbSetlists.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedSetlist) || selectedSetlist == NoSetlist) {
                MessageBox.Show("Please select a setlist to save.", "No Setlist Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var songFolder = txtChordProSongsFolder.Text;
            if (string.IsNullOrWhiteSpace(songFolder) || !Directory.Exists(songFolder)) {
                return;
            }

            try {
                var setlistFolder = Path.Combine(songFolder, "Setlists");
                var setlistFile = Path.Combine(setlistFolder, selectedSetlist + ".txt");

                var songs = lbSongs.Items.Cast<string>().ToList();

                // if sorted by artist, swap back to title - artist format
                if (rbSongsByArtist.Checked) {
                    songs = songs.Select(song => {
                        var parts = song.Split(new[] { " - " }, StringSplitOptions.None);
                        if (parts.Length == 2) {
                            return parts[1].Trim() + " - " + parts[0].Trim();
                        }
                        return song;
                    }).ToList();
                }

                File.WriteAllLines(setlistFile, songs);
                MessageBox.Show("Setlist saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show($"Error saving setlist: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSong_Click(object sender, EventArgs e) {
            DeleteSongs();
        }

        private void lbSongs_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete) {
                DeleteSongs();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void DeleteSongs() {
            if (lbSongs.SelectedIndices.Count == 0) {
                return;
            }

            _suppressLivePrompterEvents = true;
            var selectedIndices = lbSongs.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToList();
            foreach (var index in selectedIndices) {
                lbSongs.Items.RemoveAt(index);
            }
            _suppressLivePrompterEvents = false;
        }

        private void btnSaveSong_Click(object sender, EventArgs e) {
            if (lbSongs.SelectedIndex < 0) {
                MessageBox.Show("Please select a song.", "No Song Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedSong = lbSongs.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedSong)) {
                return;
            }

            var songFolder = txtChordProSongsFolder.Text;
            if (string.IsNullOrWhiteSpace(songFolder) || !Directory.Exists(songFolder)) {
                return;
            }

            // remove artist prefix if sorting by artist
            var fileName = selectedSong;
            if (rbSongsByArtist.Checked) {
                var parts = selectedSong.Split(new[] { " - " }, StringSplitOptions.None);
                if (parts.Length == 2) {
                    fileName = parts[1].Trim() + " - " + parts[0].Trim();
                }
            }

            var filePath = Path.Combine(songFolder, fileName + ".txt");

            try {
                File.WriteAllText(filePath, txtSavedLyrics.Text);
                MessageBox.Show("Song lyrics saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show($"Error saving song lyrics: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string InputBox(string prompt, string title) {
            var form = new Form {
                Text = title,
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterParent
            };

            var label = new Label { Text = prompt, Left = 20, Top = 20, Width = 350 };
            var textBox = new TextBox { Left = 20, Top = 50, Width = 350 };
            var okButton = new Button { Text = "OK", Left = 210, Top = 80, Width = 80, DialogResult = DialogResult.OK };
            var cancelButton = new Button { Text = "Cancel", Left = 300, Top = 80, Width = 80, DialogResult = DialogResult.Cancel };

            form.Controls.Add(label);
            form.Controls.Add(textBox);
            form.Controls.Add(okButton);
            form.Controls.Add(cancelButton);
            form.AcceptButton = okButton;
            form.CancelButton = cancelButton;

            return form.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }

        private void lbSongs_MouseDown(object sender, MouseEventArgs e) {

            if (e.Button != MouseButtons.Right)
                return; // Only handle right-clicks

            if (lbSongs.SelectedIndices.Count == 0) {
                MessageBox.Show("Please select at least one song to add to a setlist.", "No Songs Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedSongs = lbSongs.SelectedItems.Cast<string>().ToList();

            // Get all available setlists (excluding "-All Songs-")
            var availableSetlists = lbSetlists.Items.Cast<string>()
                .Where(s => s != NoSetlist)
                .ToList();

            if (availableSetlists.Count == 0) {
                MessageBox.Show("No setlists available. Please create a setlist first.", "No Setlists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var form = new AddToSetlist(selectedSongs, availableSetlists)) {
                // Position form to the right of the mouse click
                var screenPos = lbSongs.PointToScreen(e.Location);
                var screenBounds = Screen.GetBounds(screenPos);
                var formWidth = form.Width;

                var x = screenPos.X + 10; // Offset slightly to the right
                if (x + formWidth > screenBounds.Right) {
                    x = screenPos.X - formWidth - 10; // Move to the left if it goes off-screen
                }

                var y = screenPos.Y;
                if (y + form.Height > screenBounds.Bottom) {
                    y = screenBounds.Bottom - form.Height; // Adjust vertically if needed
                }

                form.Location = new Point(Math.Max(screenBounds.Left, x), Math.Max(screenBounds.Top, y));

                if (form.ShowDialog(this) == DialogResult.OK) {
                    var targetSetlist = form.GetSelectedSetlist();
                    if (string.IsNullOrWhiteSpace(targetSetlist)) {
                        return;
                    }

                    AddSongsToSetlist(targetSetlist, selectedSongs);
                }
            }

        }

        private void AddSongsToSetlist(string setlistName, List<string> songsToAdd) {
            var songFolder = txtChordProSongsFolder.Text;
            if (string.IsNullOrWhiteSpace(songFolder) || !Directory.Exists(songFolder)) {
                MessageBox.Show("Song folder is not valid.", "Invalid Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var setlistFolder = Path.Combine(songFolder, "Setlists");
            var setlistFile = Path.Combine(setlistFolder, setlistName + ".txt");

            if (!File.Exists(setlistFile)) {
                MessageBox.Show($"Setlist '{setlistName}' not found.", "Setlist Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                // Read existing songs from the setlist
                var existingSongs = File.ReadAllLines(setlistFile)
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .ToList();

                // Convert selected songs to proper format (swap back from artist-title if needed)
                var songsToAddFormatted = songsToAdd.Select(song => {
                    if (rbSongsByArtist.Checked) {
                        var parts = song.Split(new[] { " - " }, StringSplitOptions.None);
                        if (parts.Length == 2) {
                            return parts[1].Trim() + " - " + parts[0].Trim();
                        }
                    }
                    return song;
                }).ToList();

                // Add new songs, avoiding duplicates
                var combinedSongs = new HashSet<string>(existingSongs);
                var addedCount = 0;
                foreach (var song in songsToAddFormatted) {
                    if (combinedSongs.Add(song)) {
                        addedCount++;
                    }
                }

                // Write back to file
                File.WriteAllLines(setlistFile, combinedSongs);

                var message = addedCount == songsToAddFormatted.Count
                    ? $"All {addedCount} song(s) added to '{setlistName}' successfully."
                    : $"{addedCount} song(s) added to '{setlistName}' successfully. ({songsToAddFormatted.Count - addedCount} were already in the setlist.)";

                MessageBox.Show(message, "Songs Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the current view if we're looking at the target setlist
                if (lbSetlists.SelectedItem?.ToString() == setlistName) {
                    RefreshLivePrompterUtils();
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Error adding songs to setlist: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion





    }
}
