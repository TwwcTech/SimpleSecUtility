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
                    // REMOVE WHEN READY
                    // Testing
                    MessageBox.Show($"Hashed Password:\n{hashedPassword}");
                    //SetupManager.RunSetup(hashedPassword, apiKeyTextbox.Text.Trim());
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