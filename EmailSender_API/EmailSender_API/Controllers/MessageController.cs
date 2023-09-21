using EmailSender_API.Contexts;
using EmailSender_API.Models;
using EmailSender_API.Repositories.MessageRepository;
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
        private readonly IMessageRepository _messageRepository;

        public MessageController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessages()
        {
            var message = await _messageRepository.GetAllAsync();
            return Ok(message);
        }
        [HttpGet("id")]
        public async Task<ActionResult> GetMessageById(Guid id)
        {
            var message = await _messageRepository.GetById(id);
            if (message == null) return NotFound();
            return Ok(message);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
          
           await _messageRepository.Delete(id);
            return Ok();
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

            await _messageRepository.Add(messageViewModel);
            var response = new
            {
                Message = "Message Added Successfully"
            };
            return Ok(response);

        }
    }
}

