using Entidades;
using Gestores;

namespace UI_ByteBay.Forms
{
    /// <summary>
    /// Representa la interfaz gráfica de usuario (GUI) para mostrar los productos en el carrito de compras.
    /// </summary>
    public partial class FrmMiCarrito : Form
    {
        public FrmMiCarrito()
        {
            InitializeComponent();
            ConfigurarFormulario();

            CarritoDeCompras.CarritoCambiado += MostrarProductosEnCarrito;
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

            flpProductosCarrito.AutoScroll = true;
            flpProductosCarrito.FlowDirection = FlowDirection.LeftToRight;
            flpProductosCarrito.WrapContents = true;
        }

        /// <summary>
        /// Se ejecuta cuando se carga el formulario y muestra los productos en el carrito.
        /// </summary>
        private void FrmMiCarrito_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;

            MostrarProductosEnCarrito();
        }

        /// <summary>
        /// Crea un Panel que representa a un Producto para mostrar en la UI.
        /// </summary>
        /// <param name="producto">Producto a mostrar.</param>
        /// <returns>Panel con la información del producto.</returns>
        private Panel CrearPanelProducto(Producto producto)
        {
            var panel = new Panel { Width = 195, Height = 270, BorderStyle = BorderStyle.Fixed3D, Margin = new Padding(10) };

            var picture = CrearPictureBoxProducto(producto);
            picture.Location = new Point(10, 30); // Movemos la imagen hacia abajo

            var labelNombre = CrearLabelNombreProducto(producto);
            labelNombre.Location = new Point(15, 10); // Movemos el nombre hacia arriba

            var labelPrecio = CrearLabelPrecioProducto(producto);
            labelPrecio.Location = new Point(40, 200); // Movemos el precio hacia abajo

            var buttonEliminar = CrearBotonEliminarProducto(producto);
            buttonEliminar.Location = new Point(30, 235); // Movemos el botón hacia abajo

            panel.Controls.Add(picture);
            panel.Controls.Add(labelNombre);
            panel.Controls.Add(labelPrecio);
            panel.Controls.Add(buttonEliminar);

            return panel;
        }

        /// <summary>
        /// Crea un PictureBox para mostrar la imagen de un producto.
        /// </summary>
        /// <param name="producto">Producto a mostrar.</param>
        /// <returns>PictureBox con la imagen del producto.</returns>
        private PictureBox CrearPictureBoxProducto(Producto producto)
        {
            var picture = new PictureBox
            {
                Width = 150,
                Height = 150,
                Location = new Point(25, 10),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            if (!string.IsNullOrEmpty(producto.ImageUri))
            {
                picture.ImageLocation = producto.ImageUri;
            }
            else
            {
                picture.Image = Image.FromFile("C:\\Users\\irlid\\Desktop\\titulo.jpg");
            }

            return picture;
        }

        /// <summary>
        /// Crea un Label para mostrar el nombre de un producto.
        /// </summary>
        /// <param name="producto">Producto a mostrar.</param>
        /// <returns>Label con el nombre del producto.</returns>
        private Label CrearLabelNombreProducto(Producto producto)
        {
            var nombre = producto.Nombre;
            var labelNombre = new Label
            {
                Text = nombre,
                ForeColor = Color.White,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };

            return labelNombre;
        }

        /// <summary>
        /// Crea un Label para mostrar el precio de un producto.
        /// </summary>
        /// <param name="producto">Producto a mostrar.</param>
        /// <returns>Label con el precio del producto.</returns>
        private Label CrearLabelPrecioProducto(Producto producto)
        {
            var precio = producto.Precio;
            var labelPrecio = new Label
            {
                Text = precio.ToString("C"),
                ForeColor = Color.White,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };

            return labelPrecio;
        }

        /// <summary>
        /// Crea un Button para permitir al usuario eliminar un producto del carrito.
        /// </summary>
        /// <param name="producto">Producto a eliminar.</param>
        /// <returns>Button para eliminar el producto.</returns>
        private Button CrearBotonEliminarProducto(Producto producto)
        {
            var button = new Button
            {
                Text = "Eliminar",
                BackColor = Color.Red,
                ForeColor = Color.White,
                Width = 115,  
                Height = 30,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };

            button.Margin = new Padding(0, 10, 0, 0);

            button.Click += (s, e) =>
            {
                CarritoDeCompras.QuitarDelCarrito(producto);
                Program.Logger.Log($"El usuario eliminó el producto {producto.Nombre} del carrito.");
            };

            return button;
        }

        /// <summary>
        /// Muestra los productos en el carrito en la interfaz de usuario.
        /// </summary>
        public void MostrarProductosEnCarrito()
        {
            double total = 0.0;
            flpProductosCarrito.Controls.Clear();

            var productosEnCarrito = CarritoDeCompras.Productos;

            foreach (var producto in productosEnCarrito)
            {
                var panel = CrearPanelProducto(producto);
                flpProductosCarrito.Controls.Add(panel);
                total += producto.Precio;
            }

            lblTotal.Text = $"Total: {total} $";
        }

        /// <summary>
        /// Realiza el proceso de pago del carrito actual y muestra el resultado al usuario.
        /// </summary>
        private async void btnPagar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea realizar el pago?", "Confirmar pago", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Program.Logger.Log("El usuario confirmó la compra.");

                var gestorProducto = new GestorProducto();
                var gestorCompra = new GestorCompra(gestorProducto);

                var result = await gestorCompra.ConfirmarCompraAsync();

                if (result)
                {
                    MessageBox.Show("La compra se realizó con éxito.");
                    Program.Logger.Log("Compra realizada con éxito.");
                }
                else
                {
                    MessageBox.Show("Hubo un problema al realizar la compra.");
                    Program.Logger.Log("Hubo un problema al realizar la compra.");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                Program.Logger.Log("El usuario canceló la compra.");
                return;
            }
        }


    }
}
