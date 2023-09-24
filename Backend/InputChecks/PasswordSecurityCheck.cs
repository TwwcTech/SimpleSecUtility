using System.Text.RegularExpressions;

namespace SimpleSecUtility.Backend.InputChecks
{
    internal class PasswordSecurityCheck
    {
        private static PasswordSecurityCheck? _instance;
        private static readonly object _instanceLock = new();

        private PasswordSecurityCheck() { }

        public static PasswordSecurityCheck? Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new PasswordSecurityCheck();
                    }
                    return _instance;
                }
            }
        }

        public bool IsPasswordSecure(string password)
        {
            lock (_instanceLock)
            {
                Regex numbersRegex = new Regex(@"\d");
                Regex charactersRegex = new Regex(@"[-!@#$%^&*()?_,.]");

                if (password.Length >= 8 && numbersRegex.IsMatch(password) && charactersRegex.IsMatch(password))
                {
                    return true;
                }
                return false;
            }
        }
    }
}