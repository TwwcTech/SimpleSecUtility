using System.Security.Cryptography;
using System.Text;

namespace SimpleSecUtility.Backend
{
    internal class Hasher
    {
        public static string Hash(string stringToHash)
        {
            byte[] stringToHashBytes = Encoding.UTF8.GetBytes(stringToHash);
            byte[] hashedString = HashAlgorithm.Create("SHA256").ComputeHash(stringToHashBytes);

            return Convert.ToBase64String(hashedString);
        }
    }
}
