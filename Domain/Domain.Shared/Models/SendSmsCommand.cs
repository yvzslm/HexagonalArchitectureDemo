namespace Domain.Shared.Models
{
    public class SendSmsCommand
    {
        public string GsmNo { get; private set; }
        public string Message { get; private set; }

        public SendSmsCommand(string gsmNo, string message)
        {
            GsmNo = gsmNo;
            Message = message;
        }
    }
}
