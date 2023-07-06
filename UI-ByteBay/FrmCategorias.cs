using Entidades;
using Firestore;
using Gestores;
using UI_ByteBay.Forms;

namespace UI_ByteBay
{
    /// <summary>
    /// Representa la interfaz gráfica de usuario para la sección de categorías.
    /// Incluye funcionalidades para acceder a distintas secciones de la aplicación.
    /// </summary>
    public partial class FrmCategorias : Form
    {
        /// <summary>
        /// <para>Representa el gestor de productos.</para>
        /// </summary>
        private GestorFirestore<Producto> gestorProductos;

        /// <summary>
        /// Constructor por defecto que configura el formulario e inicializa el gestor de productos.
        /// </summary>
        public FrmCategorias()
        {
            InitializeComponent();
            ConfigurarFormulario();

            gestorProductos = new GestorFirestore<Producto>("Productos");
        }

        /// <summary>
        /// Evento de carga del formulario FrmAdministrador. desactiva las opciones de maximizar, minimizar y cerrar, activa el scroll.
        /// </summary>
        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;

            flpProductos.AutoScroll = true;
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
        }

        #region Métodos para mostrar los productos

        /// <summary>
        /// Muestra los productos de la categoría "Memorias" en el FlowLayoutPanel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnMemorias_Click(object sender, EventArgs e)
        {
            var productos = await gestorProductos.ObtenerPorCampoValorAsync("Categoria", "Memorias");
            MostrarProductos(productos);
            Program.Logger.Log("Te interesaron las \"Memorias\"");
        }

        /// <summary>
        /// Muestra los productos de la categoría "Mother" en el FlowLayoutPanel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnMother_Click(object sender, EventArgs e)
        {
            var productos = await gestorProductos.ObtenerPorCampoValorAsync("Categoria", "Mother");
            MostrarProductos(productos);
            Program.Logger.Log("Te interesaron los \"Mother\"");
        }

        /// <summary>
        /// Muestra los productos de la categoría "Graficas" en el FlowLayoutPanel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnGraficas_Click(object sender, EventArgs e)
        {
            var productos = await gestorProductos.ObtenerPorCampoValorAsync("Categoria", "Graficas");
            MostrarProductos(productos);
            Program.Logger.Log("Te interesaron las \"Graficas\"");
        }

        /// <summary>
        /// Muestra los productos de la categoría "Perifericos" en el FlowLayoutPanel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnPerifericos_Click(object sender, EventArgs e)
        {
            var productos = await gestorProductos.ObtenerPorCampoValorAsync("Categoria", "Periferico");
            MostrarProductos(productos);
            Program.Logger.Log("Te interesaron los \"Perifericos\"");
        }

        /// <summary>
        /// Muestra los productos de la categoría "Almacenamiento" en el FlowLayoutPanel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAlmacenamiento_Click(object sender, EventArgs e)
        {
            var productos = await gestorProductos.ObtenerPorCampoValorAsync("Categoria", "Almacenamiento");
            MostrarProductos(productos);
            Program.Logger.Log("Te interesaron los \"Discos\"");
        }

        private async void btnProcesadores_Click(object sender, EventArgs e)
        {
            var productos = await gestorProductos.ObtenerPorCampoValorAsync("Categoria", "Procesador");
            MostrarProductos(productos);
            Program.Logger.Log("Te interesaron los \"Procesadores\"");
        }

        /// <summary>
        /// Muestra los productos de la categoría "Gabinetes" en el FlowLayoutPanel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnGabinetes_Click(object sender, EventArgs e)
        {
            var productos = await gestorProductos.ObtenerPorCampoValorAsync("Categoria", "Gabinete");
            MostrarProductos(productos);
            Program.Logger.Log("Te interesaron los \"Gabinetes\"");
        }

        /// <summary>
        /// Muestra los productos de la categoría "Fuentes" en el FlowLayoutPanel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            var productos = await gestorProductos.ObtenerTodos();
            MostrarProductos(productos);
            Program.Logger.Log("Buscaste todos los Productos");
        }

        /// <summary>
        /// Muestra los productos en el panel de productos.
        /// </summary>
        /// <param name="productos"\>Productos a mostrar.</param>
        public void MostrarProductos(List<Producto> productos)
        {
            flpProductos.Controls.Clear();

            foreach (var producto in productos)
            {
                var panel = CrearPanelProducto(producto);
                flpProductos.Controls.Add(panel);
            }
        }
        #endregion

        #region Creacion de Componentes

        /// <summary>
        /// Crea un PictureBox con la imagen del producto.
        /// </summary>
        /// <param name="producto">Producto del cual se obtendrá la imagen.</param>
        /// <returns>PictureBox con la imagen del producto.</returns>
        private Panel CrearPanelProducto(Producto producto)
        {
            var panel = new Panel { Width = 200, Height = 300 };
            var picture = CrearPictureBoxProducto(producto);
            var labelNombre = CrearLabelNombreProducto(producto);
            var labelPrecio = CrearLabelPrecioProducto(producto);
            var button = CrearBotonAgregarAlCarrito(producto);

            panel.Controls.Add(picture);
            panel.Controls.Add(labelNombre);
            panel.Controls.Add(labelPrecio);
            panel.Controls.Add(button);

            return panel;
        }

        /// <summary>
        /// Crear un botón para agregar el producto al carrito.
        /// </summary>
        /// <param name="producto">Producto a agregar al carrito.</param>
        /// <returns>Botón para agregar el producto al carrito.</returns>
        private PictureBox CrearPictureBoxProducto(Producto producto)
        {
            var picture = new PictureBox
            {
                Width = 150,
                Height = 150,
                Location = new Point(25, 10)
            };

            string imageUrl;

            if (!string.IsNullOrEmpty(producto.ImageUri))
            {
                imageUrl = producto.ImageUri;
            }
            else
            {
                // manejar el caso en que "ImagenUri" no está en el producto
                imageUrl = "C:\\Users\\irlid\\Desktop\\titulo.jpg";
            }

            try
            {
                picture.Load(imageUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }

            return picture;
        }

        /// <summary>
        /// Crear un label con el nombre del producto.
        /// </summary>
        /// <param name="producto">Producto del cual se obtendrá el nombre.</param>
        /// <returns>Label con el nombre del producto.</returns>
        private Label CrearLabelNombreProducto(Producto producto)
        {
            var nombre = producto.Nombre;
            var labelNombre = new Label
            {
                Text = nombre,
                ForeColor = Color.White,
                Location = new Point(75, 170),
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };

            return labelNombre;
        }

        /// <summary>
        /// Crear un label con el precio del producto.
        /// </summary>
        /// <param name="producto">Producto del cual se obtendrá el precio.</param>
        /// <returns>Label con el precio del producto.</returns>
        private Label CrearLabelPrecioProducto(Producto producto)
        {
            var precio = producto.Precio;
            var labelPrecio = new Label
            {
                Text = precio + " $",
                ForeColor = Color.White,
                Location = new Point(75, 190),
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };

            return labelPrecio;
        }

        /// <summary>
        /// Crear un botón para agregar el producto al carrito.
        /// </summary>
        /// <param name="producto">Producto a agregar al carrito.</param>
        /// <returns>Botón para agregar el producto al carrito.</returns>
        private Button CrearBotonAgregarAlCarrito(Producto producto)
        {
            var button = new Button
            {
                Text = "Agregar al carrito",
                //BackColor = Color.FromArgb(20, 18, 18),
                BackColor = Color.Gray,
                ForeColor = Color.FromArgb(20, 25, 25),
                Location = new Point(25, 230),
                Width = 150,
                Height = 70,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };

            button.Click += (s, e) =>
            {
                AgregarAlCarrito(producto);
                Program.Logger.Log("Agregaste al carrito el producto: " + producto.Nombre);
            };

            return button;
        }
        #endregion

        #region Metodos varios
        /// <summary>
        /// Agregar un producto al carrito.
        /// </summary>
        /// <param name="producto">Producto a agregar al carrito.</param>
        private void AgregarAlCarrito(Producto producto)
        {
            CarritoDeCompras.AgregarAlCarrito(producto);
        }

        #endregion

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnMemorias_MouseEnter(object sender, EventArgs e)
        {
            btnMemorias.IconSize = 42;
        }
        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnMemorias_MouseLeave(object sender, EventArgs e)
        {
            btnMemorias.IconSize = 35;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGraficas_MouseEnter(object sender, EventArgs e)
        {
            btnGraficas.IconSize = 42;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGraficas_MouseLeave(object sender, EventArgs e)
        {
            btnGraficas.IconSize = 35;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnPerifericos_MouseEnter(object sender, EventArgs e)
        {
            btnPerifericos.IconSize = 42;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnPerifericos_MouseLeave(object sender, EventArgs e)
        {
            btnPerifericos.IconSize = 35;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnAlmacenamiento_MouseEnter(object sender, EventArgs e)
        {
            btnAlmacenamiento.IconSize = 42;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnAlmacenamiento_MouseLeave(object sender, EventArgs e)
        {
            btnAlmacenamiento.IconSize = 35;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnMother_MouseEnter(object sender, EventArgs e)
        {
            btnMother.IconSize = 42;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnMother_MouseLeave(object sender, EventArgs e)
        {
            btnMother.IconSize = 35;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnProcesadores_MouseEnter(object sender, EventArgs e)
        {
            btnProcesadores.IconSize = 42;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnProcesadores_MouseLeave(object sender, EventArgs e)
        {
            btnProcesadores.IconSize = 35;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGabinetes_MouseEnter(object sender, EventArgs e)
        {
            btnGabinetes.IconSize = 42;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnGabinetes_MouseLeave(object sender, EventArgs e)
        {
            btnGabinetes.IconSize = 35;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnMostrarTodo_MouseEnter(object sender, EventArgs e)
        {
            btnMostrarTodo.IconSize = 42;
        }

        /// <summary>
        /// EVENTO DE MOUSE: Cambia el tamaño del ícono del botón cuando el mouse entra o sale del botón.
        /// </summary>
        private void btnMostrarTodo_MouseLeave(object sender, EventArgs e)
        {
            btnMostrarTodo.IconSize = 35;
        }
    }
}
