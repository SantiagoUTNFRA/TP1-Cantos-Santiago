using Entidades;

namespace Gestores
{
    public class GestorCompra
    {
        private readonly GestorProducto _gestorProducto;

        public GestorCompra(GestorProducto gestorProducto)
        {
            _gestorProducto = gestorProducto;
        }

        public async Task<bool> ConfirmarCompraAsync()
        {
            var productosEnCarrito = CarritoDeCompras.Productos;
            foreach (var producto in productosEnCarrito)
            {
                await _gestorProducto.DisminuirStockProductoAsync(producto.Nombre, 1);
            }
            CarritoDeCompras.LimpiarCarrito();
            return true;
        }

    }
}
