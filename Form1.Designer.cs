namespace Lyrics_2_ChordPro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            txtOriginalLyrics = new TextBox();
            btnRefresh = new Button();
            txtFormattedLyrics = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            btnMinute3 = new Button();
            txtSeconds = new TextBox();
            label6 = new Label();
            txtMinutes = new TextBox();
            btnMinute5 = new Button();
            btnMinute4 = new Button();
            label5 = new Label();
            btnMinute2 = new Button();
            label4 = new Label();
            panel2 = new Panel();
            btnCopy = new Button();
            txtArtist = new TextBox();
            label8 = new Label();
            txtTitle = new TextBox();
            label7 = new Label();
            txtChordProSongsFolder = new TextBox();
            label9 = new Label();
            btnWriteFile = new Button();
            btnPaste = new Button();
            linkMusixMatch = new LinkLabel();
            linkAzLyrics = new LinkLabel();
            tabControl1 = new TabControl();
            tabLivePrompterUtils = new TabPage();
            splitContainer1 = new SplitContainer();
            btnCloneSetlist = new Button();
            btnAddNewSetlist = new Button();
            panel3 = new Panel();
            btnSaveSetlist = new Button();
            btnDeleteSetlist = new Button();
            txtSetlistName = new TextBox();
            label13 = new Label();
            label10 = new Label();
            lbSetlists = new ListBox();
            splitContainer2 = new SplitContainer();
            btnSaveSetlistSongs = new Button();
            txtSongFilter = new TextBox();
            rbSongsByArtist = new RadioButton();
            rbSongsByTitle = new RadioButton();
            btnDeleteSetlistSongs = new Button();
            lbSongs = new DragReorderListBox();
            label11 = new Label();
            txtSavedLyrics = new TextBox();
            btnSaveSong = new Button();
            label12 = new Label();
            txtChordProSongsFolder2 = new TextBox();
            label1 = new Label();
            tabLyricsToChordPro = new TabPage();
            splitMain = new SplitContainer();
            splitChild = new SplitContainer();
            linkGenius = new LinkLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabLivePrompterUtils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tabLyricsToChordPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitChild).BeginInit();
            splitChild.Panel1.SuspendLayout();
            splitChild.Panel2.SuspendLayout();
            splitChild.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(16, 15);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 1;
            label2.Text = "Original lyrics";
            // 
            // txtOriginalLyrics
            // 
            txtOriginalLyrics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOriginalLyrics.BackColor = Color.Black;
            txtOriginalLyrics.ForeColor = Color.White;
            txtOriginalLyrics.Location = new Point(16, 39);
            txtOriginalLyrics.Multiline = true;
            txtOriginalLyrics.Name = "txtOriginalLyrics";
            txtOriginalLyrics.ScrollBars = ScrollBars.Both;
            txtOriginalLyrics.Size = new Size(421, 721);
            txtOriginalLyrics.TabIndex = 2;
            txtOriginalLyrics.WordWrap = false;
            txtOriginalLyrics.TextChanged += txtOriginalLyrics_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI", 12F);
            btnRefresh.Location = new Point(8, 6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(159, 39);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "&Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtFormattedLyrics
            // 
            txtFormattedLyrics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFormattedLyrics.BackColor = Color.Black;
            txtFormattedLyrics.ForeColor = Color.White;
            txtFormattedLyrics.Location = new Point(0, 39);
            txtFormattedLyrics.Multiline = true;
            txtFormattedLyrics.Name = "txtFormattedLyrics";
            txtFormattedLyrics.ScrollBars = ScrollBars.Both;
            txtFormattedLyrics.Size = new Size(540, 721);
            txtFormattedLyrics.TabIndex = 4;
            txtFormattedLyrics.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(0, 15);
            label3.Name = "label3";
            label3.Size = new Size(203, 21);
            label3.TabIndex = 5;
            label3.Text = "Formatted lyrics (ChordPro)";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnMinute3);
            panel1.Controls.Add(txtSeconds);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtMinutes);
            panel1.Controls.Add(btnMinute5);
            panel1.Controls.Add(btnMinute4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnMinute2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(9, 301);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 116);
            panel1.TabIndex = 6;
            // 
            // btnMinute3
            // 
            btnMinute3.Cursor = Cursors.Hand;
            btnMinute3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinute3.Location = new Point(58, 67);
            btnMinute3.Name = "btnMinute3";
            btnMinute3.Size = new Size(27, 29);
            btnMinute3.TabIndex = 11;
            btnMinute3.Text = "3";
            btnMinute3.UseVisualStyleBackColor = true;
            btnMinute3.Click += btnMinute3_Click;
            // 
            // txtSeconds
            // 
            txtSeconds.Font = new Font("Segoe UI", 12F);
            txtSeconds.Location = new Point(132, 9);
            txtSeconds.MaxLength = 2;
            txtSeconds.Name = "txtSeconds";
            txtSeconds.PlaceholderText = "00";
            txtSeconds.Size = new Size(33, 29);
            txtSeconds.TabIndex = 10;
            txtSeconds.TextAlign = HorizontalAlignment.Center;
            txtSeconds.TextChanged += txtSeconds_TextChanged;
            txtSeconds.KeyDown += txtSeconds_UpDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(118, 12);
            label6.Name = "label6";
            label6.Size = new Size(13, 21);
            label6.TabIndex = 9;
            label6.Text = ":";
            // 
            // txtMinutes
            // 
            txtMinutes.Font = new Font("Segoe UI", 12F);
            txtMinutes.Location = new Point(91, 9);
            txtMinutes.MaxLength = 2;
            txtMinutes.Name = "txtMinutes";
            txtMinutes.Size = new Size(27, 29);
            txtMinutes.TabIndex = 8;
            txtMinutes.Text = "3";
            txtMinutes.TextAlign = HorizontalAlignment.Right;
            txtMinutes.TextChanged += txtMinutes_TextChanged;
            // 
            // btnMinute5
            // 
            btnMinute5.Cursor = Cursors.Hand;
            btnMinute5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinute5.Location = new Point(116, 67);
            btnMinute5.Name = "btnMinute5";
            btnMinute5.Size = new Size(27, 29);
            btnMinute5.TabIndex = 6;
            btnMinute5.Text = "5";
            btnMinute5.UseVisualStyleBackColor = true;
            btnMinute5.Click += btnMinute5_Click;
            // 
            // btnMinute4
            // 
            btnMinute4.Cursor = Cursors.Hand;
            btnMinute4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinute4.Location = new Point(87, 67);
            btnMinute4.Name = "btnMinute4";
            btnMinute4.Size = new Size(27, 29);
            btnMinute4.TabIndex = 5;
            btnMinute4.Text = "4";
            btnMinute4.UseVisualStyleBackColor = true;
            btnMinute4.Click += btnMinute4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(27, 48);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 4;
            label5.Text = "Minute:";
            // 
            // btnMinute2
            // 
            btnMinute2.Cursor = Cursors.Hand;
            btnMinute2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinute2.Location = new Point(29, 67);
            btnMinute2.Name = "btnMinute2";
            btnMinute2.Size = new Size(27, 29);
            btnMinute2.TabIndex = 3;
            btnMinute2.Text = "2";
            btnMinute2.UseVisualStyleBackColor = true;
            btnMinute2.Click += btnMinute2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 11);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 2;
            label4.Text = "Duration";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnCopy);
            panel2.Controls.Add(txtArtist);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtTitle);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtChordProSongsFolder);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(8, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 201);
            panel2.TabIndex = 11;
            // 
            // btnCopy
            // 
            btnCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopy.Cursor = Cursors.Hand;
            btnCopy.Font = new Font("Segoe UI", 8F);
            btnCopy.Location = new Point(93, 71);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(51, 21);
            btnCopy.TabIndex = 14;
            btnCopy.Text = "&Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // txtArtist
            // 
            txtArtist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtArtist.Font = new Font("Segoe UI", 10F);
            txtArtist.Location = new Point(13, 155);
            txtArtist.MaxLength = 444;
            txtArtist.Name = "txtArtist";
            txtArtist.PlaceholderText = "artist/band";
            txtArtist.Size = new Size(131, 25);
            txtArtist.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(12, 131);
            label8.Name = "label8";
            label8.Size = new Size(47, 21);
            label8.TabIndex = 11;
            label8.Text = "Artist";
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.Location = new Point(13, 95);
            txtTitle.MaxLength = 444;
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "song title";
            txtTitle.Size = new Size(131, 25);
            txtTitle.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 71);
            label7.Name = "label7";
            label7.Size = new Size(39, 21);
            label7.TabIndex = 9;
            label7.Text = "Title";
            // 
            // txtChordProSongsFolder
            // 
            txtChordProSongsFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtChordProSongsFolder.Font = new Font("Segoe UI", 8F);
            txtChordProSongsFolder.Location = new Point(13, 35);
            txtChordProSongsFolder.MaxLength = 444;
            txtChordProSongsFolder.Name = "txtChordProSongsFolder";
            txtChordProSongsFolder.PlaceholderText = "3";
            txtChordProSongsFolder.Size = new Size(131, 22);
            txtChordProSongsFolder.TabIndex = 8;
            txtChordProSongsFolder.Text = "G:\\My Drive\\musician\\LivePrompter2";
            txtChordProSongsFolder.TextChanged += txtChordProSongsFolder_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(12, 11);
            label9.Name = "label9";
            label9.Size = new Size(172, 21);
            label9.TabIndex = 2;
            label9.Text = "ChordPro Songs Folder";
            // 
            // btnWriteFile
            // 
            btnWriteFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnWriteFile.Cursor = Cursors.Hand;
            btnWriteFile.Font = new Font("Segoe UI", 12F);
            btnWriteFile.Location = new Point(7, 49);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(159, 39);
            btnWriteFile.TabIndex = 12;
            btnWriteFile.Text = "&Write File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // btnPaste
            // 
            btnPaste.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPaste.Cursor = Cursors.Hand;
            btnPaste.Font = new Font("Segoe UI", 12F);
            btnPaste.Location = new Point(268, 5);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(169, 33);
            btnPaste.TabIndex = 13;
            btnPaste.Text = "&Paste Original Lyrics";
            btnPaste.UseVisualStyleBackColor = true;
            btnPaste.Click += btnPaste_Click;
            // 
            // linkMusixMatch
            // 
            linkMusixMatch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkMusixMatch.AutoSize = true;
            linkMusixMatch.Font = new Font("Segoe UI", 12F);
            linkMusixMatch.Location = new Point(220, 15);
            linkMusixMatch.Name = "linkMusixMatch";
            linkMusixMatch.Size = new Size(127, 21);
            linkMusixMatch.TabIndex = 14;
            linkMusixMatch.TabStop = true;
            linkMusixMatch.Text = "MusixMatch.com";
            linkMusixMatch.LinkClicked += linkMusixMatch_LinkClicked;
            // 
            // linkAzLyrics
            // 
            linkAzLyrics.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkAzLyrics.AutoSize = true;
            linkAzLyrics.Font = new Font("Segoe UI", 12F);
            linkAzLyrics.Location = new Point(347, 15);
            linkAzLyrics.Name = "linkAzLyrics";
            linkAzLyrics.Size = new Size(101, 21);
            linkAzLyrics.TabIndex = 15;
            linkAzLyrics.TabStop = true;
            linkAzLyrics.Text = "AZLyrics.com";
            linkAzLyrics.LinkClicked += linkAzLyrics_LinkClicked;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabLivePrompterUtils);
            tabControl1.Controls.Add(tabLyricsToChordPro);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1340, 812);
            tabControl1.TabIndex = 16;
            // 
            // tabLivePrompterUtils
            // 
            tabLivePrompterUtils.BackColor = Color.RosyBrown;
            tabLivePrompterUtils.Controls.Add(splitContainer1);
            tabLivePrompterUtils.Controls.Add(txtChordProSongsFolder2);
            tabLivePrompterUtils.Controls.Add(label1);
            tabLivePrompterUtils.Location = new Point(4, 24);
            tabLivePrompterUtils.Name = "tabLivePrompterUtils";
            tabLivePrompterUtils.Padding = new Padding(3);
            tabLivePrompterUtils.Size = new Size(1332, 784);
            tabLivePrompterUtils.TabIndex = 1;
            tabLivePrompterUtils.Text = "Live Prompter2 Utils";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.ForeColor = Color.White;
            splitContainer1.Location = new Point(3, 73);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCloneSetlist);
            splitContainer1.Panel1.Controls.Add(btnAddNewSetlist);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(label10);
            splitContainer1.Panel1.Controls.Add(lbSetlists);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1326, 708);
            splitContainer1.SplitterDistance = 299;
            splitContainer1.SplitterWidth = 9;
            splitContainer1.TabIndex = 11;
            // 
            // btnCloneSetlist
            // 
            btnCloneSetlist.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloneSetlist.Cursor = Cursors.Hand;
            btnCloneSetlist.Font = new Font("Segoe UI", 9F);
            btnCloneSetlist.ForeColor = Color.Black;
            btnCloneSetlist.Location = new Point(107, 2);
            btnCloneSetlist.Name = "btnCloneSetlist";
            btnCloneSetlist.Size = new Size(82, 23);
            btnCloneSetlist.TabIndex = 16;
            btnCloneSetlist.Text = "&Clone setlist";
            btnCloneSetlist.UseVisualStyleBackColor = true;
            btnCloneSetlist.Click += btnCloneSetlist_Click;
            // 
            // btnAddNewSetlist
            // 
            btnAddNewSetlist.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewSetlist.Cursor = Cursors.Hand;
            btnAddNewSetlist.Font = new Font("Segoe UI", 9F);
            btnAddNewSetlist.ForeColor = Color.Black;
            btnAddNewSetlist.Location = new Point(195, 2);
            btnAddNewSetlist.Name = "btnAddNewSetlist";
            btnAddNewSetlist.Size = new Size(100, 23);
            btnAddNewSetlist.TabIndex = 15;
            btnAddNewSetlist.Text = "&Add new setlist";
            btnAddNewSetlist.UseVisualStyleBackColor = true;
            btnAddNewSetlist.Click += btnAddNewSetlist_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnSaveSetlist);
            panel3.Controls.Add(btnDeleteSetlist);
            panel3.Controls.Add(txtSetlistName);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(4, 575);
            panel3.Name = "panel3";
            panel3.Size = new Size(292, 130);
            panel3.TabIndex = 13;
            // 
            // btnSaveSetlist
            // 
            btnSaveSetlist.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveSetlist.Cursor = Cursors.Hand;
            btnSaveSetlist.Font = new Font("Segoe UI", 12F);
            btnSaveSetlist.ForeColor = Color.Black;
            btnSaveSetlist.Location = new Point(193, 76);
            btnSaveSetlist.Name = "btnSaveSetlist";
            btnSaveSetlist.Size = new Size(84, 36);
            btnSaveSetlist.TabIndex = 16;
            btnSaveSetlist.Text = "&Save";
            btnSaveSetlist.UseVisualStyleBackColor = true;
            btnSaveSetlist.Click += btnSaveSetlist_Click;
            // 
            // btnDeleteSetlist
            // 
            btnDeleteSetlist.BackColor = Color.IndianRed;
            btnDeleteSetlist.Cursor = Cursors.Hand;
            btnDeleteSetlist.Font = new Font("Segoe UI", 12F);
            btnDeleteSetlist.ForeColor = Color.White;
            btnDeleteSetlist.Location = new Point(12, 76);
            btnDeleteSetlist.Name = "btnDeleteSetlist";
            btnDeleteSetlist.Size = new Size(117, 36);
            btnDeleteSetlist.TabIndex = 16;
            btnDeleteSetlist.Text = "&Delete setlist";
            btnDeleteSetlist.UseVisualStyleBackColor = false;
            btnDeleteSetlist.Click += btnDeleteSetlist_Click;
            // 
            // txtSetlistName
            // 
            txtSetlistName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSetlistName.Font = new Font("Segoe UI", 12F);
            txtSetlistName.Location = new Point(13, 35);
            txtSetlistName.MaxLength = 50;
            txtSetlistName.Name = "txtSetlistName";
            txtSetlistName.Size = new Size(266, 29);
            txtSetlistName.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(12, 11);
            label13.Name = "label13";
            label13.Size = new Size(95, 21);
            label13.TabIndex = 2;
            label13.Text = "Setlist name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 4);
            label10.Name = "label10";
            label10.Size = new Size(59, 21);
            label10.TabIndex = 12;
            label10.Text = "Setlists";
            // 
            // lbSetlists
            // 
            lbSetlists.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSetlists.BackColor = Color.Black;
            lbSetlists.Font = new Font("Segoe UI", 12F);
            lbSetlists.ForeColor = Color.White;
            lbSetlists.FormattingEnabled = true;
            lbSetlists.IntegralHeight = false;
            lbSetlists.Location = new Point(3, 27);
            lbSetlists.Name = "lbSetlists";
            lbSetlists.Size = new Size(292, 542);
            lbSetlists.TabIndex = 0;
            lbSetlists.SelectedIndexChanged += lbSetlists_SelectedIndexChanged;
            lbSetlists.KeyDown += lbSetlists_KeyDown;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(btnSaveSetlistSongs);
            splitContainer2.Panel1.Controls.Add(txtSongFilter);
            splitContainer2.Panel1.Controls.Add(rbSongsByArtist);
            splitContainer2.Panel1.Controls.Add(rbSongsByTitle);
            splitContainer2.Panel1.Controls.Add(btnDeleteSetlistSongs);
            splitContainer2.Panel1.Controls.Add(lbSongs);
            splitContainer2.Panel1.Controls.Add(label11);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(txtSavedLyrics);
            splitContainer2.Panel2.Controls.Add(btnSaveSong);
            splitContainer2.Panel2.Controls.Add(label12);
            splitContainer2.Size = new Size(1018, 708);
            splitContainer2.SplitterDistance = 324;
            splitContainer2.SplitterWidth = 9;
            splitContainer2.TabIndex = 0;
            // 
            // btnSaveSetlistSongs
            // 
            btnSaveSetlistSongs.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveSetlistSongs.Cursor = Cursors.Hand;
            btnSaveSetlistSongs.Font = new Font("Segoe UI", 12F);
            btnSaveSetlistSongs.ForeColor = Color.Black;
            btnSaveSetlistSongs.Location = new Point(228, 669);
            btnSaveSetlistSongs.Name = "btnSaveSetlistSongs";
            btnSaveSetlistSongs.Size = new Size(92, 36);
            btnSaveSetlistSongs.TabIndex = 22;
            btnSaveSetlistSongs.Text = "&Save";
            btnSaveSetlistSongs.UseVisualStyleBackColor = true;
            btnSaveSetlistSongs.Click += btnSaveSetlistSongs_Click;
            // 
            // txtSongFilter
            // 
            txtSongFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSongFilter.Font = new Font("Segoe UI", 8F);
            txtSongFilter.Location = new Point(204, 4);
            txtSongFilter.MaxLength = 444;
            txtSongFilter.Name = "txtSongFilter";
            txtSongFilter.PlaceholderText = "Filter by Title or Artist";
            txtSongFilter.Size = new Size(117, 22);
            txtSongFilter.TabIndex = 21;
            txtSongFilter.TextChanged += txtSongFilter_TextChanged;
            // 
            // rbSongsByArtist
            // 
            rbSongsByArtist.AutoSize = true;
            rbSongsByArtist.Cursor = Cursors.Hand;
            rbSongsByArtist.Location = new Point(129, 6);
            rbSongsByArtist.Name = "rbSongsByArtist";
            rbSongsByArtist.Size = new Size(69, 19);
            rbSongsByArtist.TabIndex = 20;
            rbSongsByArtist.Text = "by Artist";
            rbSongsByArtist.UseVisualStyleBackColor = true;
            rbSongsByArtist.CheckedChanged += rbSongsByArtist_CheckedChanged;
            // 
            // rbSongsByTitle
            // 
            rbSongsByTitle.AutoSize = true;
            rbSongsByTitle.Checked = true;
            rbSongsByTitle.Cursor = Cursors.Hand;
            rbSongsByTitle.Location = new Point(62, 6);
            rbSongsByTitle.Name = "rbSongsByTitle";
            rbSongsByTitle.Size = new Size(64, 19);
            rbSongsByTitle.TabIndex = 19;
            rbSongsByTitle.TabStop = true;
            rbSongsByTitle.Text = "by Title";
            rbSongsByTitle.UseVisualStyleBackColor = true;
            rbSongsByTitle.CheckedChanged += rbSongsByTitle_CheckedChanged;
            // 
            // btnDeleteSetlistSongs
            // 
            btnDeleteSetlistSongs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteSetlistSongs.BackColor = Color.IndianRed;
            btnDeleteSetlistSongs.Cursor = Cursors.Hand;
            btnDeleteSetlistSongs.Font = new Font("Segoe UI", 12F);
            btnDeleteSetlistSongs.ForeColor = Color.White;
            btnDeleteSetlistSongs.Location = new Point(3, 669);
            btnDeleteSetlistSongs.Name = "btnDeleteSetlistSongs";
            btnDeleteSetlistSongs.Size = new Size(92, 36);
            btnDeleteSetlistSongs.TabIndex = 18;
            btnDeleteSetlistSongs.Text = "Delete";
            btnDeleteSetlistSongs.UseVisualStyleBackColor = false;
            btnDeleteSetlistSongs.Click += btnDeleteSong_Click;
            // 
            // lbSongs
            // 
            lbSongs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSongs.BackColor = Color.Black;
            lbSongs.Font = new Font("Segoe UI", 12F);
            lbSongs.ForeColor = Color.White;
            lbSongs.FormattingEnabled = true;
            lbSongs.IntegralHeight = false;
            lbSongs.Location = new Point(3, 27);
            lbSongs.Name = "lbSongs";
            lbSongs.Size = new Size(318, 636);
            lbSongs.TabIndex = 14;
            lbSongs.AllowDrop = true;
            lbSongs.SelectedIndexChanged += lbSongs_SelectedIndexChanged;
            lbSongs.KeyDown += lbSongs_KeyDown;
            lbSongs.MouseDown += lbSongs_MouseDown;
            lbSongs.MouseMove += lbSongs_MouseMove;
            lbSongs.DragOver += lbSongs_DragOver;
            lbSongs.DragDrop += lbSongs_DragDrop;
            lbSongs.GiveFeedback += lbSongs_GiveFeedback;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(3, 4);
            label11.Name = "label11";
            label11.Size = new Size(53, 21);
            label11.TabIndex = 13;
            label11.Text = "Songs";
            // 
            // txtSavedLyrics
            // 
            txtSavedLyrics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSavedLyrics.BackColor = Color.Black;
            txtSavedLyrics.ForeColor = Color.White;
            txtSavedLyrics.Location = new Point(3, 27);
            txtSavedLyrics.Multiline = true;
            txtSavedLyrics.Name = "txtSavedLyrics";
            txtSavedLyrics.ScrollBars = ScrollBars.Both;
            txtSavedLyrics.Size = new Size(664, 678);
            txtSavedLyrics.TabIndex = 18;
            txtSavedLyrics.WordWrap = false;
            txtSavedLyrics.TextChanged += txtSavedLyrics_TextChanged;
            // 
            // btnSaveSong
            // 
            btnSaveSong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveSong.Cursor = Cursors.Hand;
            btnSaveSong.Font = new Font("Segoe UI", 9F);
            btnSaveSong.ForeColor = Color.Black;
            btnSaveSong.Location = new Point(567, 0);
            btnSaveSong.Name = "btnSaveSong";
            btnSaveSong.Size = new Size(100, 23);
            btnSaveSong.TabIndex = 17;
            btnSaveSong.Text = "Save song &lyrics";
            btnSaveSong.UseVisualStyleBackColor = true;
            btnSaveSong.Click += btnSaveSong_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(3, 4);
            label12.Name = "label12";
            label12.Size = new Size(49, 21);
            label12.TabIndex = 15;
            label12.Text = "Lyrics";
            // 
            // txtChordProSongsFolder2
            // 
            txtChordProSongsFolder2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtChordProSongsFolder2.BackColor = Color.FromArgb(224, 224, 224);
            txtChordProSongsFolder2.Font = new Font("Segoe UI", 12F);
            txtChordProSongsFolder2.Location = new Point(6, 38);
            txtChordProSongsFolder2.MaxLength = 444;
            txtChordProSongsFolder2.Name = "txtChordProSongsFolder2";
            txtChordProSongsFolder2.PlaceholderText = "3";
            txtChordProSongsFolder2.ReadOnly = true;
            txtChordProSongsFolder2.Size = new Size(1320, 29);
            txtChordProSongsFolder2.TabIndex = 10;
            txtChordProSongsFolder2.Text = "G:\\My Drive\\musician\\LivePrompter2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 14);
            label1.Name = "label1";
            label1.Size = new Size(293, 21);
            label1.TabIndex = 9;
            label1.Text = "ChordPro / Live Prompter2 Songs Folder";
            // 
            // tabLyricsToChordPro
            // 
            tabLyricsToChordPro.BackColor = Color.Transparent;
            tabLyricsToChordPro.Controls.Add(splitMain);
            tabLyricsToChordPro.Location = new Point(4, 24);
            tabLyricsToChordPro.Name = "tabLyricsToChordPro";
            tabLyricsToChordPro.Padding = new Padding(3);
            tabLyricsToChordPro.Size = new Size(1332, 784);
            tabLyricsToChordPro.TabIndex = 0;
            tabLyricsToChordPro.Text = "Lyrics To ChordPro";
            // 
            // splitMain
            // 
            splitMain.BackColor = SystemColors.ActiveCaption;
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(3, 3);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(label2);
            splitMain.Panel1.Controls.Add(txtOriginalLyrics);
            splitMain.Panel1.Controls.Add(btnPaste);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(splitChild);
            splitMain.Size = new Size(1326, 778);
            splitMain.SplitterDistance = 440;
            splitMain.SplitterWidth = 9;
            splitMain.TabIndex = 17;
            // 
            // splitChild
            // 
            splitChild.Dock = DockStyle.Fill;
            splitChild.Location = new Point(0, 0);
            splitChild.Name = "splitChild";
            // 
            // splitChild.Panel1
            // 
            splitChild.Panel1.Controls.Add(label3);
            splitChild.Panel1.Controls.Add(linkGenius);
            splitChild.Panel1.Controls.Add(txtFormattedLyrics);
            splitChild.Panel1.Controls.Add(linkMusixMatch);
            splitChild.Panel1.Controls.Add(linkAzLyrics);
            // 
            // splitChild.Panel2
            // 
            splitChild.Panel2.BackColor = Color.CornflowerBlue;
            splitChild.Panel2.Controls.Add(btnRefresh);
            splitChild.Panel2.Controls.Add(panel1);
            splitChild.Panel2.Controls.Add(panel2);
            splitChild.Panel2.Controls.Add(btnWriteFile);
            splitChild.Size = new Size(877, 778);
            splitChild.SplitterDistance = 543;
            splitChild.SplitterWidth = 9;
            splitChild.TabIndex = 18;
            // 
            // linkGenius
            // 
            linkGenius.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkGenius.AutoSize = true;
            linkGenius.Font = new Font("Segoe UI", 12F);
            linkGenius.Location = new Point(449, 15);
            linkGenius.Name = "linkGenius";
            linkGenius.Size = new Size(91, 21);
            linkGenius.TabIndex = 16;
            linkGenius.TabStop = true;
            linkGenius.Text = "Genius.com";
            linkGenius.LinkClicked += linkGenius_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1364, 836);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Lyrics to ChordPro";
            KeyPress += Form1_KeyPress;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabLivePrompterUtils.ResumeLayout(false);
            tabLivePrompterUtils.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tabLyricsToChordPro.ResumeLayout(false);
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel1.PerformLayout();
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            splitChild.Panel1.ResumeLayout(false);
            splitChild.Panel1.PerformLayout();
            splitChild.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitChild).EndInit();
            splitChild.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TextBox txtOriginalLyrics;
        private Button btnRefresh;
        private TextBox txtFormattedLyrics;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Button btnMinute2;
        private Button btnMinute5;
        private Button btnMinute4;
        private Label label5;
        private TextBox txtSeconds;
        private Label label6;
        private TextBox txtMinutes;
        private Panel panel2;
        private TextBox txtChordProSongsFolder;
        private Label label9;
        private Button btnWriteFile;
        private TextBox txtTitle;
        private Label label7;
        private TextBox txtArtist;
        private Label label8;
        private Button btnPaste;
        private Button btnCopy;
        private Button btnMinute3;
        private LinkLabel linkMusixMatch;
        private LinkLabel linkAzLyrics;
        private TabControl tabControl1;
        private TabPage tabLyricsToChordPro;
        private TabPage tabLivePrompterUtils;
        private LinkLabel linkGenius;
        private SplitContainer splitMain;
        private SplitContainer splitChild;
        private TextBox txtChordProSongsFolder2;
        private Label label1;
        private SplitContainer splitContainer1;
        private ListBox lbSetlists;
        private Label label10;
        private Button btnAddNewSetlist;
        private Panel panel3;
        private TextBox txtSetlistName;
        private Label label13;
        private Button btnDeleteSetlist;
        private Button btnSaveSetlist;
        private SplitContainer splitContainer2;
        private DragReorderListBox lbSongs;
        private Label label11;
        private Label label12;
        private Button btnSaveSong;
        private Button btnDeleteSetlistSongs;
        private Button btnCloneSetlist;
        private RadioButton rbSongsByArtist;
        private RadioButton rbSongsByTitle;
        private TextBox txtSongFilter;
        private TextBox txtSavedLyrics;
        private Button btnSaveSetlistSongs;
    }
}
