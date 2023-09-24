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
            PasswordLengthPicker.Enabled = false;
            PinLengthPicker.Enabled = false;
        }

        private void PasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCheckbox.Checked)
            {
                PasswordLengthPicker.Enabled = true;

                PinCheckbox.Enabled = false;
                PinLengthPicker.Enabled = false;
            }
            else if (!PasswordCheckbox.Checked)
            {
                PasswordLengthPicker.Enabled = false;

                PinCheckbox.Enabled = true;
            }
        }

        private void PinCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PinCheckbox.Checked)
            {
                PinLengthPicker.Enabled = true;

                PasswordCheckbox.Enabled = false;
                PasswordLengthPicker.Enabled = false;
            }
            else if (!PinCheckbox.Checked)
            {
                PinLengthPicker.Enabled = false;

                PasswordCheckbox.Enabled = true;
            }
        }

        private void PasswordLengthPicker_ValueChanged(object sender, EventArgs e)
        {
            if (PasswordLengthPicker.Value < 8)
            {
                MessageBox.Show("Password must be a minumum length of 8", "Password Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordLengthPicker.Focus();
            }
        }

        private void PasswordLengthPicker_Leave(object sender, EventArgs e)
        {
            if (PasswordLengthPicker.Value < 8)
            {
                MessageBox.Show("Password must be a minumum length of 8", "Password Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordLengthPicker.Focus();
            }
        }

        private void PinLengthPicker_ValueChanged(object sender, EventArgs e)
        {
            if (PinLengthPicker.Value < 4 || PinLengthPicker.Value > 6)
            {
                MessageBox.Show("PIN must be a minimum length of 4 and no greater than 6", "PIN Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PinLengthPicker.Focus();
            }
        }

        private void PinLengthPicker_Leave(object sender, EventArgs e)
        {
            if (PinLengthPicker.Value < 4 || PinLengthPicker.Value > 6)
            {
                MessageBox.Show("PIN must be a minimum length of 4 and no greater than 6", "PIN Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PinLengthPicker.Focus();
            }
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            // Code goes here
            MessageBox.Show("test");
        }
    }
}