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
            fileOpener = new OpenFileDialog();
            fileSaver = new SaveFileDialog();
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
            // EnDecForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 660);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "EnDecForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encryption / Decryption";
            Load += EnDecForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog fileOpener;
        private SaveFileDialog fileSaver;
    }
}