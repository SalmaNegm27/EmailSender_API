using EmailSender_API.Models;
using EmailSender_API.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
