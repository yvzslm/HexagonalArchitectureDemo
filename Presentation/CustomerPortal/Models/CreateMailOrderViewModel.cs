using System.ComponentModel.DataAnnotations;

namespace CustomerPortal.Models
{
    public class CreateMailOrderViewModel
    {
        [Required]
        public string CompanyCode { get; set; }
        [Required]
        public string AgentId { get; set; }
        [Required]
        public string EndUserName { get; set; }
        [Required]
        public string EndUserSurname { get; set; }
        [Required]
        public string EndUserMail { get; set; }
        [Required]
        public string EndUserPhone { get; set; }
    }
}
