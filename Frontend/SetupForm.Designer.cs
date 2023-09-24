﻿namespace SimpleSecUtility.Frontend
{
    partial class SetupForm
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
            SetupInfoPanel = new Panel();
            SetupInfoLabel = new Label();
            MasterPasswordTextbox = new TextBox();
            MasterPassSubmitButton = new Button();
            SetupInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SetupInfoPanel
            // 
            SetupInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            SetupInfoPanel.Controls.Add(SetupInfoLabel);
            SetupInfoPanel.Dock = DockStyle.Top;
            SetupInfoPanel.Location = new Point(0, 0);
            SetupInfoPanel.Name = "SetupInfoPanel";
            SetupInfoPanel.Size = new Size(1070, 247);
            SetupInfoPanel.TabIndex = 0;
            // 
            // SetupInfoLabel
            // 
            SetupInfoLabel.AutoSize = true;
            SetupInfoLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SetupInfoLabel.Location = new Point(159, 8);
            SetupInfoLabel.Name = "SetupInfoLabel";
            SetupInfoLabel.Size = new Size(0, 28);
            SetupInfoLabel.TabIndex = 0;
            SetupInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MasterPasswordTextbox
            // 
            MasterPasswordTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MasterPasswordTextbox.Location = new Point(315, 329);
            MasterPasswordTextbox.Name = "MasterPasswordTextbox";
            MasterPasswordTextbox.PasswordChar = '*';
            MasterPasswordTextbox.PlaceholderText = "Enter Master Password";
            MasterPasswordTextbox.Size = new Size(461, 37);
            MasterPasswordTextbox.TabIndex = 1;
            // 
            // MasterPassSubmitButton
            // 
            MasterPassSubmitButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MasterPassSubmitButton.Location = new Point(480, 440);
            MasterPassSubmitButton.Name = "MasterPassSubmitButton";
            MasterPassSubmitButton.Size = new Size(150, 52);
            MasterPassSubmitButton.TabIndex = 2;
            MasterPassSubmitButton.Text = "Submit";
            MasterPassSubmitButton.UseVisualStyleBackColor = true;
            // 
            // SetupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 550);
            ControlBox = false;
            Controls.Add(MasterPassSubmitButton);
            Controls.Add(MasterPasswordTextbox);
            Controls.Add(SetupInfoPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SetupForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setup";
            Load += SetupForm_Load;
            SetupInfoPanel.ResumeLayout(false);
            SetupInfoPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel SetupInfoPanel;
        private Label SetupInfoLabel;
        private TextBox MasterPasswordTextbox;
        private Button MasterPassSubmitButton;
    }
}