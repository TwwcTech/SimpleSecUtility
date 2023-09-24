namespace SimpleSecUtility.Backend.SecureGenerator
{
    internal class PassPin
    {
        private const int _defaultPasswordLength = 8;
        private const int _defaultPINLength = 4;

        public static async Task<string> ReturnSecurePassword(int passwordLength = _defaultPasswordLength)
        {
            using (HttpClient passwordClient = new HttpClient())
            {
                string passwordResult = string.Empty;

                if (passwordLength >= _defaultPasswordLength)
                {
                    string passwordApiUrl = $"https://www.random.org/strings/?num=1&len={passwordLength}&digits=on&upperalpha=on&loweralpha=on&unique=on&format=plain&rnd=new";
                    try
                    {
                        passwordClient.DefaultRequestHeaders.Add("X-RandomOrg-ApiKey", ""); // Complete the API Key
                        HttpResponseMessage response = await passwordClient.GetAsync(passwordApiUrl);
                        if (response.IsSuccessStatusCode)
                        {
                            passwordResult = await response.Content.ReadAsStringAsync();
                        }
                        else
                        {
                            MessageBox.Show($"Unable to connect. Status Code: {response.StatusCode}");
                        }
                    }
                    catch (Exception ex) { ex.ToString(); }
                }
                return passwordResult.Trim();
            }
        }

        public static async Task<string> ReturnSecurePIN(int pinLength = _defaultPINLength)
        {
            using (HttpClient pinClient = new HttpClient())
            {
                string pinResult = string.Empty;

                if (pinLength >= _defaultPINLength)
                {
                    string pinApiUrl = $"https://www.random.org/strings/?num=1&len={pinLength}&digits=on&format=plain&rnd=new";
                    try
                    {
                        pinClient.DefaultRequestHeaders.Add("X-RandomOrg-ApiKey", ""); // Complete the API Key string
                        HttpResponseMessage pinResponse = await pinClient.GetAsync(pinApiUrl);
                        if (pinResponse.IsSuccessStatusCode)
                        {
                            pinResult = await pinResponse.Content.ReadAsStringAsync();
                        }
                        else
                        {
                            MessageBox.Show($"Unable to connect. Status Code: {pinResponse.StatusCode}");
                        }
                    }
                    catch (Exception ex) { ex.ToString(); }
                }
                return pinResult.Trim();
            }
        }
    }
}
