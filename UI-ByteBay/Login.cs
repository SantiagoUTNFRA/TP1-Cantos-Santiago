using Entidades;
using Gestores;
using Login;

namespace UI_ByteBay
{
    public partial class Login : Form
    {
        private readonly GestorUsuario _gestorUsuario;

        public Login()
        {
            InitializeComponent();

            _gestorUsuario = new GestorUsuario();
        }

        private void btnIniciarSesionInvitado_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private async void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario(txtUsuarioRegistro.Text, txtContraseniaRegistro.Text, long.Parse(txtDniRegistro.Text));

                await _gestorUsuario.CrearUsuario(usuario);
                MessageBox.Show("Cuenta creada con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el usuario: {ex.Message}");
            }
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            AuthService authService = new AuthService(_gestorUsuario);
            bool esCredencialValida = await authService.IniciarSesion(txtUsuario.Text, txtContrasenia.Text);

            if (esCredencialValida)
            {
                UsuarioLogeado usuarioLogeado = UsuarioLogeado.ObtenerInstancia();
                Usuario usuario = new Usuario { NombreDeUsuario = txtUsuario.Text, Contrasenia = txtContrasenia.Text };
                usuarioLogeado.SetUsuario(usuario);

                Iniciar();
            }
            else
            {
                MessageBox.Show("Error al iniciar sesión: Nombre de usuario o contraseña incorrectos.");
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            tbcAll.SelectTab(0);
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            tbcAll.SelectTab(1);
        }

        private void Iniciar()
        {
            try
            {
                FrmMain frmMain = new();
                frmMain.Show();
                App.LoginFormInstance = this;
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al iniciar la aplicación.");
            }
        }

        private void btnAutoComplete_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "admin";
            txtContrasenia.Text = "admin";
        }

        private void btnIniciarSesion_MouseEnter(object sender, EventArgs e)
        {
            btnIniciarSesion.IconSize = 58;
        }

        private void btnIniciarSesion_MouseLeave(object sender, EventArgs e)
        {
            btnIniciarSesion.IconSize = 48;
        }

        private void btnRegistrarse_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrarse.IconSize = 58;
        }

        private void btnRegistrarse_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarse.IconSize = 48;
        }

        private void btnIniciarSesionInvitado_MouseEnter(object sender, EventArgs e)
        {
            btnIniciarSesionInvitado.IconSize = 58;
        }

        private void btnIniciarSesionInvitado_MouseLeave(object sender, EventArgs e)
        {
            btnIniciarSesionInvitado.IconSize = 48;
        }

        private void btnIniciar_MouseEnter(object sender, EventArgs e)
        {
            btnIniciar.IconSize = 58;
        }

        private void btnIniciar_MouseLeave(object sender, EventArgs e)
        {
            btnIniciar.IconSize = 48;
        }

        private void btnRegistro_MouseEnter(object sender, EventArgs e)
        {
            btnRegistro.IconSize = 58;
        }

        private void btnRegistro_MouseLeave(object sender, EventArgs e)
        {
            btnRegistro.IconSize = 48;
        }
    }
}