using Solid.Helpers.Notification;
using Solid.Interface;

namespace Solid.Helpers.Loggers
{
    public abstract class ErrorLogger : ILogger
    {
        public ErrorLogger() { }

        public void DisplayError(Error error)
        {
            System.Console.WriteLine("An error has occurred.");
            System.Console.WriteLine($"Error message: {error.Message}");
        }

        public abstract void LogError(Error error);
    }
}
