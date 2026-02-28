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
            button1 = new Button();
            txtFormattedLyrics = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(916, 103);
            button1.Name = "button1";
            button1.Size = new Size(201, 39);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Location = new Point(917, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 535);
            panel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 695);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(txtFormattedLyrics);
            Controls.Add(button1);
            Controls.Add(txtOriginalLyrics);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Lyrics to ChordPro";
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtOriginalLyrics;
        private Button button1;
        private TextBox txtFormattedLyrics;
        private Label label3;
        private Panel panel1;
    }
}
