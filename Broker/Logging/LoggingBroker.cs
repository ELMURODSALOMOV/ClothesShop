using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Broker.Logging
{
    internal class LoggingBroker: ILoggingBroker
    {
        public void LogInformation(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public void LogError(Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(exception);
            Console.ResetColor();
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
