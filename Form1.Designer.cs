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
            FileEnDecButton = new Button();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // PassPinButton
            // 
            PassPinButton.FlatAppearance.BorderSize = 0;
            PassPinButton.FlatStyle = FlatStyle.Flat;
            PassPinButton.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            PassPinButton.Image = (Image)resources.GetObject("PassPinButton.Image");
            PassPinButton.Location = new Point(12, 109);
            PassPinButton.Name = "PassPinButton";
            PassPinButton.Size = new Size(327, 259);
            PassPinButton.TabIndex = 0;
            PassPinButton.TextAlign = ContentAlignment.BottomCenter;
            PassPinButton.UseVisualStyleBackColor = true;
            PassPinButton.Click += PassPinButton_Click;
            // 
            // FileEnDecButton
            // 
            FileEnDecButton.FlatAppearance.BorderSize = 0;
            FileEnDecButton.FlatStyle = FlatStyle.Flat;
            FileEnDecButton.Image = (Image)resources.GetObject("FileEnDecButton.Image");
            FileEnDecButton.Location = new Point(370, 110);
            FileEnDecButton.Name = "FileEnDecButton";
            FileEnDecButton.Size = new Size(327, 259);
            FileEnDecButton.TabIndex = 1;
            FileEnDecButton.TextAlign = ContentAlignment.BottomCenter;
            FileEnDecButton.UseVisualStyleBackColor = true;
            FileEnDecButton.Click += FileEnDecButton_Click;
            // 
            // toolTip
            // 
            toolTip.AutomaticDelay = 150;
            toolTip.IsBalloon = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 476);
            Controls.Add(FileEnDecButton);
            Controls.Add(PassPinButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Simple Sec Utility";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button PassPinButton;
        private Button FileEnDecButton;
        private ToolTip toolTip;
    }
}