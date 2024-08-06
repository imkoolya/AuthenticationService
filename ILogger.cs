namespace AuthenticationService
{
    public interface ILogger
    {
        void WriteEvent(string EventMessage);
        void WriteError(string EventMessage);
    }
}
