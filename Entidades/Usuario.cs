using Google.Cloud.Firestore;

namespace Entidades
{
    [FirestoreData]
    public class Usuario
    {
        public Usuario() { }

        [FirestoreProperty]
        public string NombreDeUsuario { get; set; }

        [FirestoreProperty]
        public string Contrasenia { get; set; }

        [FirestoreProperty]
        public long Dni { get;set; }

        public Usuario(string nombreUsuario, string contrasenia, long dni)
        {
            NombreDeUsuario = nombreUsuario;
            Contrasenia = contrasenia;
            Dni = dni;
        }
    }
}
