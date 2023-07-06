using Informes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethods
{
    [TestClass]
    public class JsonTests
    {
        [TestMethod]
        public void GenerarInformeJson_CreaArchivoJsonCorrectamente()
        {
            // Arrange
            var logs = new List<LogEntry>
            {
                new LogEntry { Time = "2023-07-06 09:30:00", Action = "Acción 1" },
                new LogEntry { Time = "2023-07-06 10:15:00", Action = "Acción 2" },
                new LogEntry { Time = "2023-07-06 11:00:00", Action = "Acción 3" }
            };
            var clientName = "informe.json";

            // Act
            GeneradorInformes.GenerarInformeJson(logs, clientName);

            // Assert
            Assert.IsTrue(File.Exists(clientName));
        }

        [TestMethod]
        public void GenerarInformeJson_NoCreaArchivoJsonConListaVacia()
        {
            // Arrange
            var logs = new List<LogEntry>();
            var clientName = "informe.json";

            // Act
            GeneradorInformes.GenerarInformeJson(logs, clientName);

            // Assert
            Assert.IsFalse(File.Exists(clientName));
        }

    }
}
