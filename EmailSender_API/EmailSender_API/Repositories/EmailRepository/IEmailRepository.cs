namespace EmailSender_API.Repositories.EmailRepository
{
    public interface IEmailRepository
    {
        Task Add(Email email);
        Task AddRange(IEnumerable<Email> emails);
    }
}
