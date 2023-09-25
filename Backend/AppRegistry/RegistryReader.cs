using Microsoft.Win32;
using SimpleSecUtility.AppResources;

namespace SimpleSecUtility.Backend.AppRegistry
{
    internal class RegistryReader
    {
        public static string ReadApiKey(string keyName)
        {
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
                        default:
                            throw new ArgumentException("Not an option. Please choose from: [setupdate, version, apikey]");
                    }
                }
                return null!;
            }
        }
    }
}