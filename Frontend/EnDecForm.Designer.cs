namespace SimpleSecUtility.Frontend
{
    partial class EnDecForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnDecForm));
            fileOpener = new OpenFileDialog();
            fileSaver = new SaveFileDialog();
            encryptButton = new Button();
            decryptButton = new Button();
            encryptPanel = new Panel();
            decryptPanel = new Panel();
            encryptPanel.SuspendLayout();
            decryptPanel.SuspendLayout();
            SuspendLayout();
            // 
            // fileOpener
            // 
            fileOpener.FileName = "fileOpener";
            fileOpener.Filter = "All files | *.*";
            fileOpener.Title = "Select a file to Encrypt";
            // 
            // fileSaver
            // 
            fileSaver.Filter = "All files | *.*";
            fileSaver.Title = "Save Encrypted File";
            // 
            // encryptButton
            // 
            encryptButton.BackColor = SystemColors.Control;
            encryptButton.Dock = DockStyle.Fill;
            encryptButton.FlatAppearance.BorderSize = 0;
            encryptButton.FlatStyle = FlatStyle.Flat;
            encryptButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            encryptButton.Image = (Image)resources.GetObject("encryptButton.Image");
            encryptButton.Location = new Point(0, 0);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(412, 690);
            encryptButton.TabIndex = 0;
            encryptButton.UseVisualStyleBackColor = false;
            encryptButton.Click += encryptButton_Click;
            // 
            // decryptButton
            // 
            decryptButton.BackColor = SystemColors.Control;
            decryptButton.Dock = DockStyle.Fill;
            decryptButton.FlatAppearance.BorderSize = 0;
            decryptButton.FlatStyle = FlatStyle.Flat;
            decryptButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            decryptButton.Image = (Image)resources.GetObject("decryptButton.Image");
            decryptButton.Location = new Point(0, 0);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(412, 690);
            decryptButton.TabIndex = 1;
            decryptButton.UseVisualStyleBackColor = false;
            decryptButton.Click += decryptButton_Click;
            // 
            // encryptPanel
            // 
            encryptPanel.Controls.Add(encryptButton);
            encryptPanel.Dock = DockStyle.Left;
            encryptPanel.Location = new Point(0, 0);
            encryptPanel.Name = "encryptPanel";
            encryptPanel.Size = new Size(412, 690);
            encryptPanel.TabIndex = 2;
            // 
            // decryptPanel
            // 
            decryptPanel.Controls.Add(decryptButton);
            decryptPanel.Dock = DockStyle.Left;
            decryptPanel.Location = new Point(412, 0);
            decryptPanel.Name = "decryptPanel";
            decryptPanel.Size = new Size(412, 690);
            decryptPanel.TabIndex = 3;
            // 
            // EnDecForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 690);
            Controls.Add(decryptPanel);
            Controls.Add(encryptPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "EnDecForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encryption / Decryption";
            Load += EnDecForm_Load;
            encryptPanel.ResumeLayout(false);
            decryptPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog fileOpener;
        private SaveFileDialog fileSaver;
        private Button encryptButton;
        private Button decryptButton;
        private Panel encryptPanel;
        private Panel decryptPanel;
    }
}