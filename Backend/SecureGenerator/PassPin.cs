﻿using SimpleSecUtility.Backend.WinCredsManager;

namespace SimpleSecUtility.Backend.SecureGenerator
{
    internal class PassPin
    {
        public static async Task<string> ReturnSecurePasswordOrPIN(string requestType, int requestLength)
        {
            using (HttpClient requestClient = new HttpClient())
            {
                string apiUrl = string.Empty;

                switch (requestType.ToLower().Trim())
                {
                    case "password":
                        apiUrl = $"https://www.random.org/strings/?num=1&len={requestLength}&digits=on&upperalpha=on&loweralpha=on&unique=on&format=plain&rnd=new";
                        break;
                    case "pin":
                        apiUrl = $"https://www.random.org/strings/?num=1&len={requestLength}&digits=on&unique=on&format=plain&rnd=new";
                        break;
                    default:
                        throw new ArgumentException("Not an option, please select from: [password, pin]");
                }

                string requestResult = string.Empty;
                if (ManageWinCreds.DoesCredentialExist("SSU_api"))
                {
                    try
                    {
                        requestClient.DefaultRequestHeaders.Add("X-RandomOrg-ApiKey", ManageWinCreds.GetSecret("SSU_api"));
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
                }
                else
                {
                    MessageBox.Show("API Key was not found", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return requestResult.Trim();
            }
        }
    }
}