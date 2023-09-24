namespace SimpleSecUtility.Backend.SecureGenerator
{
    internal class PassPin
    {
        private const int _defaultPasswordLength = 8;
        private const int _defaultPINLength = 4;

        public static async Task<string> ReturnSecurePasswordOrPIN(string requestType, int requestLength)
        {
            using (HttpClient passwordClient = new HttpClient())
            {
                string requestResult = string.Empty;
                string apiUrl = string.Empty;

                switch (requestType.ToLower().Trim())
                {
                    case "password":
                        if (requestLength >= _defaultPasswordLength)
                        {
                            apiUrl = $"https://www.random.org/strings/?num=1&len={requestLength}&digits=on&upperalpha=on&loweralpha=on&unique=on&format=plain&rnd=new";
                        }
                        break;
                    case "pin":
                        if (requestLength >= _defaultPINLength)
                        {
                            apiUrl = $"https://www.random.org/strings/?num=1&len={requestLength}&digits=on&format=plain&rnd=new";
                        }
                        break;
                }
                try
                {
                    passwordClient.DefaultRequestHeaders.Add("X-RandomOrg-ApiKey", ""); // Complete the API Key
                    HttpResponseMessage response = await passwordClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        requestResult = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        MessageBox.Show($"Unable to connect. Status Code: {response.StatusCode}");
                    }
                }
                catch (Exception ex) { ex.ToString(); }
                return requestResult.Trim();
            }
        }
    }
}