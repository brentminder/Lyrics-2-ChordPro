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
            btnMinute3 = new Button();
            label4 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label9 = new Label();
            button2 = new Button();
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
            panel1.Controls.Add(btnMinute3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(916, 284);
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
            txtSeconds.KeyDown += txtSeconds_KeyDown;
            txtSeconds.KeyUp += txtSeconds_KeyUp;
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
            txtMinutes.PlaceholderText = "3";
            txtMinutes.Size = new Size(27, 29);
            txtMinutes.TabIndex = 8;
            txtMinutes.TextAlign = HorizontalAlignment.Right;
            // 
            // btnMinute5
            // 
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
            // btnMinute3
            // 
            btnMinute3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinute3.Location = new Point(91, 42);
            btnMinute3.Name = "btnMinute3";
            btnMinute3.Size = new Size(27, 29);
            btnMinute3.TabIndex = 3;
            btnMinute3.Text = "3";
            btnMinute3.UseVisualStyleBackColor = true;
            btnMinute3.Click += btnMinute3_Click;
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
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(916, 191);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 85);
            panel2.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(13, 35);
            textBox2.MaxLength = 444;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "3";
            textBox2.Size = new Size(171, 29);
            textBox2.TabIndex = 8;
            textBox2.Text = "G:\\My Drive\\musician\\LivePrompter2";
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
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(915, 146);
            button2.Name = "button2";
            button2.Size = new Size(201, 39);
            button2.TabIndex = 12;
            button2.Text = "&Write File";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 695);
            Controls.Add(button2);
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
        private Button btnMinute3;
        private Button btnMinute5;
        private Button btnMinute4;
        private Label label5;
        private TextBox txtSeconds;
        private Label label6;
        private TextBox txtMinutes;
        private Panel panel2;
        private TextBox textBox2;
        private Label label9;
        private Button button2;
    }
}
