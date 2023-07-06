using Google.Cloud.Firestore;

namespace Productos
{
    public class Producto
    {
        [FirestoreProperty]
        public int Id { get; set; }
        [FirestoreProperty]
        public string Nombre { get; set; }
        [FirestoreProperty]
        public double Precio { get; set; }
        [FirestoreProperty]
        public int Stock { get; set; }
        [FirestoreProperty]
        public string Categoria { get; set; }
        [FirestoreProperty]
        public string ImageUri { get; set; }

    }
}