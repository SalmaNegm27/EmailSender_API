namespace EmailSender_API.Models
{
    public class Message
    {
        public Guid Id { get; set; }

       
        public string Subject { get; set; }

        public string Content { get; set; }
    }
}
