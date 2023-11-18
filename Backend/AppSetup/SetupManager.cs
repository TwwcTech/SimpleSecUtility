using Microsoft.Win32;
using SimpleSecUtility.AppResources;

namespace SimpleSecUtility.Backend.AppSetup
{
    internal class SetupManager
    {
        public static bool HasAppBeenSetup()
        {
            using RegistryKey setupStatusKey = Registry.CurrentUser.OpenSubKey(Statics.RegPath)!;
            if (setupStatusKey != null)
            {
                return true;
            }
            return false;
        }

        public static void RunSetup()
        {
            using RegistryKey setupKey = Registry.CurrentUser.CreateSubKey(Statics.RegPath);
            if (setupKey != null)
            {
                try
                {
                    setupKey.SetValue("Version", Statics.AppVersion);
                    setupKey.SetValue("Setup Date", DateTime.Now.ToString("ddMMyyyy"));
                }
                catch (Exception ex) { ex.ToString(); }
            }
            else
            {
                MessageBox.Show($"Unable to create the \"{Statics.RegPath}\" App Folder", "App Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using RegistryKey enDecFileKey = Registry.CurrentUser.CreateSubKey(Statics.RegPath + @"\EnDecFileExtensions");
            if (enDecFileKey != null)
            {
                return;
            }
            else
            {
                MessageBox.Show("Unable to create the \"EnDecFileExtensions\" Folder", "EnDecFileExtensions Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}