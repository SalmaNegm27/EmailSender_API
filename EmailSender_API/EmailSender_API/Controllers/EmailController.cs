
using EmailSender_API.ViewModel;

namespace EmailSender_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailRepository _emailRepository;
        public EmailController(IEmailRepository emailRepository)
        {
            _emailRepository = emailRepository;
        }

        [HttpPost]
        public async Task<ActionResult> SaveEmails(EmailViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _emailRepository.Add(model);
            var response = new
            {
                Message = "Emails Send Successfully"
            };
            return Ok(response);

        }
    }
}
