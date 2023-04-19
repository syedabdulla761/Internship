using EveryAngle.Logging;

public static class LoggingService
{
    public static void Initialize()
    {
        var logFolder = "C:\\Users\\syed.abdulla\\source\\repos\\EAlogTask1.2\\Logs"; // Replace with your desired log folder path
        var maxLogFileSize = 1024; // Replace with your desired max log file size in kilobytes
        var maxLogFileNumber = 5; // Replace with your desired max number of log files

        Log.Initialize(logFolder, maxLogFileSize, maxLogFileNumber, true, "MyConsoleApp");
    }
}
