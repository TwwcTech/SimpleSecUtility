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

            SetupFormTooltip = new ToolTip();
            SetupFormTooltip.SetToolTip(SetupInfoPanel, "Setup Information");
            SetupFormTooltip.SetToolTip(MasterPassSubmitButton, "Click to submit the master password entry");
        }

        private void MasterPassSubmitButton_Click(object sender, EventArgs e)
        {
            TextBox[] setupInputs = new TextBox[] { MasterPasswordTextbox };
            bool areTextboxInputsEmpty = EmptyChecks.Instance.AreTextboxInputsEmpty(setupInputs);

            if (areTextboxInputsEmpty == false)
            {
                bool isPasswordSecure = PasswordSecurityCheck.Instance!.IsPasswordSecure(MasterPasswordTextbox.Text.Trim());
                if (isPasswordSecure)
                {
                    string hashedPassword = Hasher.Hash(MasterPasswordTextbox.Text.Trim());
                    SetupManager.RunSetup(hashedPassword);
                }
            }
            else
            {
                MessageBox.Show("Entry or Entries must not be empty", "Entry Error");
            }
        }
    }
}
