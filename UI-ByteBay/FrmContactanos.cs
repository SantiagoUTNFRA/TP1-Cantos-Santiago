using System.Diagnostics;

namespace UI_ByteBay.Forms
{
    /// <summary>
    /// Representa la interfaz gráfica de usuario de la sección "Contáctanos".
    /// Incluye funcionalidades para acceder a distintas secciones de la aplicación.
    /// </summary>
    public partial class FrmContactanos : Form
    {
        /// <summary>
        /// Constructor de la clase FrmContactanos que inicializa los componentes de la interfaz gráfica de usuario.
        /// </summary>
        public FrmContactanos()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        /// <summary>
        /// evento que se ejecuta al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmContactanos_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
        }

        /// <summary>
        /// Configurar el formulario para que se muestre en pantalla completa
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
        /// Al presionar el botón GoToInstagram se abre el navegador con la página de Instagram
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoInstagram_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com";
            AbrirEnlace(url);
        }

        /// <summary>
        /// Al presionar el botón GoToFacebook se abre el navegador con la página de Facebook
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoFacebook_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com";
            AbrirEnlace(url);
        }

        /// <summary>
        /// Al presionar el botón GoToTikTok se abre el navegador con la página de TikTok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoTikTok_Click(object sender, EventArgs e)
        {
            string url = "https://www.tiktok.com";
            AbrirEnlace(url);
        }

        /// <summary>
        /// Al presionar el botón GoToTwitter se abre el navegador con la página de Twitter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoTwitter_Click(object sender, EventArgs e)
        {
            string url = "https://www.twitter.com";
            AbrirEnlace(url);
        }

        /// <summary>
        /// Al presionar el botón GoToReddit se abre el navegador con la página de Reddit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoReddit_Click(object sender, EventArgs e)
        {
            string url = "https://www.reddit.com";
            AbrirEnlace(url);
        }

        /// <summary>
        /// Abrir un enlace en el navegador
        /// </summary>
        /// <param name="url">url del enlace a abrir</param>
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

        /// <summary>
        /// Enviar el mensaje ingresado por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //aca queda pendiente enviar a la bdd o algun mail, qcyo
            MessageBox.Show("Mensaje enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
        }

        /// <summary>
        /// Limpiar los campos de texto
        /// </summary>
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtCorreoElectronico.Text = "";
            txtMensaje.Text = "";
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGoInstagram_MouseEnter(object sender, EventArgs e)
        {
            btnGoInstagram.IconSize = 60;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGoInstagram_MouseLeave(object sender, EventArgs e)
        {
            btnGoInstagram.IconSize = 50;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGoFacebook_MouseEnter(object sender, EventArgs e)
        {
            btnGoFacebook.IconSize = 60;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGoFacebook_MouseLeave(object sender, EventArgs e)
        {
            btnGoFacebook.IconSize = 50;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGoTikTok_MouseEnter(object sender, EventArgs e)
        {
            btnGoTikTok.IconSize = 60;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGoTikTok_MouseLeave(object sender, EventArgs e)
        {
            btnGoTikTok.IconSize = 50;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGoTwitter_MouseEnter(object sender, EventArgs e)
        {
            btnGoTwitter.IconSize = 60;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGoTwitter_MouseLeave(object sender, EventArgs e)
        {
            btnGoTwitter.IconSize = 50;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGoReddit_MouseEnter(object sender, EventArgs e)
        {
            btnGoReddit.IconSize = 60;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGoReddit_MouseLeave(object sender, EventArgs e)
        {
            btnGoReddit.IconSize = 50;
        }
    }
}
