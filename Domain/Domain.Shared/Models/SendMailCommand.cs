namespace Domain.Shared.Models
{
    public class SendMailCommand
    {
        public string EmailTo { get; private set; }
        public string Subject { get; private set; }
        public string Body { get; private set; }

        public SendMailCommand(string emailTo, string subject, string body)
        {
            EmailTo = emailTo;
            Subject = subject;
            Body = body;
        }
    }
}
