namespace EmailSender_API.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(IEnumerable<string> emails, string subject, string body)
        {
            string serverEmail = "universityhostel@hotmail.com";

            var client = new SmtpClient("smtp.office365.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(serverEmail, Encoding.UTF8.GetString(Convert.FromBase64String("X1RrbzZYUSpLLkwmfSh8Rw=="))),
                EnableSsl = true
            };

            var mail = new MailMessage();
            mail.From = new MailAddress(serverEmail);

            foreach (var email in emails)
            {
                mail.To.Add(email);
            }
            mail.Subject = subject;
            mail.Body = body;

            await client.SendMailAsync(mail);
        }
    }
}
