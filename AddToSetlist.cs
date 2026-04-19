namespace Lyrics_2_ChordPro
{
    public partial class AddToSetlist : Form
    {
        private List<string> _selectedSongs;
        private List<string> _availableSetlists;

        public AddToSetlist() {
            InitializeComponent();
        }

        public AddToSetlist(List<string> selectedSongs, List<string> availableSetlists) {
            InitializeComponent();
            _selectedSongs = selectedSongs;
            _availableSetlists = availableSetlists;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            PopulateSetlists();
        }

        private void PopulateSetlists() {
            lbSetlists.Items.Clear();
            foreach (var setlist in _availableSetlists) {
                lbSetlists.Items.Add(setlist);
            }
        }

        public string GetSelectedSetlist() {
            return lbSetlists.SelectedItem?.ToString() ?? string.Empty;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (lbSetlists.SelectedIndex < 0) {
                MessageBox.Show("Please select a setlist.", "No Setlist Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
