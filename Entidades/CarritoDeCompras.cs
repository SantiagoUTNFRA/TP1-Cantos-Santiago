using Entidades;

namespace Entidades
{
    public static class CarritoDeCompras
    {
        public static event Action CarritoCambiado;

        private static List<Producto> _productos = new List<Producto>();

        public static List<Producto> Productos
        {
            get { return _productos; }
        }

        public static void AgregarAlCarrito(Producto producto)
        {
            _productos.Add(producto);
            CarritoCambiado?.Invoke();
        }

        public static void QuitarDelCarrito(Producto producto)
        {
            _productos.Remove(producto);
            CarritoCambiado?.Invoke();
        }

        public static void LimpiarCarrito()
        {
            _productos.Clear();
            CarritoCambiado?.Invoke();
        }
    }
}