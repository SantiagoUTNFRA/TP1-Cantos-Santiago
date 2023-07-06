namespace Informes
{
    public class LogEntry
    {
        public string Time { get; set; }
        public string Action { get; set; }

        public override string ToString()
        {
            return $"{Time}: {Action}";
        }
    }
}
