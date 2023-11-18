using Microsoft.Win32;
using SimpleSecUtility.AppResources;

namespace SimpleSecUtility.Backend.AppRegistry
{
    internal class RegistryWriter
    {
        public static void WriteFileNameHashAndGUID(string fileNameHash, string guid)
        {
            using RegistryKey writeFileNameHashKey = Registry.CurrentUser.OpenSubKey(Statics.RegPath + @"\EnDecFileExtensions")!;
            if (writeFileNameHashKey != null)
            {
                writeFileNameHashKey.SetValue(fileNameHash, guid);
            }
        }
    }
}
