using Entidades;

namespace Entidades
{
    public static class CarritoDeCompras
    {
        private static List<Producto> _productos = new List<Producto>();

        /// <summary>
        /// Evento que se invoca cuando se realiza un cambio en el carrito.
        /// </summary>
        public static event Action CarritoCambiado;


        /// <summary>
        /// Obtiene la lista de productos en el carrito.
        /// </summary>
        public static List<Producto> Productos
        {
            get { return _productos; }
        }

        /// <summary>
        /// Agrega un producto al carrito y disparo el evento de cambio.
        /// </summary>
        /// <param name="producto">Producto a agregar en el carrito</param>
        public static void AgregarAlCarrito(Producto producto)
        {
            _productos.Add(producto);
            CarritoCambiado?.Invoke();
        }

        /// <summary>
        /// Quita un producto del carrito y disparo el evento de cambio.
        /// </summary>
        /// <param name="producto">Producto a quitar del carrito</param>
        public static void QuitarDelCarrito(Producto producto)
        {
            _productos.Remove(producto);
            CarritoCambiado?.Invoke();
        }

        /// <summary>
        /// Limpia todos los productos del carrito y disparo el evento de cambio.
        /// </summary>
        public static void LimpiarCarrito()
        {
            _productos.Clear();
            CarritoCambiado?.Invoke();
        }
    }
}