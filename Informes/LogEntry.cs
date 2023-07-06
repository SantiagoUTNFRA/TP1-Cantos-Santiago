namespace Informes
{
    /// <summary>
    /// Representa una entrada de log con la hora y la acción registrada.
    /// </summary>
    public class LogEntry
    {
        /// <summary>
        /// Obtiene o establece el momento en que se registró la acción.
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Obtiene o establece la acción que se registró.
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Devuelve una cadena que representa el objeto actual.  pd: Se que no la utilizo
        /// pero si no tenia el override hecho me tomaba el ToString() de object y me tirala la ubicación de la clase... 
        /// </summary>
        /// <returns>Una cadena que representa el objeto actual.</returns>
        public override string ToString()
        {
            return $"{Time}: {Action}";
        }
    }
}
