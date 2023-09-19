using EmailSender_API.Contexts;
using EmailSender_API.Models;
using EmailSender_API.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmailSender_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MessageController(AppDbContext context)
        {
              _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessages()
        {
            var message= await _context.Messages.ToListAsync();
            return Ok(message);
        }
        [HttpPost]
        public async Task<IActionResult> AddMessage(MessageViewModel messageViewModel)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var message = new Message()
            {
                Subject = messageViewModel.Subject,
                Content = messageViewModel.Content
            };

            _context.Add(message);
           await _context.SaveChangesAsync();
            return Ok("Message Addes Successfully");

        }
    }
}

