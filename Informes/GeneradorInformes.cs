using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System.Text;

namespace Informes
{
    public class GeneradorInformes
    {
        public static void GenerarInformeJson(List<LogEntry> logs, string clientName)
        {
            var json = JsonConvert.SerializeObject(logs);
            File.WriteAllText(clientName, json);
        }

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
