using Solid.Classes;
using Solid.Helpers.Notification;

namespace Solid.Helpers.Loggers
{
    public class CriticalErrorLogger : Logger
    {
        public CriticalErrorLogger() { }

        public override void LogError(Error error)
        {
            DisplayError(error);
            SendEmail("Critical Error", new User("Gabriel Cordeiro", "gabriel.cordeiro@dextra-sw.com"));
        }

        private void SendEmail(string subject, User recipient)
        {
            // Send e-mail
            System.Console.WriteLine($"An e-mail has been sent to {recipient.Name}.");
        }
    }
}