namespace Domain.User.Models
{
    public class SendSms
    {
        public string GsmNo { get; private set; }
        public string Message { get; private set; }

        public SendSms(string gsmNo, string message)
        {
            GsmNo = gsmNo;
            Message = message;
        }
    }
}
