namespace EmailSender_API.Repositories.MessageRepository
{
    public interface IMessageRepository
    {
        Task<IEnumerable<Message>> GetAllAsync();
        Task<Message> GetById(Guid id);
        Task Delete(Guid id);
        Task Add(MessageViewModel messageViewModel);
    }
}
