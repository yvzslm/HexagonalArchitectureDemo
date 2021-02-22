namespace Domain.User.Models
{
    public class AddUser
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string GsmNo { get; private set; }

        public AddUser(string firstname, string lastname, string email, string gsmno)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            GsmNo = gsmno;
        }
    }
}
