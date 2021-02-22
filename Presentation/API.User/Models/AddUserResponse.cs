namespace API.User.Models
{
    public class AddUserResponse
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string gsm_no { get; set; }
    }
}
