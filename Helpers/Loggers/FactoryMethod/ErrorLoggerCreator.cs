using Solid.Helpers.Notification;

namespace Solid.Helpers.Loggers.FactoryMethod
{
    public abstract class ErrorLoggerCreator
    {
        public ErrorLoggerCreator() { }


        public abstract ErrorLogger FactoryMethod();

        public void LogError(Error error)
        {
            var logger = FactoryMethod();
            logger.LogError(error);
        }
    }
}
