using Google.Cloud.Firestore;

namespace Usuarios
{
    public class Usuario
    {
        [FirestoreProperty]
        public string NombreUsuario { get; set; }
        [FirestoreProperty]
        public string Contrasenia { get; set; }
        [FirestoreProperty]
        public string Dni { get; set; }
        [FirestoreProperty]
        public bool EsAdmin { get; set; }
    }
}
