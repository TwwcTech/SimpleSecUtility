namespace SimpleSecUtility.Backend.EnDec.FileExtensions
{
    internal class FileExtIdentifier
    {
        private static string[] _fileExtensions =
            {
                ".txt",
                ".docx",
                ".xlsx",
                ".csv",
                ".pdf",
                ".json"
            };

        public static bool IsFileExtTypeCorrect(string filePath)
        {
            int extensionTypes = _fileExtensions.Length;
            for (int i = 0; i < extensionTypes; i++)
            {
                if (!filePath.EndsWith(_fileExtensions[i]))
                {
                    extensionTypes--;
                }
            }
            if (extensionTypes == 0)
            {
                return false;
            }
            return true;
        }

        public static string IdentifyFileExtension(string filePath)
        {
            string originalExt = string.Empty;

            foreach (string extension in _fileExtensions)
            {
                if (filePath.EndsWith(extension))
                {
                    originalExt = extension;
                }
            }
            return originalExt;
        }
    }
}
