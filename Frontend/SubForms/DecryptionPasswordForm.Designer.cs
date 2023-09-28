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
            CancelDecButton = new Button();
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
            SubmitDecPassButton.Location = new Point(241, 277);
            SubmitDecPassButton.Name = "SubmitDecPassButton";
            SubmitDecPassButton.Size = new Size(144, 49);
            SubmitDecPassButton.TabIndex = 1;
            SubmitDecPassButton.Text = "Submit";
            SubmitDecPassButton.UseVisualStyleBackColor = true;
            SubmitDecPassButton.Click += SubmitDecPassButton_Click;
            // 
            // CancelDecButton
            // 
            CancelDecButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelDecButton.Location = new Point(410, 277);
            CancelDecButton.Name = "CancelDecButton";
            CancelDecButton.Size = new Size(144, 49);
            CancelDecButton.TabIndex = 2;
            CancelDecButton.Text = "Cancel";
            CancelDecButton.UseVisualStyleBackColor = true;
            CancelDecButton.Click += CancelDecButton_Click;
            // 
            // DecryptionPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelDecButton);
            Controls.Add(SubmitDecPassButton);
            Controls.Add(DecryptionPassTextbox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
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
        private Button CancelDecButton;
    }
}