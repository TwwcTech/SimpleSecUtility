using SimpleSecUtility.Frontend;

namespace SimpleSecUtility
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AcceptButton = PassPinButton;

            toolTip = new ToolTip();
            toolTip.SetToolTip(PassPinButton, "Generate a Secure Password or PIN");
        }

        private void PassPinButton_Click(object sender, EventArgs e)
        {
            Hide();
            GeneratorForm passPinGeneratorForm = new();
            passPinGeneratorForm.ShowDialog();
            passPinGeneratorForm.WindowState = FormWindowState.Normal;

            if (!passPinGeneratorForm.Visible)
            {
                Show();
                WindowState = FormWindowState.Normal;
                Focus();
            }
        }
    }
}