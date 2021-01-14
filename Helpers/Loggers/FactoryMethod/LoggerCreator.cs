using Solid.Helpers.Notification;

namespace Solid.Helpers.Loggers.FactoryMethod
{
    public abstract class LoggerCreator
    {
        public LoggerCreator() { }


        public abstract Logger FactoryMethod();

        public void LogError(Error error)
        {
            var logger = FactoryMethod();
            logger.LogError(error);
        }
    }
}