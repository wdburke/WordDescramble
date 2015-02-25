namespace WordDescramble
{
    partial class DescramblerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScrambledListTextbox = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.GoButton = new System.Windows.Forms.Button();
            this.FileDialogButton = new System.Windows.Forms.Button();
            this.TestFileInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ScrambledListTextbox
            // 
            this.ScrambledListTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrambledListTextbox.Location = new System.Drawing.Point(12, 71);
            this.ScrambledListTextbox.Multiline = true;
            this.ScrambledListTextbox.Name = "ScrambledListTextbox";
            this.ScrambledListTextbox.Size = new System.Drawing.Size(260, 150);
            this.ScrambledListTextbox.TabIndex = 2;
            this.ScrambledListTextbox.Tag = "Word Input";
            this.ScrambledListTextbox.Leave += new System.EventHandler(this.ScrambledList_Leave);
            // 
            // GoButton
            // 
            this.GoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GoButton.AutoSize = true;
            this.GoButton.Enabled = false;
            this.GoButton.Location = new System.Drawing.Point(91, 227);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 3;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // FileDialogButton
            // 
            this.FileDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileDialogButton.Location = new System.Drawing.Point(249, 12);
            this.FileDialogButton.Name = "FileDialogButton";
            this.FileDialogButton.Size = new System.Drawing.Size(23, 20);
            this.FileDialogButton.TabIndex = 1;
            this.FileDialogButton.Text = "..";
            this.FileDialogButton.UseVisualStyleBackColor = true;
            this.FileDialogButton.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // TestFileInput
            // 
            this.TestFileInput.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
            this.TestFileInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestFileInput.Location = new System.Drawing.Point(12, 12);
            this.TestFileInput.Name = "TestFileInput";
            this.TestFileInput.Size = new System.Drawing.Size(231, 20);
            this.TestFileInput.TabIndex = 0;
            // 
            // DescramblerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.FileDialogButton);
            this.Controls.Add(this.TestFileInput);
            this.Controls.Add(this.ScrambledListTextbox);
            this.Name = "DescramblerForm";
            this.Text = "Password Descrambler";
            this.TransparencyKey = System.Drawing.SystemColors.HotTrack;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScrambledListTextbox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button FileDialogButton;
        private System.Windows.Forms.TextBox TestFileInput;
    }
}

