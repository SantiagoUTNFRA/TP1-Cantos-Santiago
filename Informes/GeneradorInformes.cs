using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System.Text;

namespace Informes
{
    /// <summary>
    /// Clase responsable de generar informes en diferentes formatos.
    /// </summary>
    public class GeneradorInformes
    {
        /// <summary>
        /// Genera un informe en formato JSON.
        /// </summary>
        /// <param name="logs">Lista de registros de logs a incluir en el informe.</param>
        /// <param name="clientName">El nombre del archivo del informe.</param>
        public static void GenerarInformeJson(List<LogEntry> logs, string clientName)
        {
            if (logs.Count == 0)
            {
                return;
            }

            var json = JsonConvert.SerializeObject(logs);
            File.WriteAllText(clientName, json);
        }


        /// <summary>
        /// Genera un informe en formato CSV.
        /// </summary>
        /// <param name="logs">Lista de registros de logs a incluir en el informe.</param>
        /// <param name="clientName">El nombre del archivo del informe.</param>
        public static void GenerarInformeCsv(List<LogEntry> logs, string clientName)
        {
            var csv = new StringBuilder();

            csv.AppendLine("Fecha,Accion");

            foreach (var log in logs)
            {
                csv.AppendLine($"{log.Time},{log.Action}");
            }

            File.WriteAllText(clientName, csv.ToString());
        }

        /// <summary>
        /// Genera un informe en formato PDF.
        /// </summary>
        /// <param name="logs">Lista de registros de logs a incluir en el informe.</param>
        /// <param name="clientName">El nombre del archivo del informe.</param>
        public static void GenerarInformePdf(List<LogEntry> logs, string clientName)
        {
            var doc = new iTextSharp.text.Document();
            PdfWriter.GetInstance(doc, new FileStream(clientName, FileMode.Create));
            doc.Open();
            foreach (var item in logs)
            {
                doc.Add(new Paragraph($"{item.Time} - {item.Action}"));
            }
            doc.Close();
        }

    }
}
