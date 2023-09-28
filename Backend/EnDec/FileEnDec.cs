using System.Security.Cryptography;
using System.Text;

namespace SimpleSecUtility.Backend.EnDec
{
    internal class FileEnDec
    {
        private static readonly byte[] _IV = Encoding.UTF8.GetBytes("1234567890");

        public static void EncryptFile(OpenFileDialog openFileDialog, SaveFileDialog saveFileDialog, string fileToEncrypt, string password)
        {
            //using (System.Security.Cryptography.Aes aes = System.Security.Cryptography.Aes.Create())
            //{
            //    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            //    using (ICryptoTransform encryptor = aes.CreateEncryptor(passwordBytes, _IV))
            //    {
            //        // Code to save file may possibly go here

            //        // else, "using (FileStream outputStream) { }"
            //        using (CryptoStream cryptoStream = new CryptoStream())
            //        {

            //        }
            //    }
            //}
        }

        public static void DecryptFile(OpenFileDialog openFileDialog, SaveFileDialog saveFileDialog, string fileToDecrypt)
        {
            // Code goes here
        }
    }
}