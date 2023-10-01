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
                if (setupStatusKey != null)
                {
                    return true;
                }
                return false;
            }
        }

        public static void RunSetup(string masterPassword, string apiKey)
        {

            /* When ready, remove the params
             * and only add the "Setup Date"
             * and "Version" to the base
             * Registry Subkey :
             * "SimpleSecUtlity"
             * 
             * After that was successful,
             * add a new SubKey called: 
             * "EnDecFileExtensions"
             * (This will be used to 
             * determine what the file
             * extension was of the og
             * unencrypted file) */

            using (RegistryKey setupKey = Registry.CurrentUser.CreateSubKey(Statics.RegPath))
            {
                if (setupKey != null)
                {
                    try
                    {
                        setupKey.SetValue("API Key", apiKey);
                        setupKey.SetValue("Master", masterPassword);
                        setupKey.SetValue("Version", Statics.AppVersion);
                        setupKey.SetValue("Setup Date", DateTime.Now.ToString("ddMMyyyy"));
                    }
                    catch (Exception ex) { ex.ToString(); }
                }
            }
        }
    }
}