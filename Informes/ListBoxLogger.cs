using Informes;

public class ListBoxLogger : ILogger
{
    private static ListBoxLogger _instance;
    private readonly List<LogEntry> _logEntries;

    private ListBoxLogger()
    {
        _logEntries = new List<LogEntry>();
    }

    public static ListBoxLogger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ListBoxLogger();
            }
            return _instance;
        }
    }

    public void Log(string action)
    {
        var logEntry = new LogEntry
        {
            Time = DateTime.Now.ToString(),
            Action = action
        };
        _logEntries.Add(logEntry);
    }

    public List<LogEntry> GetLogs()
    {
        return _logEntries;
    }
}
