namespace Informes
{
    /// <summary>
    /// Representa un método que maneja una acción de usuario.
    /// </summary>
    /// <param name="action">La acción realizada por el usuario.</param>
    public delegate void UserActionDelegate(string action);

    /// <summary>
    /// Define los métodos para una implementación de un registrador de eventos.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Registra un mensaje.
        /// </summary>
        /// <param name="message">El mensaje a registrar.</param>
        void Log(string message);
    }
}