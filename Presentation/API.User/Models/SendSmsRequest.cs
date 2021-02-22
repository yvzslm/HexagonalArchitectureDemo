using System.ComponentModel.DataAnnotations;

namespace API.User.Models
{
    public class SendSmsRequest
    {
        [Required]
        public string GsmNo { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
