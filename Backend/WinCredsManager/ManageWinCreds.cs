using CredentialManagement;

namespace SimpleSecUtility.Backend.WinCredsManager
{
    internal class ManageWinCreds
    {
        public static void CreateNewCredential(string targetName, string username, string password)
        {
            var credential = new Credential
            {
                Target = targetName,
                Username = username,
                Password = password,
                PersistanceType = PersistanceType.LocalComputer,
                Type = CredentialType.Generic
            };

            bool saveStatus = credential.Save();

            if (saveStatus)
            {
                return;
            }
            else
            {
                MessageBox.Show("Unable to save credential", "Credential Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ReadCredential(string targetName)
        {
            // Code goes here
        }
    }
}
