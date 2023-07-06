using Entidades;
using Firestore;
using Gestores;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace UI_ByteBay.Forms
{
    /// <summary>
    /// Representa la interfaz gráfica de usuario del administrador de la aplicación.
    /// Incluye funcionalidades para acceder a distintas secciones de la aplicación.
    /// </summary>
    public partial class FrmAdministrador : Form
    {
        /// <summary>
        /// <para>Representa el gestor de usuarios de la aplicación.</para>
        /// </summary>
        private GestorUsuario gestorUsuarios;
        /// <summary>
        /// <para>Representa el gestor de productos de la aplicación.</para>
        /// </summary>
        private GestorProducto gestorProductos;

        private TipoEntidad entidadActual;

        /// <summary>
        /// <para>Representa los tipos de entidades que se pueden mostrar en el formulario.</para>
        /// </summary>
        public enum TipoEntidad
        {
            Usuario,
            Producto
        }

        /// <summary>
        /// Constructor de la clase FrmAdministrador. Inicializa los componentes del formulario, configura el formulario y sus controles, y crea instancias de los gestores de usuarios y productos.
        /// </summary>
        public FrmAdministrador()
        {
            InitializeComponent();
            dgvPrincipal.CellFormatting += dgvPrincipal_CellFormatting;
            ConfigurarFormulario();
            gestorUsuarios = new GestorUsuario();
            gestorProductos = new GestorProducto();
        }

        /// <summary>
        /// Evento de carga del formulario FrmAdministrador. Oculta ciertos componentes del formulario y desactiva las opciones de maximizar, minimizar y cerrar.
        /// </summary>
        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            OcultarComponentes();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
        }

        /// <summary>
        /// Configura las propiedades del formulario y sus controles para una presentación linda.
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
            dgvPrincipal.EnableHeadersVisualStyles = false;
            dgvPrincipal.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dgvPrincipal.ColumnHeadersDefaultCellStyle.Font.FontFamily, 18);
            dgvPrincipal.DefaultCellStyle.Font = new System.Drawing.Font(dgvPrincipal.DefaultCellStyle.Font.FontFamily, 14);
            dgvPrincipal.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dgvPrincipal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPrincipal.BackgroundColor = Color.Gray;
            dgvPrincipal.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            dgvPrincipal.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvPrincipal.GridColor = Color.Black;
            dgvPrincipal.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dgvPrincipal.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
            dgvPrincipal.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dgvPrincipal.RowHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
            dgvPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        /// <summary>
        /// Evento de clic en el botón "Gestor de Usuarios". Actualiza la entidad actual a "Usuario", obtiene todos los usuarios mediante el gestor de usuarios y muestra los datos en un DataGridView.
        /// </summary>
        private async void btnGestiorUsuarios_Click(object sender, EventArgs e)
        {
            lblEstoyAdministrando.Text = "Usted se encuentra administrando Usuarios";
            entidadActual = TipoEntidad.Usuario;
            var usuarios = await gestorUsuarios.ObtenerTodos();
            LlenarDataGridView(usuarios);
            ActualizarLabelsEntidad();
            VisualizarComponentesUsuario();
        }

        /// <summary>
        /// Prepara los componentes del formulario para la administración de usuarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnGestionProductos_Click(object sender, EventArgs e)
        {
            lblEstoyAdministrando.Text = "Usted se encuentra administrando Productos";
            entidadActual = TipoEntidad.Producto;
            var productos = await gestorProductos.ObtenerTodos();
            LlenarDataGridView(productos);
            ActualizarLabelsEntidad();
            VisualizarComponentesProducto();
        }

        /// <summary>
        /// Llenar el DataGridView con los datos de la lista pasada por parámetro.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista"></param>
        private void LlenarDataGridView<T>(List<T> lista)
        {
            dgvPrincipal.DataSource = lista.ToList();
        }

        /// <summary>
        /// Actualiza los labels de acuerdo a la entidad actual.
        /// </summary>
        private void ActualizarLabelsEntidad()
        {
            switch (entidadActual)
            {
                case TipoEntidad.Usuario:
                    ConfigurarLabels("Nombre de usuario:", "Contraseña:", "Dni:", "", "");
                    break;
                case TipoEntidad.Producto:
                    ConfigurarLabels("Nombre del producto:", "Precio:", "Stock:", "URL imagen:", "Categoría:");
                    break;
            }
        }

        /// <summary>
        /// Configura los labels de acuerdo a los parámetros pasados por parámetro.
        /// </summary>
        /// <param name="campoUno"></param>
        /// <param name="campoDos"></param>
        /// <param name="campoTres"></param>
        /// <param name="campoCuatro"></param>
        /// <param name="campoCinco"></param>
        private void ConfigurarLabels(string campoUno, string campoDos, string campoTres, string campoCuatro, string campoCinco)
        {
            lblCampoUno.Text = campoUno;
            lblCampoDos.Text = campoDos;
            lblCampoTres.Text = campoTres;
            lblCampoCuatro.Text = campoCuatro;
            lblCampoCinco.Text = campoCinco;
        }

        /// <summary>
        /// Ocultar componentes del formulario.
        /// </summary>
        private void OcultarComponentes()
        {
            ConfigurarVisibilidadComponentes(false, false, false, false, false);
        }

        /// <summary>
        /// Visualizar componentes del formulario pero destinado a mostrar usuarios.
        /// </summary>
        private void VisualizarComponentesUsuario()
        {
            ConfigurarVisibilidadComponentes(true, true, true, false, false);
            txtDos.PasswordChar = '*';
            LimpiarComponentes();
        }

        /// <summary>
        /// Visualizar componentes del formulario pero destinado a mostrar productos.
        /// </summary>
        private void VisualizarComponentesProducto()
        {
            ConfigurarVisibilidadComponentes(true, true, true, true, true);
            txtDos.PasswordChar = '\0';
            LimpiarComponentes();
        }

        /// <summary>
        /// Configura la visibilidad de los componentes del formulario.
        /// </summary>
        /// <param name="visibleUno"></param>
        /// <param name="visibleDos"></param>
        /// <param name="visibleTres"></param>
        /// <param name="visibleCuatro"></param>
        /// <param name="visibleCinco"></param>
        private void ConfigurarVisibilidadComponentes(bool visibleUno, bool visibleDos, bool visibleTres, bool visibleCuatro, bool visibleCinco)
        {
            lblCampoUno.Visible = visibleUno;
            lblCampoDos.Visible = visibleDos;
            lblCampoTres.Visible = visibleTres;
            lblCampoCuatro.Visible = visibleCuatro;
            lblCampoCinco.Visible = visibleCinco;
            txtUno.Visible = visibleUno;
            txtDos.Visible = visibleDos;
            txtTres.Visible = visibleTres;
            txtCuatro.Visible = visibleCuatro;
            txtCinco.Visible = visibleCinco;
        }

        /// <summary>
        /// Limpia los componentes del formulario.
        /// </summary>
        private void LimpiarComponentes()
        {
            txtUno.Text = "";
            txtDos.Text = "";
            txtTres.Text = "";
            txtCuatro.Text = "";
            txtCinco.Text = "";
        }

        /// <summary>
        /// Evento de clic en el botón "Agregar". Crea un usuario o un producto de acuerdo a la entidad actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (entidadActual)
            {
                case TipoEntidad.Usuario:
                    try
                    {
                        await CrearUsuarioAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al crear el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case TipoEntidad.Producto:
                    try
                    {
                        await CrearProductoAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al crear el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        /// <summary>
        /// Evento de clic en el botón "Modificar". Modifica un usuario o un producto de acuerdo a la entidad actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedCells.Count > 0)
            {
                int selectedCellIndex = dgvPrincipal.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPrincipal.Rows[selectedCellIndex];

                switch (entidadActual)
                {
                    case TipoEntidad.Usuario:
                        await ModificarUsuario(selectedRow);
                        break;
                    case TipoEntidad.Producto:
                        await ModificarProducto(selectedRow);
                        break;
                }
            }
        }

        /// <summary>
        /// Evento de clic en el botón "Eliminar". Elimina un usuario o un producto de acuerdo a la entidad actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            switch (entidadActual)
            {
                case TipoEntidad.Usuario:
                    try
                    {
                        await EliminarUsuarioAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case TipoEntidad.Producto:
                    try
                    {
                        await EliminarProductoAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        //CRUD UI

        /// <summary>
        /// Crea un usuario en la base de datos y actualiza la UI.
        /// </summary>
        /// <returns></returns>
        private async Task CrearUsuarioAsync()
        {
            var nuevoUsuario = new Usuario
            {
                NombreDeUsuario = txtUno.Text,
                Contrasenia = txtDos.Text,
                Dni = long.Parse(txtTres.Text)
            };
            await gestorUsuarios.CrearUsuario(nuevoUsuario);
            await ActualizarUsuariosUI();
        }

        /// <summary>
        /// Crea un producto en la base de datos y actualiza la UI.
        /// </summary>
        /// <returns></returns>
        private async Task CrearProductoAsync()
        {
            var nuevoProducto = new Producto
            {
                Nombre = txtUno.Text,
                Precio = double.Parse(txtDos.Text),
                Stock = int.Parse(txtTres.Text),
                ImageUri = txtCuatro.Text,
                Categoria = txtCinco.Text
            };
            await gestorProductos.CrearProducto(nuevoProducto);
            await ActualizarProductosUI();
        }

        /// <summary>
        /// Actualiza un usuario en la base de datos y actualiza la UI.
        /// </summary>
        /// <returns></returns>
        private async Task ActualizarUsuariosUI()
        {
            entidadActual = TipoEntidad.Usuario;
            var usuarios = await gestorUsuarios.ObtenerTodos();
            LlenarDataGridView(usuarios);
            ActualizarLabelsEntidad();
            VisualizarComponentesUsuario();
        }

        /// <summary>
        /// Actualiza un producto en la base de datos y actualiza la UI.
        /// </summary>
        /// <returns></returns>
        private async Task ActualizarProductosUI()
        {
            entidadActual = TipoEntidad.Producto;
            var productos = await gestorProductos.ObtenerTodos();
            LlenarDataGridView(productos);
            ActualizarLabelsEntidad();
            VisualizarComponentesProducto();
        }

        /// <summary>
        /// Elimina un usuario en la base de datos y actualiza la UI.
        /// </summary>
        /// <returns></returns>
        private async Task EliminarUsuarioAsync()
        {
            var usuarioSeleccionado = dgvPrincipal.CurrentRow.DataBoundItem as Usuario;
            await gestorUsuarios.EliminarUsuario(usuarioSeleccionado.NombreDeUsuario);
            await ActualizarUsuariosUI();
        }

        /// <summary>
        /// Elimina un producto en la base de datos y actualiza la UI.
        /// </summary>
        /// <returns></returns>
        private async Task EliminarProductoAsync()
        {
            var productoSeleccionado = dgvPrincipal.CurrentRow.DataBoundItem as Producto;
            await gestorProductos.Eliminar(productoSeleccionado.Nombre);
            await ActualizarProductosUI();
        }

        /// <summary>
        /// Modifica un usuario en la base de datos y actualiza la UI.
        /// </summary>
        /// <param name="selectedRow"></param>
        /// <returns></returns>
        private async Task ModificarUsuario(DataGridViewRow selectedRow)
        {
            try
            {
                var idUsuarioOriginal = selectedRow.Cells["NombreDeUsuario"].Value.ToString();

                var usuarioModificado = new Usuario
                {
                    NombreDeUsuario = txtUno.Text,
                    Contrasenia = txtDos.Text,
                    Dni = long.Parse(txtTres.Text)
                };

                //elimino y creo el usuario para poder usar el ID como nombre de usuario...
                await gestorUsuarios.EliminarUsuario(idUsuarioOriginal!);
                await gestorUsuarios.CrearUsuario(usuarioModificado);

                await ActualizarUsuariosUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Modifica un producto en la base de datos y actualiza la UI.
        /// </summary>
        /// <param name="selectedRow"></param>
        /// <returns></returns>
        private async Task ModificarProducto(DataGridViewRow selectedRow)
        {
            try
            {
                var idProductoOriginal = selectedRow.Cells["Nombre"].Value.ToString();

                var productoModificado = new Producto
                {
                    Nombre = txtUno.Text,
                    Precio = double.Parse(txtDos.Text),
                    Stock = int.Parse(txtTres.Text),
                    ImageUri = txtCuatro.Text,
                    Categoria = txtCinco.Text
                };

                //elimino y creo el usuario para poder usar el ID como nombre de usuario...
                await gestorProductos.EliminarProducto(idProductoOriginal!);
                await gestorProductos.CrearProducto(productoModificado);

                await ActualizarProductosUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ocultar la contraseña en el DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPrincipal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (entidadActual == TipoEntidad.Usuario)
            {
                if (dgvPrincipal.Columns[e.ColumnIndex].Name == "Contrasenia") // Asegúrate de que el nombre de la columna coincide con el nombre que le das a la columna contraseña.
                {
                    if (e.Value != null)
                    {
                        e.Value = new String('*', e.Value.ToString().Length);
                    }
                }
            }
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.IconSize = 50;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.IconSize = 40;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            btnModificar.IconSize = 50;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.IconSize = 40;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.IconSize = 50;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.IconSize = 40;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGestionProductos_MouseEnter(object sender, EventArgs e)
        {
            btnGestionProductos.IconSize = 50;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGestionProductos_MouseLeave(object sender, EventArgs e)
        {
            btnGestionProductos.IconSize = 40;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGestiorUsuarios_MouseEnter(object sender, EventArgs e)
        {
            btnGestiorUsuarios.IconSize = 50;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGestiorUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnGestiorUsuarios.IconSize = 40;
        }
    }
}
