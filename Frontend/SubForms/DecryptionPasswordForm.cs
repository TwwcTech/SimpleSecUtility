using SimpleSecUtility.Backend.InputChecks;

namespace SimpleSecUtility.Frontend.SubForms
{
    public partial class DecryptionPasswordForm : Form
    {
        public DecryptionPasswordForm()
        {
            InitializeComponent();
        }

        private void DecryptionPasswordForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("A password will be require to encrypt the file", "Encryption Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SubmitDecPassButton_Click(object sender, EventArgs e)
        {
            TextBox[] decryptionTextbox = new TextBox[] { DecryptionPassTextbox };
            bool isDecryptionTextboxEmpty = EmptyChecks.Instance.AreTextboxInputsEmpty(decryptionTextbox);

            if (!isDecryptionTextboxEmpty)
            {
                if(PasswordSecurityCheck.Instance!.IsPasswordSecure(DecryptionPassTextbox.Text))
                {
                    // Code goes here
                }
            }
        }
    }
}
