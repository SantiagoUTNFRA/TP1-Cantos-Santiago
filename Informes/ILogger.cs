namespace Informes
{
    public delegate void UserActionDelegate(string action);

    public interface ILogger
    {
        void Log(string message);
    }
}