using Solid.Interface;

namespace Solid.Classes.FactoryMethod
{
    public abstract class LoggerCreator
    {
        public LoggerCreator() { }

        public abstract ILogger FactoryMethod();

        public void LogError()
        {
            var logger = FactoryMethod();
            logger.LogError();
        }

        public void LogWarning()
        {
            var logger = FactoryMethod();
            logger.LogWarning();
        }
    }
}