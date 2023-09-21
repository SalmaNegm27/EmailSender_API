
namespace EmailSender_API.Repositories.EmailRepository
{
    public interface IEmailRepository
    {
        Task Add(EmailViewModel email);
    }
}
