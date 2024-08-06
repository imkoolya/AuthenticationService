namespace AuthenticationService
{
    public class LogMiddleware
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;

        public LogMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var ip = httpContext.Connection.RemoteIpAddress?.ToString();

            _logger.WriteEvent($"IP адрес: {ip}");

            await _next(httpContext);
        }
    }
}
