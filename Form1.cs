using SimpleSecUtility.Backend.AppSetup;
using SimpleSecUtility.Frontend;

namespace SimpleSecUtility
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bool setupStatus = SetupManager.HasAppBeenSetup();
            if (!setupStatus)
            {
                DialogResult dialogResult = MessageBox.Show("Simple Sec Utility has never been run. Would you like to continue with seutp?", "Setup Check", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    Form setupForm = new SetupForm();
                    setupForm.ShowDialog();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Close();
                    Dispose();
                }
            }

            toolTip = new ToolTip();
            toolTip.SetToolTip(PassPinButton, "Generate a Secure Password or PIN");
            toolTip.SetToolTip(FileEnDecButton, "Encrypt or Decrypt a File");
        }

        private void PassPinButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Hide();

            Form passPinGeneratorForm = new GeneratorForm();
            passPinGeneratorForm.ShowDialog();
            if (passPinGeneratorForm.IsDisposed)
            {
                WindowState = FormWindowState.Normal;
                Visible = true;
                Focus();
            }
        }

        private void FileEnDecButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Hide();

            Form fileEnDecForm = new EnDecForm();
            fileEnDecForm.ShowDialog();
            if (fileEnDecForm.IsDisposed)
            {
                WindowState = FormWindowState.Normal;
                Visible = true;
                Focus();
            }
        }
    }
}