namespace Singleton.Services;

internal sealed class Logger
{
    private static Logger _logger;
    private static string? _filePath;

    private Logger() { }

    public static Logger GetInstance(string? filePath)
    {
        _filePath = filePath;

        if(_logger is null)
        {
            _logger = new Logger();
        }

        return _logger;
    }

    public void Log(string messaeg)
    {
        File.AppendAllText(_filePath, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {messaeg}");
    }
}
