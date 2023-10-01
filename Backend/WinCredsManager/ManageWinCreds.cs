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

        public static string GetPassword(string targetName)
        {
            var existingCredential = new Credential { Target = targetName };

            bool loadStatus = existingCredential.Load();
            if (!loadStatus)
            {
                MessageBox.Show("Unable to load newCredential", "Credential Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return existingCredential.Password;
        }
    }
}
