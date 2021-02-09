namespace Solid.Helpers.Loggers.FactoryMethod
{
    public class CriticalErrorLoggerCreator : ErrorLoggerCreator
    {
        public CriticalErrorLoggerCreator() { }


        public override ErrorLogger FactoryMethod() => new CriticalErrorLogger();
    }
}
