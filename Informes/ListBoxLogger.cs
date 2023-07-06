using Informes;

public class ListBoxLogger : ILogger
{
    private static ListBoxLogger _instance;
    private readonly List<LogEntry> _logEntries;

    private ListBoxLogger()
    {
        _logEntries = new List<LogEntry>();
    }

    /// <summary>
    /// Obtiene la instancia de ListBoxLogger.
    /// </summary>
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

    /// <summary>
    /// Registra una acción en el log.
    /// </summary>
    /// <param name="action">La acción a registrar.</param>
    public void Log(string action)
    {
        var logEntry = new LogEntry
        {
            Time = DateTime.Now.ToString(),
            Action = action
        };
        _logEntries.Add(logEntry);
    }

    /// <summary>
    /// Obtiene la lista de entradas de log.
    /// </summary>
    /// <returns>La lista de entradas de log.</returns>
    public List<LogEntry> GetLogs()
    {
        return _logEntries;
    }
}
