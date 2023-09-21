
namespace EmailSender_API.Repositories.EmailRepository
{
    public class EmailRepository : IEmailRepository
    {
        protected readonly AppDbContext _context;
        public EmailRepository(AppDbContext context)
        {
            _context = context;
        }
        public virtual async Task Add(EmailViewModel emailViewModel)
        {
            foreach (var emailAddress in emailViewModel.EmailAdresses)
            {
                var email = new Email()
                {
                    Id = emailViewModel.Id,
                    EmailAddress = emailAddress,
                    MessageId = emailViewModel.MessageId,
                };
                _context.Add(email);
              await  _context.SaveChangesAsync();

            }

        }
    }
}
