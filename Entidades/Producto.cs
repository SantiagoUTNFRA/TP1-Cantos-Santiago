using Google.Cloud.Firestore;

namespace Entidades
{
    public class Producto
    {
        [FirestoreProperty]
        public string Nombre { get; set; }
        [FirestoreProperty]
        public double Precio { get; set; }
        [FirestoreProperty]
        public int Stock { get; set; }
        [FirestoreProperty]
        public string ImageUri { get; set; }
        [FirestoreProperty]
        public string Categoria { get; set; }

        public Producto()
        {
            // Constructor sin argumentos requerido por Firestore
        }
    }

    
}
