using Solid.Helpers.Notification;

namespace Solid.Interface
{
    public interface ILogger
    {
        void DisplayError(Error error);
        void LogError(Error error);
    }
}
