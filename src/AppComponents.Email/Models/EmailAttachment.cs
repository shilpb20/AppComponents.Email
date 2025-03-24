namespace AppComponents.EmailService
{
    namespace YourNamespace.Email
    {
        public class EmailAttachment
        {
            public string FileName { get; set; }
            public string ContentType { get; set; }
            public byte[] Content { get; set; }
            public bool IsInline { get; set; } = false;
            public string? ContentId { get; set; }
        }
    }

}
