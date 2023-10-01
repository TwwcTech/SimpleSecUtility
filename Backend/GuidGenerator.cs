namespace SimpleSecUtility.Backend
{
    internal class GuidGenerator
    {
        public static string GenerateNewGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
