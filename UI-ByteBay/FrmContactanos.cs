using System.Diagnostics;

namespace UI_ByteBay.Forms
{
    public partial class FrmContactanos : Form
    {
        public FrmContactanos()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void FrmContactanos_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
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

        private void btnGoInstagram_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com";
            AbrirEnlace(url);
        }

        private void btnGoFacebook_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com";
            AbrirEnlace(url);
        }

        private void btnGoTikTok_Click(object sender, EventArgs e)
        {
            string url = "https://www.tiktok.com";
            AbrirEnlace(url);
        }

        private void btnGoTwitter_Click(object sender, EventArgs e)
        {
            string url = "https://www.twitter.com";
            AbrirEnlace(url);
        }

        private void btnGoReddit_Click(object sender, EventArgs e)
        {
            string url = "https://www.reddit.com";
            AbrirEnlace(url);
        }

        private void AbrirEnlace(string url)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el enlace: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //aca queda pendiente enviar a la bdd o algun mail, qcyo
            MessageBox.Show("Mensaje enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtCorreoElectronico.Text = "";
            txtMensaje.Text = "";
        }
    }
}
