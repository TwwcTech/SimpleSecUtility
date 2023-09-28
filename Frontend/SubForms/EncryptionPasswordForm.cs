namespace SimpleSecUtility.Frontend.SubForms
{
    public partial class EncryptionPasswordForm : Form
    {
        public EncryptionPasswordForm()
        {
            InitializeComponent();
        }

        private void EncryptionPasswordForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("A password will be required to decrypt the file", "Decryption Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SubmitEncPassButton_Click(object sender, EventArgs e)
        {

        }
    }
}
