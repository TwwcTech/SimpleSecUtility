using Microsoft.Win32;
using SimpleSecUtility.AppResources;

namespace SimpleSecUtility.Backend.AppSetup
{
    internal class SetupManager
    {
        public static bool HasAppBeenSetup()
        {
            using (RegistryKey setupStatusKey = Registry.CurrentUser.OpenSubKey(Statics.RegPath)!)
            {
                try
                {
                    if (setupStatusKey != null)
                    {
                        return true;
                    }
                }
                catch (Exception ex) { ex.ToString(); }
                return false;
            }
        }

        public static void RunSetup(string masterPassword)
        {
            using (RegistryKey setupKey = Registry.CurrentUser.CreateSubKey(Statics.RegPath))
            {
                if (setupKey != null)
                {
                    setupKey.SetValue("Setup Date", DateTime.Now.ToString("ddMMyyyy"));
                    setupKey.SetValue("Version", Statics.AppVersion);
                    setupKey.SetValue("Master", Hasher.Hash(masterPassword));
                }
            }
        }
    }
}
