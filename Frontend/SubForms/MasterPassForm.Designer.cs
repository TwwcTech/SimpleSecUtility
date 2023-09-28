namespace SimpleSecUtility.Frontend.SubForms
{
    partial class MasterPassForm
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
            masterPassTextbox = new TextBox();
            submitMasterPassButton = new Button();
            SuspendLayout();
            // 
            // masterPassTextbox
            // 
            masterPassTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            masterPassTextbox.Location = new Point(174, 121);
            masterPassTextbox.Name = "masterPassTextbox";
            masterPassTextbox.PasswordChar = '*';
            masterPassTextbox.PlaceholderText = "Enter Master Password";
            masterPassTextbox.Size = new Size(455, 37);
            masterPassTextbox.TabIndex = 0;
            // 
            // submitMasterPassButton
            // 
            submitMasterPassButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitMasterPassButton.Location = new Point(315, 284);
            submitMasterPassButton.Name = "submitMasterPassButton";
            submitMasterPassButton.Size = new Size(144, 49);
            submitMasterPassButton.TabIndex = 1;
            submitMasterPassButton.Text = "Submit";
            submitMasterPassButton.UseVisualStyleBackColor = true;
            submitMasterPassButton.Click += submitMasterPassButton_Click;
            // 
            // MasterPassForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(submitMasterPassButton);
            Controls.Add(masterPassTextbox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MasterPassForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Master Password Prompt";
            Load += MasterPassForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox masterPassTextbox;
        private Button submitMasterPassButton;
    }
}