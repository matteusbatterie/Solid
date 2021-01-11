using Solid.Interface;

namespace Solid.Classes.FactoryMethod
{
    public class WindowsLoggerCreator : LoggerCreator
    {
        public WindowsLoggerCreator() { }

        public override ILogger FactoryMethod()
        {
            return new WindowsLogger();
        }
    }
}