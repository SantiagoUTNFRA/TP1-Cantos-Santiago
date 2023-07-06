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

        /// <summary>
        /// Confirma la compra y disminuye el stock de los productos en el carrito.
        /// </summary>
        /// <returns>True si pudo confirmar la compra, False si no</returns>
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
