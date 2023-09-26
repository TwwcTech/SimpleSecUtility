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
            //    fileOpener = new OpenFileDialog();
            //    fileOpener.Title = "Select a file to ecnrypt";
            //    fileOpener.Filter = "All files | *.*";
            //    fileOpener.InitialDirectory = @"C:\";
            //    if (fileOpener.ShowDialog() == DialogResult.OK)
            //    {
            //        _fileToEncrypt = fileOpener.FileName;
            //    }
        }
    }
}