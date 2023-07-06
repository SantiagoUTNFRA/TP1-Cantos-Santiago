using Google.Cloud.Firestore;

namespace Entidades
{
    [FirestoreData]
    public class Usuario
    {
        /// <summary>
        /// Obtiene o establece el nombre de usuario.
        /// </summary>
        [FirestoreProperty]
        public string NombreDeUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece la contraseña del usuario.
        /// </summary>
        [FirestoreProperty]
        public string Contrasenia { get; set; }

        /// <summary>
        /// Obtiene o establece el DNI del usuario.
        /// </summary>
        [FirestoreProperty]
        public long Dni { get;set; }

        /// <summary>
        /// Constructor que inicializa un nuevo usuario por parametro
        /// </summary>
        /// <param name="nombreUsuario">Nombre de usuario</param>
        /// <param name="contrasenia">Contraseña</param>
        /// <param name="dni">DNI</param>
        public Usuario(string nombreUsuario, string contrasenia, long dni)
        {
            NombreDeUsuario = nombreUsuario;
            Contrasenia = contrasenia;
            Dni = dni;
        }

        public Usuario() 
        { 

        }

    }
}
