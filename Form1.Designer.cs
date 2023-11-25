namespace SimpleSecUtility
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PassPinButton = new Button();
            toolTip = new ToolTip(components);
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PassPinButton
            // 
            PassPinButton.Dock = DockStyle.Fill;
            PassPinButton.FlatAppearance.BorderSize = 0;
            PassPinButton.FlatStyle = FlatStyle.Flat;
            PassPinButton.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            PassPinButton.Image = (Image)resources.GetObject("PassPinButton.Image");
            PassPinButton.Location = new Point(0, 0);
            PassPinButton.Name = "PassPinButton";
            PassPinButton.Size = new Size(824, 690);
            PassPinButton.TabIndex = 0;
            PassPinButton.TextAlign = ContentAlignment.BottomCenter;
            PassPinButton.UseVisualStyleBackColor = true;
            PassPinButton.Click += PassPinButton_Click;
            // 
            // toolTip
            // 
            toolTip.AutomaticDelay = 150;
            toolTip.IsBalloon = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(PassPinButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 690);
            panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(824, 690);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button PassPinButton;
        private ToolTip toolTip;
        private Panel panel1;
    }
}