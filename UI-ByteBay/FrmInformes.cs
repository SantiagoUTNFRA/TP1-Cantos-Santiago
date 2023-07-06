using Entidades;
using Informes;
using LiveCharts;
using LiveCharts.Wpf;

namespace UI_ByteBay
{
    /// <summary>
    /// Representa la interfaz gráfica de usuario (GUI) para mostrar los informes de la aplicación.
    /// </summary>
    public partial class FrmInformes : Form
    {
        public FrmInformes()
        {
            InitializeComponent();
            ConfigurarFormulario();
            this.Activated += FrmInformes_Activated;
        }

        /// <summary>
        /// Se ejecuta cuando se carga el formulario, estableciendo propiedades y cargando informes.
        /// </summary>
        private void FrmInformes_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
        }

        /// <summary>
        /// Se ejecuta cuando el formulario es activado, actualizando la lista de informes.
        /// </summary>
        private void FrmInformes_Activated(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var logs = Program.Logger.GetLogs();

            UsuarioLogeado usuarioLogeado = UsuarioLogeado.ObtenerInstancia();
            Usuario usuarioActual = usuarioLogeado.GetUsuario();
            string nombreUsuario = (usuarioActual != null) ? usuarioActual.NombreDeUsuario : "Modo Invitado";

            lblMovimientos.Text = "Movimientos actuales del usuario: " + nombreUsuario;

            // Añade los registros al ListBox.
            foreach (var log in logs)
            {
                listBox1.Items.Add(log);
            }

            GenerarGraficoEstadistico();
        }

        /// <summary>
        /// Configura las propiedades del formulario y sus controles para una presentación optimizada.
        /// </summary>
        private void ConfigurarFormulario()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.Manual;
            ShowInTaskbar = false;
            ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        /// <summary>
        /// Exporta los informes actuales a un archivo JSON.
        /// </summary>
        private void btnExportJson_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON File|*.json",
                Title = "Guardar Informe JSON",
                FileName = $"Informe_Cliente_{ObtenerNombreUsuario()}.json"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GeneradorInformes.GenerarInformeJson(Program.Logger.GetLogs(), saveFileDialog.FileName);
            }
        }

        /// <summary>
        /// Exporta los informes actuales a un archivo CSV.
        /// </summary>
        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV File|*.csv",
                Title = "Guardar Informe CSV",
                FileName = $"Informe_Cliente_{ObtenerNombreUsuario()}.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GeneradorInformes.GenerarInformeCsv(Program.Logger.GetLogs(), saveFileDialog.FileName);
            }
        }

        /// <summary>
        /// Exporta los informes actuales a un archivo PDF.
        /// </summary>
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF File|*.pdf",
                Title = "Guardar Informe PDF",
                FileName = $"Informe_Cliente_{ObtenerNombreUsuario()}.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GeneradorInformes.GenerarInformePdf(Program.Logger.GetLogs(), saveFileDialog.FileName);
            }
        }

        /// <summary>
        /// Obtiene el nombre de usuario del usuario actualmente logeado.
        /// </summary>
        /// <returns>El nombre de usuario del usuario actualmente logeado.</returns>
        private string ObtenerNombreUsuario()
        {
            UsuarioLogeado usuarioLogeado = UsuarioLogeado.ObtenerInstancia();
            Usuario usuarioActual = usuarioLogeado.GetUsuario();
            return (usuarioActual != null) ? usuarioActual.NombreDeUsuario : "Modo Invitado";
        }

        /// <summary>
        /// Generar el gráfico estadístico de acciones de usuario.
        /// </summary>
        private void GenerarGraficoEstadistico()
        {
            var logs = Program.Logger.GetLogs();
            var datosEstadisticos = ObtenerDatosEstadisticos(logs);
            var series = CrearSeries(datosEstadisticos);
            ConfigurarGrafico(series);
        }

        /// <summary>
        /// Obgtener los datos estadísticos de los logs.
        /// </summary>
        /// <param name="logs">Los logs de la aplicación.</param>
        /// <returns>Un diccionario con los datos estadísticos.</returns>
        private Dictionary<string, int> ObtenerDatosEstadisticos(List<LogEntry> logs)
        {
            var datosEstadisticos = new Dictionary<string, int>();

            foreach (var log in logs)
            {
                var accion = log.Action;

                if (datosEstadisticos.ContainsKey(accion))
                {
                    datosEstadisticos[accion]++;
                }
                else
                {
                    datosEstadisticos.Add(accion, 1);
                }
            }

            return datosEstadisticos;
        }

        /// <summary>
        /// Crear las series del gráfico estadístico.
        /// </summary>
        /// <param name="datosEstadisticos">Los datos estadísticos.</param>
        /// <returns>Una colección de series.</returns>
        private SeriesCollection CrearSeries(Dictionary<string, int> datosEstadisticos)
        {
            var series = new SeriesCollection();
            var random = new Random();

            foreach (var dato in datosEstadisticos)
            {
                var barra = new ColumnSeries
                {
                    Title = dato.Key,
                    Values = new ChartValues<int> { dato.Value },
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256)))
                };

                barra.DataLabels = true;
                barra.LabelPoint = point => $"{point.Y}";

                series.Add(barra);
            }

            return series;
        }


        /// <summary>
        /// Configurar las propiedades del gráfico estadístico.
        /// </summary>
        /// <param name="series">La colección de series del gráfico.</param>
        private void ConfigurarGrafico(SeriesCollection series)
        {
            cartesianChart1.Series = series;
            cartesianChart1.AxisX.Add(new Axis { Labels = new List<string>(), Separator = new Separator { Step = 1 } });
            cartesianChart1.AxisY.Add(new Axis { LabelFormatter = value => "" });

            cartesianChart1.Update();
        }

        #region Eventos

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnExportJson_MouseEnter(object sender, EventArgs e)
        {
            btnExportJson.IconSize = 50;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnExportJson_MouseLeave(object sender, EventArgs e)
        {
            btnExportJson.IconSize = 40;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnExportCsv_MouseEnter(object sender, EventArgs e)
        {
            btnExportCsv.IconSize = 50;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnExportCsv_MouseLeave(object sender, EventArgs e)
        {
            btnExportCsv.IconSize = 40;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnExportPdf_MouseEnter(object sender, EventArgs e)
        {
            btnExportPdf.IconSize = 50;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnExportPdf_MouseLeave(object sender, EventArgs e)
        {
            btnExportPdf.IconSize = 40;
        }

        #endregion
    }
}
