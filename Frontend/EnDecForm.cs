using SimpleSecUtility.Backend.EnDec;

namespace SimpleSecUtility.Frontend
{
    public partial class EnDecForm : Form
    {
        string? _fileToEncrypt;
        string? _fileToDecrypt;

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
            FileEnDec.EncryptFile(fileOpener, fileSaver, _fileToEncrypt!, "password1234");
            fileOpener = new OpenFileDialog();
            fileOpener.Title = "Select a file to ecnrypt";
            fileOpener.Filter = "All files | *.*";
            fileOpener.InitialDirectory = @"C:\";
            if (fileOpener.ShowDialog() == DialogResult.OK)
            {
                _fileToEncrypt = fileOpener.FileName;
            }

            if (!string.IsNullOrEmpty(_fileToEncrypt) )
            {
                //FileEnDec.EncryptFile(_fileToEncrypt);
            }
            else
            {
                MessageBox.Show("No file to encrypt", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            fileOpener = new OpenFileDialog();
            fileOpener.Title = "Select a file to decrypt";
            fileOpener.Filter = "All files | *.*";
            fileOpener.InitialDirectory = @"C:\";
            if (fileOpener.ShowDialog() == DialogResult.OK)
            {
                _fileToDecrypt = fileOpener.FileName;
            }

            if (!string.IsNullOrEmpty(_fileToDecrypt))
            {
                //FileEnDec.DecryptFile(_fileToDecrypt);
            }
            else
            {
                MessageBox.Show("No file to decrypt", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}