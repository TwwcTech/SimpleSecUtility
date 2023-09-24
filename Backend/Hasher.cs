using System.Security.Cryptography;
using System.Text;

namespace SimpleSecUtility.Backend
{
    internal class Hasher
    {
        public static string Hash(string stringToHash)
        {
            return Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(stringToHash)));
        }
    }
}