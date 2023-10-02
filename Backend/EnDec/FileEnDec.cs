using System.Security.Cryptography;
using System.Text;

namespace SimpleSecUtility.Backend.EnDec
{
    internal class FileEnDec
    {
        private static readonly byte[] _IV = Encoding.UTF8.GetBytes("7418529630753951");

        public static void ProvisionAndEncryptFile(string password) // Explore the idea of passing through a Form object to open the password promtps, or not and continue with the script!
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file to ecnrypt";
            openFileDialog.Filter = "All files | *.*";
            openFileDialog.InitialDirectory = @"C:\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Check if file has a hash in the registry

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Select a Destination for Encrypted File";
                saveFileDialog.Filter = "Encrypted files |*.twwcts*";
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

                    // Add the file GUID and password to the Windows Credential Manager
                    File.Delete(openFileDialog.FileName);
                }
            }
        }

        public static void ScanMetaAndDecryptFile(string password) // Explore the idea of passing through a Form object to open the password promtps, or not and continue with the script!
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a File to Decrypt";
            openFileDialog.Filter = "Encrypted files |*.twwcts*";
            openFileDialog.InitialDirectory = @"C:\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the GUID from the file

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Select a Destination for Decrypted File";
                saveFileDialog.Filter = "All files | *.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream inputStream = new(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (FileStream outputStream = new(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                        {
                            using (System.Security.Cryptography.Aes aes = System.Security.Cryptography.Aes.Create())
                            {
                                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                                using (ICryptoTransform decryptor = aes.CreateDecryptor(passwordBytes, _IV))
                                {
                                    using (CryptoStream cryptoStream = new(outputStream, decryptor, CryptoStreamMode.Write))
                                    {
                                        byte[] buffer = new byte[1024];
                                        int byteRead;

                                        while ((byteRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                                        {
                                            cryptoStream.Write(buffer, 0, byteRead);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    // Add the GUID to the file
                    File.Delete(openFileDialog.FileName);
                }
            }
        }
    }
}