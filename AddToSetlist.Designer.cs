namespace Lyrics_2_ChordPro
{
    partial class AddToSetlist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblPrompt = new Label();
            lbSetlists = new ListBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new Font("Segoe UI", 12F);
            lblPrompt.Location = new Point(13, 13);
            lblPrompt.Margin = new Padding(4, 0, 4, 0);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(176, 21);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Select a setlist to add to:";
            // 
            // lbSetlists
            // 
            lbSetlists.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSetlists.Font = new Font("Segoe UI", 12F);
            lbSetlists.FormattingEnabled = true;
            lbSetlists.IntegralHeight = false;
            lbSetlists.Location = new Point(16, 38);
            lbSetlists.Margin = new Padding(4);
            lbSetlists.Name = "lbSetlists";
            lbSetlists.Size = new Size(201, 144);
            lbSetlists.TabIndex = 1;
            lbSetlists.DoubleClick += lbSetlists_DoubleClick;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOK.Font = new Font("Segoe UI", 12F);
            btnOK.Location = new Point(229, 17);
            btnOK.Margin = new Padding(4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(82, 36);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(229, 61);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 36);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddToSetlist
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(323, 199);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(lbSetlists);
            Controls.Add(lblPrompt);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "AddToSetlist";
            StartPosition = FormStartPosition.Manual;
            Text = "Add to Setlist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.ListBox lbSetlists;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}