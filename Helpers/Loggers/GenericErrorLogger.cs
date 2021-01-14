using Solid.Helpers.Notification;

namespace Solid.Helpers.Loggers
{
    public class GenericErrorLogger : Logger
    {
        public GenericErrorLogger() { }


        public override void LogError(Error error)
        {
            DisplayError(error);
        }
    }
}