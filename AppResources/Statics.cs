namespace SimpleSecUtility.AppResources
{
    internal class Statics
    {        
        public const string AppVersion = "1.0";
        public const string RegPath = @"Software\SimpleSecUtility";

        public static string SetupInfo = "Welcome to the Simple Sec Utility Setup.\n" +
            "The application is setup per user account, each new user\n" +
            "or an existing user, using the app for the first time,\n" +
            " will be asked to begin setup.\n\n" +
            "To continue with the app, a 'Master Password' must be created\n" +
            "to ensure only the active user account\n" +
            $"({Environment.UserName}) has access to the 'File Encryption' tool.";
    }
}
