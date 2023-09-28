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

        }
    }
}
