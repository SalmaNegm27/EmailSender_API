

namespace EmailSender_API.Repositories.MessageRepository
{
    public class MessageRepository : IMessageRepository
    {
        protected readonly AppDbContext _context;

        public MessageRepository(AppDbContext context)
        {
            _context = context;
        }

        //add new message to databas
        public virtual async Task Add(MessageViewModel messageViewModel)
        {
            var message = new Message()
            {
                Subject = messageViewModel.Subject,
                Content = messageViewModel.Content
            };

            _context.Add(message);
            await _context.SaveChangesAsync();
                
        }

        //delete message from database
        public virtual async Task Delete(Guid id)
        {
            var message = await _context.Messages.FirstOrDefaultAsync(m => m.Id == id);
            if (message != null)
            {
            _context.Messages.Remove(message);
            await _context.SaveChangesAsync();
            }
        }

        // get all messages from database
        public virtual async Task<IEnumerable<Message>> GetAllAsync()
        {
            return await _context.Messages.ToListAsync();
           
        }

        //get Message By Id of Message
        public virtual async Task<Message> GetById(Guid id)
        {
            var message=await _context.Messages.FirstOrDefaultAsync(m => m.Id == id);

            return message;
           
           
        }
    }
}
