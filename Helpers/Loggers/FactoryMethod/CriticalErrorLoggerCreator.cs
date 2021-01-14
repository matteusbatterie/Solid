namespace Solid.Helpers.Loggers.FactoryMethod
{
    public class CriticalErrorLoggerCreator : LoggerCreator
    {
        public CriticalErrorLoggerCreator() { }


        public override Logger FactoryMethod() => new CriticalErrorLogger();
    }
}