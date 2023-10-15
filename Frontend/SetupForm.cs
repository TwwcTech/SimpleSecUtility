using SimpleSecUtility.AppResources;
using SimpleSecUtility.Backend;
using SimpleSecUtility.Backend.AppSetup;
using SimpleSecUtility.Backend.InputChecks;

namespace SimpleSecUtility.Frontend
{
    // STEP 2

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
            TextBox[] setupInputs = new TextBox[] { MasterPasswordTextbox, apiKeyTextbox };
            bool areTextboxInputsEmpty = EmptyChecks.Instance.AreTextboxInputsEmpty(setupInputs);

            if (!areTextboxInputsEmpty)
            {
                string masterPassword = MasterPasswordTextbox.Text.Trim();
                bool isPasswordSecure = PasswordSecurityCheck.Instance!.IsPasswordSecure(masterPassword);

                if (isPasswordSecure)
                {
                    string hashedPassword = Hasher.Hash(masterPassword);
                    // Save hashed password to the Credential Manager
                    // Save the API Key to the Credential Manager
                    SetupManager.RunSetup(); 
                    MessageBox.Show("An internet connection will be required to use the Password/PIN Request Tool", "Quick Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show(Statics.PasswordRequirementsInfo, "Password Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Entry or Entries must not be empty", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}