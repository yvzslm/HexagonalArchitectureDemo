namespace Domain.Shared
{
    public class Result
    {
        public ResultCode ResultCode { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return $"ResultCode: {ResultCode.GetHashCode()} Message: {Message}";
        }
    }

    public enum ResultCode
    {
        Successful = 1,
        UnSuccessful
    }
}
