using Entidades;
using Gestores;

namespace UI_ByteBay.Forms
{
    public partial class FrmMiCarrito : Form
    {
        public FrmMiCarrito()
        {
            InitializeComponent();
            ConfigurarFormulario();

            CarritoDeCompras.CarritoCambiado += MostrarProductosEnCarrito;
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

            flpProductosCarrito.AutoScroll = true;
            flpProductosCarrito.FlowDirection = FlowDirection.LeftToRight;
            flpProductosCarrito.WrapContents = true;
        }

        private void FrmMiCarrito_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;

            MostrarProductosEnCarrito();
        }

        private Panel CrearPanelProducto(Producto producto)
        {
            // Cambiamos el diseño del panel para que sea más atractivo
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

        private Button CrearBotonEliminarProducto(Producto producto)
        {
            var button = new Button
            {
                Text = "Eliminar",
                BackColor = Color.Red,
                ForeColor = Color.White,
                Width = 115,  // Ajustamos el ancho del botón
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
