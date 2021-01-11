using Solid.Interface;

namespace Solid.Classes
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger() { }

        public void LogError()
        {
            System.Console.WriteLine("Error logged in the console");
        }

        public void LogWarning()
        {
            System.Console.WriteLine("Warning logged in the console");
        }
    }
}