using System.Security.Cryptography;
using System.Text;

namespace SimpleSecUtility.Backend.EnDec
{
    internal class FileEnDec
    {
        private static readonly byte[] _IV = Encoding.UTF8.GetBytes("1234567890");

        public static void EncryptFile(OpenFileDialog openFileDialog, SaveFileDialog saveFileDialog, string password)
        {
            openFileDialog.Title = "Select a file to ecnrypt";
            openFileDialog.Filter = "All files | *.*";
            openFileDialog.InitialDirectory = @"C:\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog.Title = "Select a Destination for Encrypted File";
                saveFileDialog.Filter = "Encrypted files | (*.enc)|*.enc*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream inputSream = new(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (FileStream outputStream = new(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                        {
                            using (System.Security.Cryptography.Aes aes = System.Security.Cryptography.Aes.Create())
                            {
                                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                                using (ICryptoTransform encryptor = aes.CreateEncryptor(passwordBytes, _IV))
                                {
                                    using (CryptoStream cryptoStream = new CryptoStream(outputStream, encryptor, CryptoStreamMode.Write))
                                    {
                                        byte[] buffer = new byte[1024];
                                        int byteRead;

                                        while ((byteRead = inputSream.Read(buffer, 0, buffer.Length)) > 0)
                                        {
                                            cryptoStream.Write(buffer, 0, byteRead);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void DecryptFile(OpenFileDialog openFileDialog, SaveFileDialog saveFileDialog, string password)
        {
            openFileDialog.Title = "Select a File to Decrypt";
            openFileDialog.Filter = "Encrypted files | (*.enc)|*.enc*";
            openFileDialog.InitialDirectory = @"C:\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog.Title = "Select a Destination for Decrypted File";
                saveFileDialog.Filter = "All files | *.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Decrypt method goes here
                }
            }
        }
    }
}