using SimpleSecUtility.Backend.InputChecks;
using SimpleSecUtility.Backend.SecureGenerator;

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
            PasswordLengthPicker.Enabled = false;
            PinLengthPicker.Enabled = false;
        }

        private void PasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCheckbox.Checked)
            {
                PasswordLengthPicker.Enabled = true;

                PinCheckbox.Enabled = false;
                PinLengthLabel.Enabled = false;
                PinLengthPicker.Enabled = false;
            }
            else if (!PasswordCheckbox.Checked)
            {
                PasswordLengthPicker.Enabled = false;
                PinCheckbox.Enabled = true;
                RequestResponseLabel.Text = string.Empty;
            }
        }

        private void PinCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PinCheckbox.Checked)
            {
                PinLengthPicker.Enabled = true;

                PasswordCheckbox.Enabled = false;
                PassLengthLabel.Enabled = false;
                PasswordLengthPicker.Enabled = false;
            }
            else if (!PinCheckbox.Checked)
            {
                PinLengthPicker.Enabled = false;
                PasswordCheckbox.Enabled = true;
                RequestResponseLabel.Text = string.Empty;
            }
        }

        private void PasswordLengthPicker_Leave(object sender, EventArgs e)
        {
            if (PasswordLengthPicker.Value < 8 || PasswordLengthPicker.Value > 25)
            {
                MessageBox.Show("Password must be a minumum length of 8 and no greater than 25", "Password Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordLengthPicker.Focus();
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

        private async void RequestButton_Click(object sender, EventArgs e)
        {
            NumericUpDown[] lengthPickers = new NumericUpDown[] { PasswordLengthPicker, PinLengthPicker };
            bool areLengthPickersEmptyorZero = EmptyChecks.Instance.AreNumericBoxInputsEmpty(lengthPickers);

            if (!areLengthPickersEmptyorZero)
            {
                if (!PasswordCheckbox.Checked && !PinCheckbox.Checked)
                {
                    MessageBox.Show("An option must be checked, please select an option above", "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (PasswordCheckbox.Checked)
                {
                    string securePassword = await PassPin.ReturnSecurePasswordOrPIN("password", (int)PasswordLengthPicker.Value);
                    RequestResponseLabel.Text = securePassword;
                    RequestResponseLabel.Location = new Point((OutputPanel.Width - RequestResponseLabel.Width) / 2, (OutputPanel.Height - RequestResponseLabel.Height) / 2);
                    RequestResponseLabel.BorderStyle = BorderStyle.FixedSingle;
                    RequestResponseLabel.Focus();
                }
                else if (PinCheckbox.Checked)
                {
                    string securePIN = await PassPin.ReturnSecurePasswordOrPIN("pin", (int)PinLengthPicker.Value);
                    RequestResponseLabel.Text = securePIN;
                    RequestResponseLabel.Location = new Point((OutputPanel.Width - RequestResponseLabel.Width) / 2, (OutputPanel.Height - RequestResponseLabel.Height) / 2);
                    RequestResponseLabel.BorderStyle = BorderStyle.FixedSingle;
                    RequestResponseLabel.Focus();
                }
            }
            else
            {
                MessageBox.Show("Length Pickers must not be emtpy or 0", "Length Picker Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RequestResponseLabel.Text);
        }
    }
}