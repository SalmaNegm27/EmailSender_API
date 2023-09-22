
namespace EmailSender_API.Repositories.EmailRepository
{
    public class EmailRepository : IEmailRepository
    {
        protected readonly AppDbContext _context;
        public EmailRepository(AppDbContext context)
        {
            _context = context;
        }
        public virtual async Task Add(Email email)
        {
            _context.Add(email);
            await _context.SaveChangesAsync();

        }
        public virtual async Task AddRange(IEnumerable<Email> emails)
        {
            _context.AddRange(emails);
            await _context.SaveChangesAsync();

        }
    }
}
