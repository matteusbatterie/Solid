using Solid.Interface;

namespace Solid.Classes
{
    public class WindowsLogger : ILogger
    {
        public WindowsLogger() { }

        public void LogError()
        {
            System.Console.WriteLine("Error logged in Windows");
        }

        public void LogWarning()
        {
            System.Console.WriteLine("Warning logged in Windows");
        }
    }
}