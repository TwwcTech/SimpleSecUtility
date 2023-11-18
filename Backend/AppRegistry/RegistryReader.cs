using Microsoft.Win32;
using SimpleSecUtility.AppResources;

namespace SimpleSecUtility.Backend.AppRegistry
{
    internal class RegistryReader
    {
        public static bool DoesHashedPathExist(string keyName)
        {
            using RegistryKey hashedPathKey = Registry.CurrentUser.OpenSubKey(Statics.RegPath + @"\EnDecFileExtensions")!;
            if (hashedPathKey != null && hashedPathKey.GetValue(keyName) != null)
            {
                return true;
            }
            return false;
        }

        public static string ReturnGuid(string keyName)
        {
            using RegistryKey guidKey = Registry.CurrentUser.OpenSubKey(Statics.RegPath + @"\EnDecFileExtensions")!;
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