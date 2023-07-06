using Entidades;
using Informes;

namespace UI_ByteBay
{
    public partial class FrmInformes : Form
    {
        public FrmInformes()
        {
            InitializeComponent();
            ConfigurarFormulario();
            this.Activated += FrmInformes_Activated;
        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
        }
        private void FrmInformes_Activated(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var logs = Program.Logger.GetLogs();

            UsuarioLogeado usuarioLogeado = UsuarioLogeado.ObtenerInstancia();
            Usuario usuarioActual = usuarioLogeado.GetUsuario();
            string nombreUsuario = (usuarioActual != null) ? usuarioActual.NombreDeUsuario : "Modo Invitado";

            //listBox1.Items.Add($"Movimientos del usuario: {nombreUsuario}");
            lblMovimientos.Text = "Movimientos actuales del usuario: " + nombreUsuario;

            // Añade los registros al ListBox.
            foreach (var log in logs)
            {
                listBox1.Items.Add(log);
            }
        }


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

        private string ObtenerNombreUsuario()
        {
            UsuarioLogeado usuarioLogeado = UsuarioLogeado.ObtenerInstancia();
            Usuario usuarioActual = usuarioLogeado.GetUsuario();
            return (usuarioActual != null) ? usuarioActual.NombreDeUsuario : "Modo Invitado";
        }

        #region Eventos
        private void btnExportJson_MouseEnter(object sender, EventArgs e)
        {
            btnExportJson.IconSize = 50;
        }

        private void btnExportJson_MouseLeave(object sender, EventArgs e)
        {
            btnExportJson.IconSize = 40;
        }

        private void btnExportCsv_MouseEnter(object sender, EventArgs e)
        {
            btnExportCsv.IconSize = 50;
        }

        private void btnExportCsv_MouseLeave(object sender, EventArgs e)
        {
            btnExportCsv.IconSize = 40;
        }

        private void btnExportPdf_MouseEnter(object sender, EventArgs e)
        {
            btnExportPdf.IconSize = 50;
        }

        private void btnExportPdf_MouseLeave(object sender, EventArgs e)
        {
            btnExportPdf.IconSize = 40;
        }

        #endregion
    }
}
