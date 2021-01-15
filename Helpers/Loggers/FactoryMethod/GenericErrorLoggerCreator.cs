using Solid.Helpers.Loggers;

namespace Solid.Helpers.Loggers.FactoryMethod
{
    public class GenericErrorLoggerCreator : ErrorLoggerCreator
    {
        public GenericErrorLoggerCreator() { }


        public override ErrorLogger FactoryMethod() => new GenericErrorLogger();
    }
}
