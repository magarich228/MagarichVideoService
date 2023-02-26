namespace MagarichVideoService.Infrastructure.Core
{
    public class MagarichVideoServiceException : Exception
    {
        public MagarichVideoServiceException() { }

        public MagarichVideoServiceException(string message)
            : base(message) { }

        public MagarichVideoServiceException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}