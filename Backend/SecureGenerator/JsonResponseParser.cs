namespace SimpleSecUtility.Backend.SecureGenerator
{
    internal class JsonResponseParser
    {
        public string? jsonrpc { get; set; }
        public Result? result { get; set; }
        public int id { get; set; }
    }

    public class Result
    {
        public RandomData? random { get; set; }
        public int bitsUsed { get; set; }
        public long bitsLeft { get; set; }
        public long requestsLeft { get; set; }
        public int advisoryDelay { get; set; }

    }

    public class RandomData
    {
        public string? data { get; set; }
        public string? completionTime { get; set; }
    }
}
