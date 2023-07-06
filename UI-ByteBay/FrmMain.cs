using FontAwesome.Sharp;
using UI_ByteBay.Forms;
using Entidades;

namespace UI_ByteBay
{
    /// <summary>
    /// Representa la interfaz gr�fica de usuario (GUI) principal para la aplicaci�n ByteBay.
    /// Incluye funcionalidades para acceder a distintas secciones de la aplicaci�n.
    /// </summary>
    public partial class FrmMain : Form
    {
        private int menuWidth;
        private int iconWidth;
        private bool estaColapsado;

        //Variables para verificar su estado y no volver a abrir el mismo formulario
        private Form formularioActual = null!;

        private readonly FrmInicio frmInicio;
        private readonly FrmCategorias frmCategorias;
        private readonly FrmMiCarrito frmMiCarrito;
        private readonly FrmAdministrador frmAdministrador;
        private readonly FrmContactanos frmContactanos;
        private readonly FrmInformes frmInformes;

        /// <summary>
        /// Constructor por defecto de la clase FrmMain que inicializa los componentes de la interfaz gr�fica.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();

            frmInicio = new FrmInicio
            {
                MdiParent = this
            };

            frmMiCarrito = new FrmMiCarrito
            {
                MdiParent = this
            };

            frmCategorias = new FrmCategorias()
            {
                MdiParent = this
            };

            frmInformes = new FrmInformes
            {
                MdiParent = this
            };

            frmAdministrador = new FrmAdministrador
            {
                MdiParent = this
            };

            frmContactanos = new FrmContactanos()
            {
                MdiParent = this
            };
        }

        /// <summary>
        /// Carga inicial de la aplicaci�n, estableciendo propiedades y presentando la pantalla de inicio.
        /// </summary>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            menuWidth = flpContenedor.Width;
            iconWidth = pnlInicio.Width;
            estaColapsado = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;


            MostrarFormulario(frmInicio);
            UsuarioLogeado usuarioLogeado = UsuarioLogeado.ObtenerInstancia();

            Usuario usuarioActual = usuarioLogeado.GetUsuario();
            if (usuarioActual != null)
            {
                btnUser.Text = "Bienvenido " + usuarioActual.NombreDeUsuario;
            }
            else
            {
                btnUser.Text = "Modo Invitado";
                btnUser.IconChar = IconChar.UserSecret;
            }
        }

        /// <summary>
        /// Muestra u oculta el men� de navegaci�n.
        /// </summary>
        private void btnMenu_Click(object sender, EventArgs e)
        {
            flpContenedor.Size = estaColapsado ? new Size(menuWidth, flpContenedor.Height) : new Size(iconWidth, flpContenedor.Height);
            this.Size = estaColapsado ? new Size(1368, 893) : new Size(1500, 893);
            btnMenu.IconChar = estaColapsado ? IconChar.Bars : IconChar.Times;
            btnMenu.Text = estaColapsado ? "" : "Men�";
            estaColapsado = !estaColapsado;
            Program.Logger.Log("El usuario hizo clic en el bot�n Men�");
        }

        /// <summary>
        /// Muestra el formulario de inicio.
        /// </summary>
        private void btnInicio_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmInicio);
            Program.Logger.Log("El usuario hizo clic en el bot�n Inicio");
        }

        /// <summary>
        /// Muestra el formulario de categor�as.
        /// </summary>
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmCategorias);
            Program.Logger.Log("El usuario hizo clic en el bot�n Categor�as");
        }

        /// <summary>
        /// Muestra el formulario de carrito.
        /// </summary>
        private void btnMiCarrito_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmMiCarrito);
            Program.Logger.Log("El usuario hizo clic en el bot�n Mi Carrito");
        }

        /// <summary>
        /// Muestra el formulario de contacto.
        /// </summary>
        private void btnContactanos_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmContactanos);
            Program.Logger.Log("El usuario hizo clic en el bot�n Contactanos");
        }

        /// <summary>
        /// Muestra el formulario de informes.
        /// </summary>
        private void btnNosotros_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmInformes);
            Program.Logger.Log("El usuario hizo clic en el bot�n Informes");
        }

        /// <summary>
        /// Muestra el formulario de administrador.
        /// </summary>
        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmAdministrador);
            Program.Logger.Log("El usuario hizo clic en el bot�n Administrador");
        }

        /// <summary>
        /// Cierra la sesi�n del usuario y vuelve a la pantalla de inicio de sesi�n.
        /// </summary>
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            App.LoginFormInstance.Show();
            Program.Logger.Log("El usuario hizo clic en el bot�n Cerrar Sesi�n");
        }

        /// <summary>
        /// Muestra el formulario pasado como par�metro, ocultando cualquier otro formulario abierto.
        /// </summary>
        /// <param name="formulario">El formulario a mostrar.</param>
        private void MostrarFormulario(Form formulario)
        {
            if (formulario == null || formulario == formularioActual) return;

            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            formulario.MdiParent = this;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.WindowState = FormWindowState.Maximized;
            formulario.StartPosition = FormStartPosition.Manual;
            formulario.ShowInTaskbar = false;
            formulario.ShowIcon = false;
            formulario.MaximizeBox = false;
            formulario.MinimizeBox = false;
            formulario.ControlBox = false;
            formulario.Show();

            formularioActual = formulario;
        }


        #region EVENTOS

        //EVENTOS

        /// <summary>
        /// Evento que se ejecuta al cerrar el formulario, mostrando la pantalla de inicio de sesi�n.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            App.LoginFormInstance.Show();
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.IconSize = 58;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.IconSize = 48;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnUser_MouseEnter(object sender, EventArgs e)
        {
            btnUser.IconSize = 58;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnUser_MouseLeave(object sender, EventArgs e)
        {
            btnUser.IconSize = 48;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            btnInicio.IconSize = 58;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            btnInicio.IconSize = 48;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnCategorias_MouseEnter(object sender, EventArgs e)
        {
            btnCategorias.IconSize = 58;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnCategorias_MouseLeave(object sender, EventArgs e)
        {
            btnCategorias.IconSize = 48;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnMiCarrito_MouseEnter(object sender, EventArgs e)
        {
            btnMiCarrito.IconSize = 58;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnMiCarrito_MouseLeave(object sender, EventArgs e)
        {
            btnMiCarrito.IconSize = 48;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnContactanos_MouseEnter(object sender, EventArgs e)
        {
            btnContactanos.IconSize = 58;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnContactanos_MouseLeave(object sender, EventArgs e)
        {
            btnContactanos.IconSize = 48;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnInformes_MouseEnter(object sender, EventArgs e)
        {
            btnInformes.IconSize = 58;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnInformes_MouseLeave(object sender, EventArgs e)
        {
            btnInformes.IconSize = 48;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnAdministrador_MouseEnter(object sender, EventArgs e)
        {
            btnAdministrador.IconSize = 58;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnAdministrador_MouseLeave(object sender, EventArgs e)
        {
            btnAdministrador.IconSize = 48;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            btnCerrarSesion.IconSize = 58;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tama�o del �cono del bot�n cuando el mouse entra o sale del bot�n.
        /// </summary>
        private void btnCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarSesion.IconSize = 48;
        }

        #endregion
    }

    /// <summary>
    /// Clase est�tica que contiene la instancia del formulario de inicio de sesi�n.
    /// </summary>
    public static class App
    {
        public static Login LoginFormInstance { get; set; }
    }
}