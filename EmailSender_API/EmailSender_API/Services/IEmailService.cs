namespace EmailSender_API.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(IEnumerable<string> emails, string subject, string body);
    }
}

