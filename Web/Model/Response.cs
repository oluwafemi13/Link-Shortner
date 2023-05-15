namespace Web.Model
{
    public class Response
    {
        public string? DisplayMessage { get; set; }
        public string? ErrorMessage { get; set; }
        public bool IsSuccess { get; set; } = true;
    }
}
