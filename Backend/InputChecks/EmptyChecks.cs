namespace SimpleSecUtility.Backend.InputChecks
{
    internal class EmptyChecks
    {
        private static EmptyChecks? _instance;
        private static readonly object _instanceLock = new();

        private EmptyChecks() { }

        public static EmptyChecks Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new EmptyChecks();
                    }
                    return _instance;
                }
            }
        }

        public bool AreTextboxInputsEmpty(TextBox[] textBoxes)
        {
            lock (_instanceLock)
            {
                int emptyTextboxes = textBoxes.Length;

                foreach (TextBox textBox in textBoxes)
                {
                    if (!string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        emptyTextboxes--;
                    }
                }

                if (emptyTextboxes == 0)
                {
                    return false;
                }
                return true;
            }
        }

        public bool AreNumericBoxInputsEmpty(NumericUpDown[] numericboxes)
        {
            lock (_instanceLock)
            {
                int emptyNumericBoxes = numericboxes.Length;

                foreach(NumericUpDown numericBox in numericboxes)
                {
                    if (!string.IsNullOrWhiteSpace(numericBox.Text))
                    {
                        emptyNumericBoxes--;
                    }
                }

                if (emptyNumericBoxes == 0)
                {
                    return false;
                }
                return true;
            }
        }
    }
}