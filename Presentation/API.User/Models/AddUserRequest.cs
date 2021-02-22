using System.ComponentModel.DataAnnotations;

namespace API.User.Models
{
    public class AddUserRequest
    {
        [Required]
        public string first_name { get; set; }
        [Required]
        public string last_name { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string gsm_no { get; set; }
    }
}
