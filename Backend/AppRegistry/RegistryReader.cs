using Microsoft.Win32;
using SimpleSecUtility.AppResources;

namespace SimpleSecUtility.Backend.AppRegistry
{
    internal class RegistryReader
    {
        // Create method to call API Key from the Windows Credential Manager before removing method
        public static string ReadApiKey(string keyName)
        {
            /* Remove this method or update the method name
             * because all API calls will be from the 
             * Windows Credential Manager. The method here
             * should be able to call or Read the file extension
             * thats in the EnDecFileExtensions Registry SubKey */

            using (RegistryKey readKey = Registry.CurrentUser.OpenSubKey(Statics.RegPath)!)
            {
                if (readKey != null)
                {
                    switch (keyName.ToLower())
                    {
                        case "setupdate":
                            return readKey.GetValue("Setup Date")!.ToString()!;
                        case "version":
                            return readKey.GetValue("Version")!.ToString()!;
                        case "apikey": 
                            return readKey.GetValue("API Key")!.ToString()!;
                        case "master": 
                            return readKey.GetValue("Master")!.ToString()!;
                        default:
                            throw new ArgumentException("Not an option. Please choose from: [setupdate, version, apikey]");
                    }
                }
                return null!;
            }
        }

        public static bool DoesHashedPathExist(string keyName)
        {
            using (RegistryKey hashedPathKey = Registry.CurrentUser.OpenSubKey(Statics.RegPath + @"\EnDecFileExtensions")!)
            {
                if (hashedPathKey != null && hashedPathKey.GetValue(keyName) != null)
                {
                    return true;
                }
                return false;
            }
        }

        public static string ReturnGuid(string keyName)
        {
            using (RegistryKey guidKey = Registry.CurrentUser.OpenSubKey(Statics.RegPath + @"\EnDecFileExtensions")!)
            {
                string guidKeyValue = string.Empty;

                if (guidKey != null)
                {
                    if (guidKey.GetValue(keyName) != null)
                    {
                        guidKeyValue = guidKey.GetValue(keyName)!.ToString()!;
                    }
                }
                return guidKeyValue;
            }
        }
    }
}