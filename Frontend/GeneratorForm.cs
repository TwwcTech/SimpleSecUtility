namespace SimpleSecUtility.Frontend
{
    public partial class GeneratorForm : Form
    {
        public GeneratorForm()
        {
            InitializeComponent();
        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            // Code goes here       
        }

        private void PasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Code goes here
        }

        private void PinCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Code goes here
        }

        private void PasswordLengthPicker_ValueChanged(object sender, EventArgs e)
        {
            if (PasswordLengthPicker.Value < 8)
            {
                MessageBox.Show("Password must be a minumum length of 8", "Password Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PinLengthPicker_ValueChanged(object sender, EventArgs e)
        {
            if (PinLengthPicker.Value < 4 ||  PinLengthPicker.Value > 6)
            {
                MessageBox.Show("PIN must be a minimum length of 4 and no greater than 6", "PIN Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            // Code goes here
        }
    }
}
