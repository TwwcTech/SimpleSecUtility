using CredentialManagement;

namespace SimpleSecUtility.Backend.WinCredsManager
{
    internal class ManageWinCreds
    {
        public static void CreateNewCredential(string targetName, string username, string password)
        {
            var newCredential = new Credential
            {
                Target = targetName,
                Username = username,
                Password = password,
                PersistanceType = PersistanceType.LocalComputer,
                Type = CredentialType.Generic
            };

            bool saveStatus = newCredential.Save();

            if (saveStatus)
            {
                return;
            }
            else
            {
                MessageBox.Show("Unable to save newCredential", "Credential Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool DoesCredentialExist(string targetName)
        {
            var credentialToCheck = new Credential { Target = targetName };
            if (credentialToCheck.Load())
            {
                return true;
            }
            return false;
        }

        public static string GetSecret(string targetName)
        {
            var existingCredential = new Credential { Target = targetName };
            string secret = string.Empty;

            bool loadStatus = existingCredential.Load();
            if (loadStatus)
            {
                secret = existingCredential.Password;
            }
            return secret;
        }
    }
}
