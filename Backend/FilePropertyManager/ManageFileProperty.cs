using System.Text.RegularExpressions;

namespace SimpleSecUtility.Backend.FilePropertyManager
{
    internal class ManageFileProperty
    {
        public static void AddGuidToFileProperty(string filePath, string guid)
        {

        }

        public static bool IsGuid(string guid)
        {
            Regex guidRegex = new Regex(@"^[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}$");
            return guidRegex.IsMatch(guid);
        }

        public static string GetGuidFromFile(string filePath)
        {
            // Code goes here
        }
    }
}
