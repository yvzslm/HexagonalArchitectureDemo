using Domain.Shared;

namespace API.User.Models
{
    public class Response
    {
        public ResultCode status_code { get; set; }
        public string message { get; set; }
    }
}
