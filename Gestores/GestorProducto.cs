using Entidades;
using Firestore;

namespace Gestores
{
    public class GestorProducto : GestorFirestore<Producto>
    {
        /// <summary>
        /// no sé. no termine usandolo.-.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task ActualizarProducto(Producto producto, string id) => await Actualizar(producto, id);

        /// <summary>
        /// Crea un nuevo producto en la base de datos.
        /// </summary>
        /// <param name="producto">Objeto producto a ser creado en la base de datos</param>
        /// <returns></returns>
        public async Task CrearProducto(Producto producto) => await Crear(producto, producto.Nombre);

        /// <summary>
        /// Elimina un producto en la base de datos
        /// </summary>
        /// <param name="id">Id del producto a ser eliminado</param>
        /// <returns></returns>
        public async Task EliminarProducto(string id) => await Eliminar(id.ToLower());

        /// <summary>
        /// Obtiene un producto de la base de datos
        /// </summary>
        /// <param name="id">Id del producto a ser obtenido</param>
        /// <returns></returns>
        public async Task<Producto> ObtenerProducto(string id) => await Obtener(id.ToLower());

        /// <summary>
        /// Obtiene todos los productos de la base de datos
        /// </summary>
        /// <returns></returns>
        public async Task<List<Producto>> ObtenerProductos() => await ObtenerTodos();

        /// <summary>
        /// Obtiene todos los productos de la base de datos que coinciden con un valor de campo específico.
        /// </summary>
        /// <param name="categoria">Valor del campo a buscar.</param>
        /// <returns>Lista de productos de la categoría especificada</returns>
        public Task<List<Producto>> ObtenerProductosPorCategoriaAsync(string categoria)
        {
            return ObtenerPorCampoValorAsync<Producto>("Categoria", categoria);
        }

        /// <summary>
        /// Disminuye un producto en la base de datos(propiedad Stock)
        /// </summary>
        /// <param name="id">Id del producto a ser disminuido</param>
        /// <param name="cantidad">Cantidad a disminuir</param>
        /// <returns></returns>
        /// <exception cref="Exception">Lanza una excepción si el stock es insuficiente o el producto no se encuentra.</exception>
        public async Task DisminuirStockProductoAsync(string id, int cantidad)
        {
            var producto = await ObtenerProducto(id.ToLower());
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

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public GestorProducto() : base("Productos")
        {
        }
    }
}
