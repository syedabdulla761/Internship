using EveryAngle.Logging;
using System;

namespace EALogTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the logger
            LoggingService.Initialize();

            // Log a message at different severity levels
            Log.SendInfo("Info log message");
            Log.SendWarning("Warning log message");
            Log.SendError("Error log message");

            // Log a message at the "info" severity level
            Log.SendInfo("Hello, world!");

            // Log a message at the "error" severity level, with an exception
            try
            {
                int x = 0;
                int y = 1 / x;
            }
            catch (Exception ex)
            {
                Log.SendError("An error occurred: " + ex.Message, ex);
            }
            Console.ReadLine();
        }
    }
}