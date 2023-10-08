namespace SimpleSecUtility.Backend.EnDec.FileExtensions
{
    internal class FileNameIsolator
    {
        public static string IsolateFileName(string filePath)
        {
            return Path.GetFileName(filePath);
        }
    }
}
