namespace SimpleSecUtility.Backend.InputChecks
{
    internal class InputChecks
    {
        private static InputChecks? _instance;
        private static readonly object _instanceLock = new();

        private InputChecks() { }

        public static InputChecks Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new InputChecks();
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
    }
}
