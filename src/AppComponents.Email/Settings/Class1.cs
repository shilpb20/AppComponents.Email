using System;

namespace YourNamespace.Email
{

    // SMTP Email Settings Class (For SMTP-based providers like Gmail, Outlook, etc.)
    public class SmtpEmailSettings : BaseEmailSettings
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
        public bool UseSsl { get; set; }
    }

    // API Email Settings Class (For API-based providers like SendinBlue, SendGrid, etc.)
    public class ApiEmailSettings : BaseEmailSettings
    {
        public string ApiKey { get; set; }
        public string BaseUrl { get; set; }
    }

    // Email Settings Configuration Holder
    public class EmailSettings
    {
        public SmtpEmailSettings SmtpSettings { get; set; }
        public ApiEmailSettings ApiEmailSettings { get; set; }
    }
}
