using Newtonsoft.Json;
using SimpleSecUtility.Backend.AppRegistry;
using System.CodeDom;
using System.Net.Http.Json;

namespace SimpleSecUtility.Backend.SecureGenerator
{
    internal class PassPin
    {
        private const int _defaultPINLength = 4;

        // Change Task<string> return type to Task<JsonResponseParser> 
        public static async Task<string> ReturnSecurePasswordOrPIN(string requestType, int requestLength)
        {
            using (HttpClient passwordClient = new HttpClient())
            {
                string apiUrl = string.Empty;
                //const string randomApiUrl = "https://api.random.org/json-rpc/2/invoke";
                string requestBody = string.Empty;

                switch (requestType.ToLower().Trim())
                {

                    /* Use the JSON-RPC method for retreiving the Password or PIN using RandomData.org
                     * - URL = "https://api.random.org/json-rpc/2/invoke"
                     * - Request Body = $"{{\"jsonrpc\": \"2.0\", \"method\": \"generateIntegers\", \"params\": {{ \"apiKey\": \"{apiKey}\", \"n\": 5, \"min\": 1, \"max\": 10, \"replacement\": true, \"base\": 10 }}, \"id\": 1 }}"
                     * - Type = "application/json"
                     * - Create a class to inherit the json response for deserialization */

                    case "password":
                        //string apiKey = RegistryReader.ReadApiKey("apikey");
                        //string requestPasswordBody = $"{{\"jsonrpc\": \"2.0\", \"method\": \"generateStrings\", \"params\": {{ \"apiKey\": \"{}\", \"n\": 1, \"length\": {requestLength}, \"characters\": \"abcdefghijklmnopqrstuvwxyz1234567890!@#$%&\", \"replacement\": true}}, \"id\": 20251}}";

                        apiUrl = $"https://www.random.org/strings/?num=1&len={requestLength}&digits=on&upperalpha=on&loweralpha=on&unique=on&format=plain&rnd=new";
                        break;
                    case "pin":
                        //string apiKey = RegistryReader.ReadApiKey("apikey");
                        // add the if branch for pin length: if (pinLength == 4) else if (pinLength > 4)
                        //string requestPinBody = $"{{\"jsonrpc\": \"2.0\", \"method\": \"generateStrings\", \"params\": {{ \"apiKey\": \"{}\", \"n\": 1, \"length\": {requestLength}, \"characters\": \"1234567890\", \"replacement\": true}}, \"id\": 20251}}";
                        //string requestPinBody = $"{{\"jsonrpc\": \"2.0\", \"method\": \"generateStrings\", \"params\": {{ \"apiKey\": \"{}\", \"n\": 1, \"length\": {requestLength}, \"characters\": \"1234567890!@#$%&+-()_=\", \"replacement\": true}}, \"id\": 20251}}";

                        apiUrl = $"https://www.random.org/strings/?num=1&len={requestLength}&digits=on&unique=on&format=plain&rnd=new";
                        break;
                    default:
                        throw new ArgumentException("Not an option, please select from: [password, pin]");
                }

                string apiKey = RegistryReader.ReadApiKey("apikey"); // Remove when ready
                string requestResult = string.Empty; // Remove when ready

                if (!string.IsNullOrEmpty(apiKey))
                {
                    try
                    {
                        //HttpRequestMessage requestResponse = new HttpRequestMessage(HttpMethod.Post, apiUrl);
                        //requestResponse.Content = new StringContent(requestBody, System.Text.Encoding.UTF8, "application/json");
                        //HttpResponseMessage responseMessage = await passwordClient.SendAsync(requestResponse);
                        //if (responseMessage.IsSuccessStatusCode)
                        //{
                        //    string content = await responseMessage.Content.ReadAsStringAsync();
                        //    JsonResponseParser jsonResponseParser = JsonConvert.DeserializeObject<JsonResponseParser>(content)!;
                        //    return jsonResponseParser;
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Unable to parse JSON file, please ensure your file is correct", "JSON Parser Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        //}

                        passwordClient.DefaultRequestHeaders.Add("X-RandomOrg-ApiKey", apiKey);
                        HttpResponseMessage response = await passwordClient.GetAsync(apiUrl);

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