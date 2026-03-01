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
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtOriginalLyrics = new TextBox();
            btnRefresh = new Button();
            txtFormattedLyrics = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
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
            txtFolder = new TextBox();
            label9 = new Label();
            btnWriteFile = new Button();
            btnPaste = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(1105, 37);
            label1.TabIndex = 0;
            label1.Text = "Utilities to convert song lyrics into ChordPro (LivePrompter2) format";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 1;
            label2.Text = "Original lyrics";
            // 
            // txtOriginalLyrics
            // 
            txtOriginalLyrics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtOriginalLyrics.Location = new Point(12, 103);
            txtOriginalLyrics.Multiline = true;
            txtOriginalLyrics.Name = "txtOriginalLyrics";
            txtOriginalLyrics.ScrollBars = ScrollBars.Both;
            txtOriginalLyrics.Size = new Size(324, 580);
            txtOriginalLyrics.TabIndex = 2;
            txtOriginalLyrics.WordWrap = false;
            txtOriginalLyrics.TextChanged += txtOriginalLyrics_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI", 12F);
            btnRefresh.Location = new Point(916, 103);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(201, 39);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "&Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtFormattedLyrics
            // 
            txtFormattedLyrics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFormattedLyrics.Location = new Point(351, 103);
            txtFormattedLyrics.Multiline = true;
            txtFormattedLyrics.Name = "txtFormattedLyrics";
            txtFormattedLyrics.ScrollBars = ScrollBars.Both;
            txtFormattedLyrics.Size = new Size(559, 580);
            txtFormattedLyrics.TabIndex = 4;
            txtFormattedLyrics.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(351, 79);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 5;
            label3.Text = "Formatted lyrics";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtSeconds);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtMinutes);
            panel1.Controls.Add(btnMinute5);
            panel1.Controls.Add(btnMinute4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnMinute2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(917, 398);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 146);
            panel1.TabIndex = 6;
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
            // 
            // btnMinute5
            // 
            btnMinute5.Cursor = Cursors.Hand;
            btnMinute5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinute5.Location = new Point(91, 99);
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
            btnMinute4.Location = new Point(91, 70);
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
            label5.Location = new Point(27, 75);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 4;
            label5.Text = "Minute:";
            // 
            // btnMinute2
            // 
            btnMinute2.Cursor = Cursors.Hand;
            btnMinute2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinute2.Location = new Point(91, 42);
            btnMinute2.Name = "btnMinute2";
            btnMinute2.Size = new Size(27, 29);
            btnMinute2.TabIndex = 3;
            btnMinute2.Text = "2";
            btnMinute2.UseVisualStyleBackColor = true;
            btnMinute2.Click += btnMinute3_Click;
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
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnCopy);
            panel2.Controls.Add(txtArtist);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtTitle);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtFolder);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(916, 191);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 201);
            panel2.TabIndex = 11;
            // 
            // btnCopy
            // 
            btnCopy.Cursor = Cursors.Hand;
            btnCopy.Font = new Font("Segoe UI", 8F);
            btnCopy.Location = new Point(133, 71);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(51, 21);
            btnCopy.TabIndex = 14;
            btnCopy.Text = "&Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // txtArtist
            // 
            txtArtist.Font = new Font("Segoe UI", 10F);
            txtArtist.Location = new Point(13, 155);
            txtArtist.MaxLength = 444;
            txtArtist.Name = "txtArtist";
            txtArtist.PlaceholderText = "artist/band";
            txtArtist.Size = new Size(171, 25);
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
            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.Location = new Point(13, 95);
            txtTitle.MaxLength = 444;
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "song title";
            txtTitle.Size = new Size(171, 25);
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
            // txtFolder
            // 
            txtFolder.Font = new Font("Segoe UI", 10F);
            txtFolder.Location = new Point(13, 35);
            txtFolder.MaxLength = 444;
            txtFolder.Name = "txtFolder";
            txtFolder.PlaceholderText = "3";
            txtFolder.Size = new Size(171, 25);
            txtFolder.TabIndex = 8;
            txtFolder.Text = "G:\\My Drive\\musician\\LivePrompter2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(12, 11);
            label9.Name = "label9";
            label9.Size = new Size(54, 21);
            label9.TabIndex = 2;
            label9.Text = "Folder";
            // 
            // btnWriteFile
            // 
            btnWriteFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnWriteFile.Cursor = Cursors.Hand;
            btnWriteFile.Font = new Font("Segoe UI", 12F);
            btnWriteFile.Location = new Point(915, 146);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(201, 39);
            btnWriteFile.TabIndex = 12;
            btnWriteFile.Text = "&Write File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // btnPaste
            // 
            btnPaste.Cursor = Cursors.Hand;
            btnPaste.Location = new Point(264, 79);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(72, 23);
            btnPaste.TabIndex = 13;
            btnPaste.Text = "&Paste";
            btnPaste.UseVisualStyleBackColor = true;
            btnPaste.Click += btnPaste_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 695);
            Controls.Add(btnPaste);
            Controls.Add(btnWriteFile);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(txtFormattedLyrics);
            Controls.Add(btnRefresh);
            Controls.Add(txtOriginalLyrics);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Lyrics to ChordPro";
            KeyPress += Form1_KeyPress;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private TextBox txtFolder;
        private Label label9;
        private Button btnWriteFile;
        private TextBox txtTitle;
        private Label label7;
        private TextBox txtArtist;
        private Label label8;
        private Button btnPaste;
        private Button btnCopy;
    }
}
