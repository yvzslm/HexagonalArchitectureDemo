using Domain.Shared.Models;

namespace Domain.MailOrder.ValueObjects
{
    public class EndUser : ValueObjectBase
    {
        public string EndUserName { get; private set; }
        public string EndUserSurName { get; private set; }
        public string EndUserMail { get; private set; }
        public string EndUserPhone { get; private set; }

        public EndUser(string name, string surname, string mail, string phone)
        {
            EndUserName = name;
            EndUserSurName = surname;
            EndUserMail = mail;
            EndUserPhone = phone;
        }
    }
}
