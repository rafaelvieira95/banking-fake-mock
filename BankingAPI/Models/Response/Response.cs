namespace BankingAPI.Models.Response
{
    public class Response
    {
        public bool Success { get; set; }
        public dynamic Data { get; set; }
        public string Message { get; set; }
    }
}