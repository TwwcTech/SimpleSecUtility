namespace SimpleSecUtility.Backend.SecureGenerator
{
    internal class PassPin
    {
        public static async Task<string> ReturnSecurePasswordOrPIN(string requestType, int requestLength)
        {
            using HttpClient requestClient = new();
            string apiUrl = string.Empty;

            apiUrl = requestType.ToLower().Trim() switch
            {
                "password" => $"https://www.random.org/strings/?num=1&len={requestLength}&digits=on&upperalpha=on&loweralpha=on&unique=on&format=plain&rnd=new",
                "pin" => $"https://www.random.org/strings/?num=1&len={requestLength}&digits=on&unique=on&format=plain&rnd=new",
                _ => throw new ArgumentException("Not an option, please select from: [password, pin]"),
            };

            string requestResult = string.Empty;
            try
            {
                HttpResponseMessage response = await requestClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    requestResult = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    MessageBox.Show($"Unable to connect to RandomData.Org, Status Code: {response.StatusCode}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { ex.ToString(); }
            return requestResult.Trim();
        }
    }
}