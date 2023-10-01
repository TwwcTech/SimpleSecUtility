using System.Text.RegularExpressions;

namespace SimpleSecUtility.Backend
{
    internal class GuidGenerator
    {
        public static string GenerateNewGuid()
        {
            return Guid.NewGuid().ToString();
        }

        public static bool IsGuid(string guid)
        {
            Regex guidRegex = new Regex(@"^[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}$");
            return guidRegex.IsMatch(guid);
        }
    }
}
