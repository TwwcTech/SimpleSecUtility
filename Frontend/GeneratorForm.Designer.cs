namespace SimpleSecUtility.Frontend
{
    partial class GeneratorForm
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
            ControlsPanel = new Panel();
            RequestButton = new Button();
            PinLengthLabel = new Label();
            PassLengthLabel = new Label();
            PinLengthPicker = new NumericUpDown();
            PasswordLengthPicker = new NumericUpDown();
            PinCheckbox = new CheckBox();
            PasswordCheckbox = new CheckBox();
            OutputPanel = new Panel();
            RequestResponseLabel = new Label();
            OutputLabelMenu = new ContextMenuStrip(components);
            copyToolStripMenuItem = new ToolStripMenuItem();
            OutputLabel = new Label();
            ControlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PinLengthPicker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PasswordLengthPicker).BeginInit();
            OutputPanel.SuspendLayout();
            OutputLabelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // ControlsPanel
            // 
            ControlsPanel.Controls.Add(RequestButton);
            ControlsPanel.Controls.Add(PinLengthLabel);
            ControlsPanel.Controls.Add(PassLengthLabel);
            ControlsPanel.Controls.Add(PinLengthPicker);
            ControlsPanel.Controls.Add(PasswordLengthPicker);
            ControlsPanel.Controls.Add(PinCheckbox);
            ControlsPanel.Controls.Add(PasswordCheckbox);
            ControlsPanel.Dock = DockStyle.Top;
            ControlsPanel.Location = new Point(0, 0);
            ControlsPanel.Name = "ControlsPanel";
            ControlsPanel.Size = new Size(1005, 403);
            ControlsPanel.TabIndex = 0;
            // 
            // RequestButton
            // 
            RequestButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RequestButton.Location = new Point(424, 264);
            RequestButton.Name = "RequestButton";
            RequestButton.Size = new Size(154, 57);
            RequestButton.TabIndex = 6;
            RequestButton.Text = "Request";
            RequestButton.UseVisualStyleBackColor = true;
            RequestButton.Click += RequestButton_Click;
            // 
            // PinLengthLabel
            // 
            PinLengthLabel.AutoSize = true;
            PinLengthLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PinLengthLabel.Location = new Point(400, 148);
            PinLengthLabel.Name = "PinLengthLabel";
            PinLengthLabel.Size = new Size(153, 30);
            PinLengthLabel.TabIndex = 5;
            PinLengthLabel.Text = "PIN Length :";
            // 
            // PassLengthLabel
            // 
            PassLengthLabel.AutoSize = true;
            PassLengthLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassLengthLabel.Location = new Point(400, 89);
            PassLengthLabel.Name = "PassLengthLabel";
            PassLengthLabel.Size = new Size(224, 30);
            PassLengthLabel.TabIndex = 4;
            PassLengthLabel.Text = "Password Length :";
            // 
            // PinLengthPicker
            // 
            PinLengthPicker.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PinLengthPicker.Location = new Point(665, 146);
            PinLengthPicker.Name = "PinLengthPicker";
            PinLengthPicker.Size = new Size(180, 37);
            PinLengthPicker.TabIndex = 3;
            PinLengthPicker.Leave += PinLengthPicker_Leave;
            // 
            // PasswordLengthPicker
            // 
            PasswordLengthPicker.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLengthPicker.Location = new Point(665, 89);
            PasswordLengthPicker.Name = "PasswordLengthPicker";
            PasswordLengthPicker.Size = new Size(180, 37);
            PasswordLengthPicker.TabIndex = 2;
            PasswordLengthPicker.Leave += PasswordLengthPicker_Leave;
            // 
            // PinCheckbox
            // 
            PinCheckbox.AutoSize = true;
            PinCheckbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PinCheckbox.Location = new Point(152, 144);
            PinCheckbox.Name = "PinCheckbox";
            PinCheckbox.Size = new Size(243, 34);
            PinCheckbox.TabIndex = 1;
            PinCheckbox.Text = "PIN ------------------- ";
            PinCheckbox.UseVisualStyleBackColor = true;
            PinCheckbox.CheckedChanged += PinCheckbox_CheckedChanged;
            // 
            // PasswordCheckbox
            // 
            PasswordCheckbox.AutoSize = true;
            PasswordCheckbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordCheckbox.Location = new Point(152, 89);
            PasswordCheckbox.Name = "PasswordCheckbox";
            PasswordCheckbox.Size = new Size(242, 34);
            PasswordCheckbox.TabIndex = 0;
            PasswordCheckbox.Text = "Password ---------- ";
            PasswordCheckbox.UseVisualStyleBackColor = true;
            PasswordCheckbox.CheckedChanged += PasswordCheckbox_CheckedChanged;
            // 
            // OutputPanel
            // 
            OutputPanel.BorderStyle = BorderStyle.FixedSingle;
            OutputPanel.Controls.Add(RequestResponseLabel);
            OutputPanel.Controls.Add(OutputLabel);
            OutputPanel.Dock = DockStyle.Bottom;
            OutputPanel.Location = new Point(0, 409);
            OutputPanel.Name = "OutputPanel";
            OutputPanel.Size = new Size(1005, 198);
            OutputPanel.TabIndex = 1;
            // 
            // RequestResponseLabel
            // 
            RequestResponseLabel.AutoSize = true;
            RequestResponseLabel.ContextMenuStrip = OutputLabelMenu;
            RequestResponseLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RequestResponseLabel.Location = new Point(368, 89);
            RequestResponseLabel.Name = "RequestResponseLabel";
            RequestResponseLabel.Size = new Size(0, 28);
            RequestResponseLabel.TabIndex = 1;
            RequestResponseLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OutputLabelMenu
            // 
            OutputLabelMenu.ImageScalingSize = new Size(24, 24);
            OutputLabelMenu.Items.AddRange(new ToolStripItem[] { copyToolStripMenuItem });
            OutputLabelMenu.Name = "OutputLabelMenu";
            OutputLabelMenu.Size = new Size(127, 36);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(126, 32);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Font = new Font("Century Gothic", 10F, FontStyle.Underline, GraphicsUnit.Point);
            OutputLabel.Location = new Point(462, 0);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(81, 23);
            OutputLabel.TabIndex = 0;
            OutputLabel.Text = "OUTPUT";
            // 
            // GeneratorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 607);
            Controls.Add(OutputPanel);
            Controls.Add(ControlsPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "GeneratorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GeneratorForm";
            Load += GeneratorForm_Load;
            ControlsPanel.ResumeLayout(false);
            ControlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PinLengthPicker).EndInit();
            ((System.ComponentModel.ISupportInitialize)PasswordLengthPicker).EndInit();
            OutputPanel.ResumeLayout(false);
            OutputPanel.PerformLayout();
            OutputLabelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ControlsPanel;
        private Panel OutputPanel;
        private CheckBox PinCheckbox;
        private CheckBox PasswordCheckbox;
        private Label PassLengthLabel;
        private NumericUpDown PinLengthPicker;
        private NumericUpDown PasswordLengthPicker;
        private Label PinLengthLabel;
        private Button RequestButton;
        private Label OutputLabel;
        private Label RequestResponseLabel;
        private ContextMenuStrip OutputLabelMenu;
        private ToolStripMenuItem copyToolStripMenuItem;
    }
}