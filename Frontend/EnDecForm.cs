using SimpleSecUtility.Backend.EnDec;

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
            // Enter correct password to continue
            // Implement the logic
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            FileEnDec.EncryptFile(fileOpener, fileSaver, "");
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            FileEnDec.DecryptFile(fileOpener, fileSaver, "");
        }
    }
}