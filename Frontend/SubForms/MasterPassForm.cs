using SimpleSecUtility.Backend;
using SimpleSecUtility.Backend.InputChecks;
using SimpleSecUtility.Backend.WinCredsManager;

namespace SimpleSecUtility.Frontend.SubForms
{
    public partial class MasterPassForm : Form
    {
        public MasterPassForm()
        {
            InitializeComponent();
        }

        private void MasterPassForm_Load(object sender, EventArgs e)
        {
            ActiveControl = submitMasterPassButton;
        }

        private void submitMasterPassButton_Click(object sender, EventArgs e)
        {
            TextBox[] masterPasswordTextbox = new TextBox[] { masterPassTextbox };
            bool isMasterPasswordTextboxEmpty = EmptyChecks.Instance.AreTextboxInputsEmpty(masterPasswordTextbox);

            if (!isMasterPasswordTextboxEmpty)
            {
                if (PasswordSecurityCheck.Instance!.IsPasswordSecure(masterPassTextbox.Text))
                {
                    string hashedMasterPass = Hasher.Hash(masterPassTextbox.Text);
                    if (hashedMasterPass == ManageWinCreds.GetSecret("SSU_master"))
                    {
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Entry must not be empty", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
