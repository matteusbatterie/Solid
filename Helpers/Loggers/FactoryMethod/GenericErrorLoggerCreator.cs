using Solid.Helpers.Loggers;

namespace Solid.Helpers.Loggers.FactoryMethod
{
    public class GenericErrorLoggerCreator : LoggerCreator
    {
        public GenericErrorLoggerCreator() { }


        public override Logger FactoryMethod() => new GenericErrorLogger();
    }
}