using Entidades;
using Firestore;

namespace Gestores
{
    public class GestorProducto : GestorFirestore<Producto>
    {
        public GestorProducto() : base("Productos")
        {
        }

        public async Task ActualizarProducto(Producto producto, string id) => await Actualizar(producto, id);

        public async Task CrearProducto(Producto producto) => await Crear(producto, producto.Nombre);

        public async Task EliminarProducto(string id) => await Eliminar(id.ToLower());

        public async Task<Producto> ObtenerProducto(string id) => await Obtener(id.ToLower());

        public async Task<List<Producto>> ObtenerProductos() => await ObtenerTodos();

        public Task<List<Producto>> ObtenerProductosPorCategoriaAsync(string categoria)
        {
            return ObtenerPorCampoValorAsync<Producto>("Categoria", categoria);
        }

        public async Task DisminuirStockProductoAsync(string id, int cantidad)
        {
            var producto = await Obtener(id.ToLower());
            if (producto != null)
            {
                if (producto.Stock >= cantidad)
                {
                    producto.Stock -= cantidad;
                    await Actualizar(producto, id);
                }
                else
                {
                    throw new Exception("Stock insuficiente para el producto con ID: " + id);
                }
            }
            else
            {
                throw new Exception("Producto no encontrado con ID: " + id);
            }
        }
    }
}
