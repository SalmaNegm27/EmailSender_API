using System.ComponentModel.DataAnnotations;

namespace EmailSender_API.ViewModel
{
    public class MessageViewModel
    {

        [Required(ErrorMessage = "Subject is required.")]
        [MaxLength(100, ErrorMessage = "Subject cannot exceed 100 characters.")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Content is required.")]

        public string Content { get; set; }
    }
}
