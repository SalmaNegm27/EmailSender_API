
namespace EmailSender_API.Models
{
    public class Email
    {
        [Key]
        public Guid Id { get; set; }
        public string EmailAddress { get; set; }
        [ForeignKey("Message")]
        public Guid MessageId { get; set; }
        public Message Message { get; set; }
    }
}
