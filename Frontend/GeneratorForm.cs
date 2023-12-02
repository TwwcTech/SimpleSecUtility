using SimpleSecUtility.Backend.InputChecks;
using SimpleSecUtility.Backend.SecureGenerator;

namespace SimpleSecUtility.Frontend
{
    public partial class GeneratorForm : Form
    {
        readonly string SpecialCharacters = "!@$%&?";

        public GeneratorForm()
        {
            InitializeComponent();
        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            PassLengthLabel.Enabled = false;
            PinLengthLabel.Enabled = false;
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

        private void PasswordLengthPicker_ValueChanged(object sender, EventArgs e)
        {
            PasswordLengthPicker.Value = PasswordLengthPicker.Value < 8 ? 8 : PasswordLengthPicker.Value;
            PasswordLengthPicker.Value = PasswordLengthPicker.Value > 25 ? 25 : PasswordLengthPicker.Value;
        }

        private void PinLengthPicker_ValueChanged(object sender, EventArgs e)
        {
            PinLengthPicker.Value = PinLengthPicker.Value < 4 ? 4 : PinLengthPicker.Value;
            PinLengthPicker.Value = PinLengthPicker.Value > 6 ? 6 : PinLengthPicker.Value;
        }

        private async void RequestButton_Click(object sender, EventArgs e)
        {
            if (!PasswordCheckbox.Checked && !PinCheckbox.Checked)
            {
                MessageBox.Show("An option must be checked, please select an option above", "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PasswordCheckbox.Checked)
            {
                NumericUpDown[] passwordLengthPicker = new NumericUpDown[] { PasswordLengthPicker };
                bool isPasswordLengthPickerEmptyorZero = EmptyChecks.Instance.AreNumericBoxInputsEmpty(passwordLengthPicker);
                if (!isPasswordLengthPickerEmptyorZero)
                {
                    string securePassword = await PassPin.ReturnSecurePasswordOrPIN("password", (int)PasswordLengthPicker.Value);
                    RequestResponseLabel.Text = securePassword.Replace(securePassword[new Random().Next(0, securePassword.Length)], SpecialCharacters[new Random().Next(0, SpecialCharacters.Length)]);
                    RequestResponseLabel.Location = new Point((OutputPanel.Width - RequestResponseLabel.Width) / 2, (OutputPanel.Height - RequestResponseLabel.Height) / 2);
                    RequestResponseLabel.BorderStyle = BorderStyle.FixedSingle;
                    RequestResponseLabel.Focus();
                }
                else
                {
                    MessageBox.Show("Password Length Picker must not be empty or 0", "Password Lenght Picker Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (PinCheckbox.Checked)
            {
                NumericUpDown[] pinLengthPicker = new NumericUpDown[] { PinLengthPicker };
                bool isPinLengthCheckerEmptyOrZero = EmptyChecks.Instance.AreNumericBoxInputsEmpty(pinLengthPicker);
                if (!isPinLengthCheckerEmptyOrZero)
                {
                    string securePIN = await PassPin.ReturnSecurePasswordOrPIN("pin", (int)PinLengthPicker.Value);
                    if (securePIN.Length > 4)
                    {
                        RequestResponseLabel.Text = securePIN.Replace(securePIN[new Random().Next(0, securePIN.Length)], SpecialCharacters[new Random().Next(0, SpecialCharacters.Length)]);
                    }
                    else
                    {
                        RequestResponseLabel.Text = securePIN;
                    }
                    RequestResponseLabel.Location = new Point((OutputPanel.Width - RequestResponseLabel.Width) / 2, (OutputPanel.Height - RequestResponseLabel.Height) / 2);
                    RequestResponseLabel.BorderStyle = BorderStyle.FixedSingle;
                    RequestResponseLabel.Focus();
                }
                else
                {
                    MessageBox.Show("PIN Length Picker must not be empty or 0", "Pin Length Picker Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RequestResponseLabel.Text);
        }
    }
}