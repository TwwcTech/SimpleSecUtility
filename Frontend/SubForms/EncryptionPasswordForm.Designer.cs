namespace SimpleSecUtility.Frontend.SubForms
{
    partial class EncryptionPasswordForm
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
            components = new System.ComponentModel.Container();
            EncryptionPassTextbox = new TextBox();
            SubmitEncPassButton = new Button();
            encToolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // EncryptionPassTextbox
            // 
            EncryptionPassTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EncryptionPassTextbox.Location = new Point(174, 121);
            EncryptionPassTextbox.Name = "EncryptionPassTextbox";
            EncryptionPassTextbox.PasswordChar = '*';
            EncryptionPassTextbox.PlaceholderText = "Enter a password to encrypt the file";
            EncryptionPassTextbox.Size = new Size(455, 37);
            EncryptionPassTextbox.TabIndex = 0;
            // 
            // SubmitEncPassButton
            // 
            SubmitEncPassButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitEncPassButton.Location = new Point(330, 281);
            SubmitEncPassButton.Name = "SubmitEncPassButton";
            SubmitEncPassButton.Size = new Size(144, 49);
            SubmitEncPassButton.TabIndex = 1;
            SubmitEncPassButton.Text = "Submit";
            SubmitEncPassButton.UseVisualStyleBackColor = true;
            // 
            // EncryptionPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SubmitEncPassButton);
            Controls.Add(EncryptionPassTextbox);
            Name = "EncryptionPasswordForm";
            Text = "Encryption Password Prompt";
            Load += EncryptionPasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EncryptionPassTextbox;
        private Button SubmitEncPassButton;
        private ToolTip encToolTip;
    }
}