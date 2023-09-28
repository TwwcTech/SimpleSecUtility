using SimpleSecUtility.Backend;
using SimpleSecUtility.Backend.AppRegistry;
using SimpleSecUtility.Backend.InputChecks;

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

        }

        private void submitMasterPassButton_Click(object sender, EventArgs e)
        {
            TextBox[] masterPasswordTextbox = new TextBox[] { masterPassTextbox };
            bool isMasterPasswordTextboxEmpty = EmptyChecks.Instance.AreTextboxInputsEmpty(masterPasswordTextbox);

            if (!isMasterPasswordTextboxEmpty )
            {
                if (PasswordSecurityCheck.Instance!.IsPasswordSecure(masterPassTextbox.Text))
                {
                    string hashedMasterPass = Hasher.Hash(masterPassTextbox.Text);
                    if (hashedMasterPass == RegistryReader.ReadApiKey("master"))
                    {
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Master Password", "Master Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
