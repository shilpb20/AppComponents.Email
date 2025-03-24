namespace AppComponents.EmailService
{
    namespace YourNamespace.Email
    {
        public interface IEmailService
        {
            Task SendEmailAsync(EmailRequest emailRequest);
            bool ValidateEmailRequest(EmailRequest emailRequest);
        }
    }
}
