using Entidades;
using Firestore;
using Gestores;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace UI_ByteBay.Forms
{
    public partial class FrmAdministrador : Form
    {
        private GestorUsuario gestorUsuarios;
        private GestorProducto gestorProductos;
        private TipoEntidad entidadActual;

        public enum TipoEntidad
        {
            Usuario,
            Producto
        }

        public FrmAdministrador()
        {
            InitializeComponent();
            dgvPrincipal.CellFormatting += dgvPrincipal_CellFormatting;
            ConfigurarFormulario();
            gestorUsuarios = new GestorUsuario();
            gestorProductos = new GestorProducto();
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            OcultarComponentes();
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

        private async void btnGestiorUsuarios_Click(object sender, EventArgs e)
        {
            lblEstoyAdministrando.Text = "Usted se encuentra administrando Usuarios";
            entidadActual = TipoEntidad.Usuario;
            var usuarios = await gestorUsuarios.ObtenerTodos();
            LlenarDataGridView(usuarios);
            ActualizarLabelsEntidad();
            VisualizarComponentesUsuario();
        }

        private async void btnGestionProductos_Click(object sender, EventArgs e)
        {
            lblEstoyAdministrando.Text = "Usted se encuentra administrando Productos";
            entidadActual = TipoEntidad.Producto;
            var productos = await gestorProductos.ObtenerTodos();
            LlenarDataGridView(productos);
            ActualizarLabelsEntidad();
            VisualizarComponentesProducto();
        }

        private void LlenarDataGridView<T>(List<T> lista)
        {
            dgvPrincipal.DataSource = lista.ToList();
        }

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

        private void ConfigurarLabels(string campoUno, string campoDos, string campoTres, string campoCuatro, string campoCinco)
        {
            lblCampoUno.Text = campoUno;
            lblCampoDos.Text = campoDos;
            lblCampoTres.Text = campoTres;
            lblCampoCuatro.Text = campoCuatro;
            lblCampoCinco.Text = campoCinco;
        }

        private void OcultarComponentes()
        {
            ConfigurarVisibilidadComponentes(false, false, false, false, false);
        }

        private void VisualizarComponentesUsuario()
        {
            ConfigurarVisibilidadComponentes(true, true, true, false, false);
            txtDos.PasswordChar = '*';
            LimpiarComponentes();
        }

        private void VisualizarComponentesProducto()
        {
            ConfigurarVisibilidadComponentes(true, true, true, true, true);
            txtDos.PasswordChar = '\0';
            LimpiarComponentes();
        }

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

        private void LimpiarComponentes()
        {
            txtUno.Text = "";
            txtDos.Text = "";
            txtTres.Text = "";
            txtCuatro.Text = "";
            txtCinco.Text = "";
        }

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

        private async Task ActualizarUsuariosUI()
        {
            entidadActual = TipoEntidad.Usuario;
            var usuarios = await gestorUsuarios.ObtenerTodos();
            LlenarDataGridView(usuarios);
            ActualizarLabelsEntidad();
            VisualizarComponentesUsuario();
        }

        private async Task ActualizarProductosUI()
        {
            entidadActual = TipoEntidad.Producto;
            var productos = await gestorProductos.ObtenerTodos();
            LlenarDataGridView(productos);
            ActualizarLabelsEntidad();
            VisualizarComponentesProducto();
        }

        private async Task EliminarUsuarioAsync()
        {
            var usuarioSeleccionado = dgvPrincipal.CurrentRow.DataBoundItem as Usuario;
            await gestorUsuarios.EliminarUsuario(usuarioSeleccionado.NombreDeUsuario);
            await ActualizarUsuariosUI();
        }

        private async Task EliminarProductoAsync()
        {
            var productoSeleccionado = dgvPrincipal.CurrentRow.DataBoundItem as Producto;
            await gestorProductos.Eliminar(productoSeleccionado.Nombre);
            await ActualizarProductosUI();
        }

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

    }
}
