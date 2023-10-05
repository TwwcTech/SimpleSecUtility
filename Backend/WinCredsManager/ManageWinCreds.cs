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

        public static string GetGUID(string targetName)
        {
            var guidCredential = new Credential { Target = targetName };
            string fileGUID = string.Empty;

            bool loadStatus = guidCredential.Load();
            if (loadStatus)
            {
                if (GuidGenerator.IsGuid(guidCredential.Target))
                {
                    fileGUID = guidCredential.Target.ToString();
                }
            }
            return fileGUID;
        }

        public static string GetOgFileName(string targetName)
        {
            var ogFileCredential = new Credential { Target = targetName };
            string ogFileName = string.Empty;

            bool loadStatus = ogFileCredential.Load();
            if (loadStatus)
            {
                ogFileName = ogFileCredential.Username;
            }
            return ogFileName;
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
