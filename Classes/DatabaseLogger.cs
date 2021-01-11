using Solid.Interface;

namespace Solid.Classes
{
    public class DatabaseLogger : ILogger
    {
        public DatabaseLogger() { }

        public void LogError()
        {
            System.Console.WriteLine("Error logged in the database");
        }

        public void LogWarning()
        {
            System.Console.WriteLine("Warning logged in the database");
        }
    }
}