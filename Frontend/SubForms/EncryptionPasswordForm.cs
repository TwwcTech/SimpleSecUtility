using SimpleSecUtility.Backend.EnDec;
using SimpleSecUtility.Backend.InputChecks;

namespace SimpleSecUtility.Frontend.SubForms
{
    // STEP 7

    public partial class EncryptionPasswordForm : Form
    {
        public EncryptionPasswordForm()
        {
            InitializeComponent();
        }

        private void EncryptionPasswordForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("A password will be required to encrypt the file", "Decryption Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActiveControl = SubmitEncPassButton;
        }

        private void SubmitEncPassButton_Click(object sender, EventArgs e)
        {
            // Event hanlder to handle the textbox and pass it to the encryption class

            TextBox[] EncryptionTextbox = new TextBox[] { EncryptionPassTextbox };
            bool isDecryptionTextboxEmpty = EmptyChecks.Instance.AreTextboxInputsEmpty(EncryptionTextbox);

            if (!isDecryptionTextboxEmpty)
            {
                if (PasswordSecurityCheck.Instance!.IsPasswordSecure(EncryptionPassTextbox.Text))
                {
                    FileEnDec.ProvisionAndEncryptFile(EncryptionPassTextbox.Text);
                    Close();
                }
            }
        }
    }
}
