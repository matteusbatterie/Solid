using Solid.Interface;

namespace Solid.Classes.FactoryMethod
{
    public class DatabaseLoggerCreator : LoggerCreator
    {
        public DatabaseLoggerCreator() { }

        public override ILogger FactoryMethod()
        {
            return new DatabaseLogger();
        }
    }
}