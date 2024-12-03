using Singleton.Services;

Logger logger1 = Logger.GetInstance("C:\\Logs\\ApplicationLogs.txt");
Logger logger2 = Logger.GetInstance("C:\\Logs\\ApplicationLogs.txt");

logger1.Log("Application has started from logger1...");
logger2.Log("Application has started from logger2...");

Console.ReadKey();