using Domain.Shared.Models;

namespace Domain.User
{
    public class UserEntity : EntityBase
    {
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string GsmNo { get; private set; }

        protected UserEntity()
        {
        }

        public UserEntity(string firstname, string lastname, string email, string gsmNo)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            GsmNo = gsmNo;
        }

        public UserEntity(int id, string firstname, string lastname, string email, string gsmNo) : this(firstname, lastname, email, gsmNo)
        {
            ID = id;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName} LastName: {LastName} Email: {Email}";
        }
    }
}
