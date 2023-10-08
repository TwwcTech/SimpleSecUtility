using SimpleSecUtility.Backend.EnDec;
using SimpleSecUtility.Backend.InputChecks;

namespace SimpleSecUtility.Frontend.SubForms
{
    // STEP 7.1

    public partial class DecryptionPasswordForm : Form
    {
        public DecryptionPasswordForm()
        {
            InitializeComponent();
        }

        private void DecryptionPasswordForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("A password will be require to decrypt the file", "Encryption Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActiveControl = SubmitDecPassButton;
        }

        private void SubmitDecPassButton_Click(object sender, EventArgs e)
        {
            // Event hanlder to handle the textbox and pass it to the decryption class

            TextBox[] decryptionTextbox = new TextBox[] { DecryptionPassTextbox };
            bool isDecryptionTextboxEmpty = EmptyChecks.Instance.AreTextboxInputsEmpty(decryptionTextbox);

            if (!isDecryptionTextboxEmpty)
            {
                FileEnDec.ScanMetaAndDecryptFile(DecryptionPassTextbox.Text);
                Close();
            }
        }
    }
}
