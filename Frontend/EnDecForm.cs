using SimpleSecUtility.Frontend.SubForms;

namespace SimpleSecUtility.Frontend
{
    public partial class EnDecForm : Form
    {
        public EnDecForm()
        {
            InitializeComponent();
        }

        private void EnDecForm_Load(object sender, EventArgs e)
        {
            Form masterPassForm = new MasterPassForm();
            masterPassForm.ShowDialog();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            Form encryptionPassForm = new EncryptionPasswordForm();
            encryptionPassForm.ShowDialog();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            Form decryptionPassForm = new DecryptionPasswordForm();
            decryptionPassForm.ShowDialog();
        }
    }
}