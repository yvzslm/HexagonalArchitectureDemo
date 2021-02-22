using System.ComponentModel.DataAnnotations;

namespace API.User.Models
{
    public class SendMailRequest
    {
        [Required]
        public string email_to { get; set; }
        [Required]
        public string subject { get; set; }
        [Required]
        public string body { get; set; }
    }
}
