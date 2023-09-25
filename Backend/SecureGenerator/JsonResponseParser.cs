namespace SimpleSecUtility.Backend.SecureGenerator
{
    internal class JsonResponseParser
    {
        string? jsonrpc { get; set; }
        Result? result { get; set; }
        int id { get; set; }
    }

    public class Result
    {
        Random? random { get; set; }
        int bitsUsed { get; set; }
        long bitsLeft { get; set; }
        long requestsLeft { get; set; }
        int advisoryDelay { get; set; }

    }

    public class Random
    {
        string? data { get; set; }
        string? completionTime { get; set; }
    }
}
