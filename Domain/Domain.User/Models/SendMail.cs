namespace Domain.User.Models
{
    public class SendMail
    {
        public string EmailTo { get; private set; }
        public string Subject { get; private set; }
        public string Body { get; private set; }

        public SendMail(string emailTo, string subject, string body)
        {
            EmailTo = emailTo;
            Subject = subject;
            Body = body;
        }
    }
}
