namespace EmailSender_API.ViewModel
{
    public class EmailViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public List<string> EmailAdresses { get; set; }

        public Guid MessageId { get; set; }
    }
}
