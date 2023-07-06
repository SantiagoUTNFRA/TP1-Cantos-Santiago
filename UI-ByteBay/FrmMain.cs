using FontAwesome.Sharp;
using UI_ByteBay.Forms;
using Entidades;

namespace UI_ByteBay
{
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            flpContenedor.Size = estaColapsado ? new Size(menuWidth, flpContenedor.Height) : new Size(iconWidth, flpContenedor.Height);
            this.Size = estaColapsado ? new Size(1368, 893) : new Size(1500, 893);
            btnMenu.IconChar = estaColapsado ? IconChar.Bars : IconChar.Times;
            btnMenu.Text = estaColapsado ? "" : "Menú";
            estaColapsado = !estaColapsado;
            Program.Logger.Log("El usuario hizo clic en el botón Menú");
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmInicio);
            Program.Logger.Log("El usuario hizo clic en el botón Inicio");
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmCategorias);
            Program.Logger.Log("El usuario hizo clic en el botón Categorías");
        }

        private void btnMiCarrito_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmMiCarrito);
            Program.Logger.Log("El usuario hizo clic en el botón Mi Carrito");
        }

        private void btnContactanos_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmContactanos);
            Program.Logger.Log("El usuario hizo clic en el botón Contactanos");
        }

        private void btnNosotros_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmInformes);
            Program.Logger.Log("El usuario hizo clic en el botón Informes");
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmAdministrador);
            Program.Logger.Log("El usuario hizo clic en el botón Administrador");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            App.LoginFormInstance.Show();
            Program.Logger.Log("El usuario hizo clic en el botón Cerrar Sesión");
        }

        #region METODOS
        //METODOS
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
        #endregion

        #region EVENTOS
        //EVENTOS
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            App.LoginFormInstance.Show();
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.IconSize = 58;
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.IconSize = 48;
        }

        private void btnUser_MouseEnter(object sender, EventArgs e)
        {
            btnUser.IconSize = 58;
        }

        private void btnUser_MouseLeave(object sender, EventArgs e)
        {
            btnUser.IconSize = 48;
        }

        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            btnInicio.IconSize = 58;
        }

        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            btnInicio.IconSize = 48;
        }

        private void btnCategorias_MouseEnter(object sender, EventArgs e)
        {
            btnCategorias.IconSize = 58;
        }

        private void btnCategorias_MouseLeave(object sender, EventArgs e)
        {
            btnCategorias.IconSize = 48;
        }

        private void btnMiCarrito_MouseEnter(object sender, EventArgs e)
        {
            btnMiCarrito.IconSize = 58;
        }

        private void btnMiCarrito_MouseLeave(object sender, EventArgs e)
        {
            btnMiCarrito.IconSize = 48;
        }

        private void btnContactanos_MouseEnter(object sender, EventArgs e)
        {
            btnContactanos.IconSize = 58;
        }

        private void btnContactanos_MouseLeave(object sender, EventArgs e)
        {
            btnContactanos.IconSize = 48;
        }

        private void btnInformes_MouseEnter(object sender, EventArgs e)
        {
            btnInformes.IconSize = 58;
        }

        private void btnInformes_MouseLeave(object sender, EventArgs e)
        {
            btnInformes.IconSize = 48;
        }

        private void btnAdministrador_MouseEnter(object sender, EventArgs e)
        {
            btnAdministrador.IconSize = 58;
        }

        private void btnAdministrador_MouseLeave(object sender, EventArgs e)
        {
            btnAdministrador.IconSize = 48;
        }

        private void btnCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            btnCerrarSesion.IconSize = 58;
        }

        private void btnCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarSesion.IconSize = 48;
        }
        #endregion


    }

    public static class App
    {
        public static Login LoginFormInstance { get; set; }
    }
}