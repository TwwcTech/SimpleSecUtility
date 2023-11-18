using System.Text.RegularExpressions;

namespace SimpleSecUtility.Backend
{
    internal partial class GuidGenerator
    {
        public static string GenerateNewGuid()
        {
            return Guid.NewGuid().ToString();
        }

        public static bool IsGuid(string guid)
        {
            Regex guidRegex = MyRegex();
            return guidRegex.IsMatch(guid);
        }

        [GeneratedRegex("^[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}$")]
        private static partial Regex MyRegex();
    }
}
