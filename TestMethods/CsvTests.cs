using Informes;

namespace TestMethods
{
    [TestClass]
    internal class CsvTests
    {
        [TestMethod]
        public void GenerarInformeCsv_CreaArchivoCsvCorrectamente()
        {
            // Arrange
            var logs = new List<LogEntry>
            {
                new LogEntry { Time = "2023-07-06 09:30:00", Action = "Acción 1" },
                new LogEntry { Time = "2023-07-06 10:15:00", Action = "Acción 2" },
                new LogEntry { Time = "2023-07-06 11:00:00", Action = "Acción 3" }
            };
            var clientName = "informe.csv";

            // Act
            GeneradorInformes.GenerarInformeCsv(logs, clientName);

            // Assert
            Assert.IsTrue(File.Exists(clientName));
            var csvContent = File.ReadAllText(clientName);
            Assert.IsTrue(csvContent.Contains("Fecha,Accion"));
            Assert.IsTrue(csvContent.Contains("2023-07-06 09:30:00,Acción 1"));
            Assert.IsTrue(csvContent.Contains("2023-07-06 10:15:00,Acción 2"));
            Assert.IsTrue(csvContent.Contains("2023-07-06 11:00:00,Acción 3"));
        }

        [TestMethod]
        public void GenerarInformeCsv_RegistrosVacios_CreaArchivoCsvVacio()
        {
            // Arrange
            var logs = new List<LogEntry>();
            var clientName = "informe.csv";

            // Act
            GeneradorInformes.GenerarInformeCsv(logs, clientName);

            // Assert
            Assert.IsTrue(File.Exists(clientName));
            var csvContent = File.ReadAllText(clientName);
            Assert.AreEqual("Fecha,Accion" + Environment.NewLine, csvContent);
        }

    }
}
