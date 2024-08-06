namespace AuthenticationService
{
    public class CustomException : Exception
    {
        public CustomException(string message)
        {
            throw new Exception(message);
        }
    }
}
