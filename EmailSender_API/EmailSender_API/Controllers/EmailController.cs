namespace EmailSender_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailRepository _emailRepository;
        private readonly IEmailService _emailService;
        private readonly IMessageRepository _messageRepository;

        public EmailController(IEmailRepository emailRepository, IEmailService emailService, IMessageRepository messageRepository)
        {
            _emailRepository = emailRepository;
            _emailService = emailService;
            _messageRepository = messageRepository;
        }

        [HttpPost]
        public async Task<ActionResult> SendEmails(EmailViewModel model)
        {
            //check the form validate
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //get message by id to get subject and contect of this message
            var message = await _messageRepository.GetById(model.MessageId);
            await _emailService.SendEmailAsync(model.EmailAdresses, message.Subject, message.Content);

            var emails = model.EmailAdresses.Select(e => new Email
            {
                EmailAddress = e,
                MessageId = model.MessageId,
            });

            // add emails to dataBase
            await _emailRepository.AddRange(emails);

            var response = new
            {
                Message = "Emails Send Successfully"
            };
            return Ok(response);

        }
    }
}
