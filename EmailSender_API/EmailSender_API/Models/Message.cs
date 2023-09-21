namespace EmailSender_API.Models
{
    public class Message
    {
        [Key]
        public Guid Id { get; set; }
        public string Subject { get; set; }

        public string Content { get; set; }

        public ICollection<Email> Emails { get; } = new List<Email>();
    }
}
