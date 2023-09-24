using SimpleSecUtility.AppResources;
using SimpleSecUtility.Backend;
using SimpleSecUtility.Backend.AppSetup;
using SimpleSecUtility.Backend.InputChecks;

namespace SimpleSecUtility.Frontend
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            SetupInfoLabel.Text = Statics.SetupInfo;
            SetupInfoLabel.TextAlign = ContentAlignment.MiddleCenter;

            ActiveControl = MasterPassSubmitButton;
        }

        private void MasterPassSubmitButton_Click(object sender, EventArgs e)
        {
            TextBox[] setupInputs = new TextBox[] { MasterPasswordTextbox };
            bool areTextboxInputsEmpty = InputChecks.Instance.AreTextboxInputsEmpty(setupInputs);
            if (areTextboxInputsEmpty ==  false)
            {
                string hashedPassword = Hasher.Hash(MasterPasswordTextbox.Text.Trim());
                SetupManager.RunSetup(hashedPassword);
            }
        }
    }
}
