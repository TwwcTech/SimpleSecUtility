using SimpleSecUtility.Backend.EnDec.FileExtensions;
using System.Security.Cryptography;
using System.Text;

namespace SimpleSecUtility.Backend.EnDec
{
    // STEP 5

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
                // Isolate the filename from the filepath
                string openFileName = FileNameIsolator.IsolateFileName(openFileDialog.FileName);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Select a Destination for Encrypted File";
                saveFileDialog.Filter = "Encrypted files |*.twwcts*";
                // If filename hash exists, use the associated GUID, else, create a new GUID (like below)
                //saveFileDialog.FileName = GuidGenerator.GenerateNewGuid();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // If filename hash exists, grab the GUID
                    // Refer the GUID to the Windows Credential Manager and get the password associated with the credential
                    // Encrypt the file with that password
                    // Else, display the password prompt window and enter a new password
                    // Possibly, save the password as a varaible
                    // Create a new Credential in the Credential Manager using that new password variable
                    // Add the Guid and OG filename and file extention to the Credential Manager
                    // Add the hashed filename and the GUID to the registry
                    // Encrypt the file

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
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Select a Destination for Decrypted File";
                saveFileDialog.Filter = "All files | *.*"; // Extension of og file path
                //saveFileDialog.FileName = ""; // og file path name
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the GUID from the file
                    // Run it by the Windows Credential Manager
                    // Grab the og file name from the Credential (Credential.UserName)
                    // Determine the ext of the file name and set it as the filter
                    // Determine the file name of the file and set it to the saveFileDialog.FileName
                    // Grab the password from the Credential (Credential.Password)
                    // Use this password to decrypt the file

                    using (FileStream inputStream = new(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (FileStream outputStream = new(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                        {
                            using (System.Security.Cryptography.Aes aes = System.Security.Cryptography.Aes.Create())
                            {
                                byte[] passwordBytes = Encoding.UTF8.GetBytes(password); // Credential.Password
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
                    File.Delete(openFileDialog.FileName);
                }
            }
        }
    }
}