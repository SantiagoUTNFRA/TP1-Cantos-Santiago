using Informes;
using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethods
{
    [TestClass]
    public class PdfTests
    {

        [TestMethod]
        public void GenerarInformePdf_CreaArchivoPdfCorrectamente()
        {
            // Arrange
            var logs = new List<LogEntry>
            {
                new LogEntry { Time = "2023-07-06 09:30:00", Action = "Acción 1" },
                new LogEntry { Time = "2023-07-06 10:15:00", Action = "Acción 2" },
                new LogEntry { Time = "2023-07-06 11:00:00", Action = "Acción 3" }
            };
            var clientName = "informe.pdf";

            // Act
            GeneradorInformes.GenerarInformePdf(logs, clientName);

            // Assert
            Assert.IsTrue(File.Exists(clientName));

            using (var reader = new PdfReader(clientName))
            {
                var totalPages = reader.NumberOfPages;
                Assert.AreEqual(1, totalPages);

                var textContent = PdfTextExtractor.GetTextFromPage(reader, 1);
                Assert.IsTrue(textContent.Contains("2023-07-06 09:30:00 - Acción 1"));
                Assert.IsTrue(textContent.Contains("2023-07-06 10:15:00 - Acción 2"));
                Assert.IsTrue(textContent.Contains("2023-07-06 11:00:00 - Acción 3"));
            }
        }
    }
}
