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

        /* - Connect the button event handlers */

        private void MainForm_Load(object sender, EventArgs e)
        {
            bool setupStatus = SetupManager.HasAppBeenSetup();
            if (setupStatus is false)
            {
                DialogResult continueSetupResult = MessageBox.Show("Simple Sec Utility has never been run. Would you like to continue with seutp?", "Setup Check", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (continueSetupResult == DialogResult.Yes)
                {
                    Form setupForm = new SetupForm();
                    setupForm.ShowDialog();
                }
                else if (continueSetupResult == DialogResult.No)
                {
                    Close();
                    Dispose();
                }
            }

            toolTip = new ToolTip();
            toolTip.SetToolTip(PassPinButton, "Generate a Secure Password or PIN");
            toolTip.SetToolTip(FileEnDecButton, "Encrypt or Decrypt a File");
        }
    }
}