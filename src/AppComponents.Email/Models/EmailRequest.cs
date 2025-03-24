
namespace AppComponents.EmailService.Models
{
    public class EmailRequest
    {
        public string From { get; set; }
        public List<string> To { get; set; } = new();
        public List<string>? Cc { get; set; }
        public List<string>? Bcc { get; set; }
        public string Subject { get; set; }
        public string? PlainTextContent { get; set; }
        public string? HtmlContent { get; set; }
        public List<EmailAttachment>? Attachments { get; set; }
        public Dictionary<string, string>? CustomHeaders { get; set; }
    }
}
