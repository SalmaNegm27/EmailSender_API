using EmailSender_API.Contexts;
using EmailSender_API.Models;
using EmailSender_API.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmailSender_API.Repositories.MessageRepository
{
    public class MessageRepository : IMessageRepository
    {
        protected readonly AppDbContext _context;

        public MessageRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Add(MessageViewModel messageViewModel)
        {
            var message = new Message()
            {
                Subject = messageViewModel.Subject,
                Content = messageViewModel.Content
            };

            _context.Add(message);
            await _context.SaveChangesAsync();
                
        }

        public  async Task Delete(Guid id)
        {
            var message = await _context.Messages.FirstOrDefaultAsync(m => m.Id == id);
            if (message != null)
            {
            _context.Messages.Remove(message);
            await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Message>> GetAllAsync()
        {
            return await _context.Messages.ToListAsync();
           
        }

        public async Task<Message> GetById(Guid id)
        {
            var message=await _context.Messages.FirstOrDefaultAsync(m => m.Id == id);
            return message;
           
           
        }
    }
}
