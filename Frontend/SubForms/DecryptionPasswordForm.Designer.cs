namespace SimpleSecUtility.Frontend.SubForms
{
    partial class DecryptionPasswordForm
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
            DecryptionPassTextbox = new TextBox();
            SubmitDecPassButton = new Button();
            decToolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // DecryptionPassTextbox
            // 
            DecryptionPassTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DecryptionPassTextbox.Location = new Point(174, 121);
            DecryptionPassTextbox.Name = "DecryptionPassTextbox";
            DecryptionPassTextbox.PasswordChar = '*';
            DecryptionPassTextbox.PlaceholderText = "Enter password to decrypt the file";
            DecryptionPassTextbox.Size = new Size(455, 37);
            DecryptionPassTextbox.TabIndex = 0;
            // 
            // SubmitDecPassButton
            // 
            SubmitDecPassButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitDecPassButton.Location = new Point(330, 281);
            SubmitDecPassButton.Name = "SubmitDecPassButton";
            SubmitDecPassButton.Size = new Size(144, 49);
            SubmitDecPassButton.TabIndex = 1;
            SubmitDecPassButton.Text = "Submit";
            SubmitDecPassButton.UseVisualStyleBackColor = true;
            SubmitDecPassButton.Click += SubmitDecPassButton_Click;
            // 
            // DecryptionPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SubmitDecPassButton);
            Controls.Add(DecryptionPassTextbox);
            Name = "DecryptionPasswordForm";
            Text = "Decryption Password Prompt";
            Load += DecryptionPasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DecryptionPassTextbox;
        private Button SubmitDecPassButton;
        private ToolTip decToolTip;
    }
}