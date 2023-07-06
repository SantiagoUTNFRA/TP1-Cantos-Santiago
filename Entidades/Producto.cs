using Google.Cloud.Firestore;

namespace Entidades
{
    public class Producto
    {
        /// <summary>
        /// Obtiene o establece el nombre del producto.
        /// </summary>
        [FirestoreProperty]
        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece el precio del producto.
        /// </summary>
        [FirestoreProperty]
        public double Precio { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad de stock del producto.
        /// </summary>
        [FirestoreProperty]
        public int Stock { get; set; }

        /// <summary>
        /// Obtiene o establece la URL de la imagen del producto.
        /// </summary>
        [FirestoreProperty]
        public string ImageUri { get; set; }

        /// <summary>
        /// Obtiene o establece la categoría del producto.
        /// </summary>
        [FirestoreProperty]
        public string Categoria { get; set; }

        /// <summary>
        /// No sé, pero el firestore me pedía un constructor si o si, si no no funcionaba xd
        /// </summary>
        public Producto()
        {
        }
    }
}
