using System;

namespace LoggingKata
{
    public class TacoLogger : ILog
    {
        public void LogFatal(string log, Exception exception = null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fatal: {log}, Exception {exception}");
            Console.ResetColor();
        }

        public void LogError(string log, Exception exception = null)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Error: {log}, Exception {exception}");
            Console.ResetColor();
        }

        public void LogWarning(string log)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Warning: {log}");
            Console.ResetColor();
        }

        public void LogInfo(string log)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Info: {log}");
            Console.ResetColor();
        }

        public void LogDebug(string log)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Debug: {log}");
            Console.ResetColor();
        }
    }
}
