using Solid.Interface;

namespace Solid.Classes.FactoryMethod
{
    public class ConsoleLoggerCreator : LoggerCreator
    {
        public ConsoleLoggerCreator() { }

        public override ILogger FactoryMethod()
        {
            return new ConsoleLogger();
        }
    }
}