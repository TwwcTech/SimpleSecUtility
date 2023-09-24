using SimpleSecUtility.AppResources;
using SimpleSecUtility.Backend;
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
            SetupFormTooltip.SetToolTip(SetupControlsPanel, Statics.PasswordRequirementsInfo);
            SetupFormTooltip.SetToolTip(MasterPassSubmitButton, "Click to submit the master password entry");
        }

        private void MasterPassSubmitButton_Click(object sender, EventArgs e)
        {
            TextBox[] setupInputs = new TextBox[] { MasterPasswordTextbox };
            bool areTextboxInputsEmpty = EmptyChecks.Instance.AreTextboxInputsEmpty(setupInputs);

            if (areTextboxInputsEmpty == false)
            {
                string masterPassword = MasterPasswordTextbox.Text.Trim();
                bool isPasswordSecure = PasswordSecurityCheck.Instance!.IsPasswordSecure(masterPassword);

                if (isPasswordSecure)
                {
                    string hashedPassword = Hasher.Hash(masterPassword);
                    // Testing
                    MessageBox.Show($"Hashed Password:\n{hashedPassword}");
                    //SetupManager.RunSetup(hashedPassword, apiKey);
                }
                else
                {
                    MessageBox.Show(Statics.PasswordRequirementsInfo, "Password Entry Error");
                }
            }
            else
            {
                MessageBox.Show("Entry or Entries must not be empty", "Entry Error");
            }
        }
    }
}