using Entidades;
using Firestore;
using System.Windows;

namespace Gestores
{
    public class GestorUsuario : GestorFirestore<Usuario>
    {
        /// <summary>
        /// Actualiza un usuario existente en la base de datos.
        /// </summary>
        /// <param name="usuario">Objeto usuario a ser actualizado.</param>
        /// <param name="id">Identificador del usuario.</param>
        /// <returns></returns>
        public async Task ActualizarUsuario(Usuario usuario, string id) => await Actualizar(usuario, id);

        /// <summary>
        /// Elimina un usuario de la base de datos por su ID.
        /// </summary>
        /// <param name="id">Identificador del usuario.</param>
        /// <returns>Tarea que representa la operación asíncrona.</returns>
        public async Task EliminarUsuario(string id) => await Eliminar(id);

        /// <summary>
        /// Obtiene un usuario de la base de datos por su ID.
        /// </summary>
        /// <param name="id">Identificador del usuario.</param>
        /// <returns>Objeto usuario obtenido.</returns>
        public async Task<Usuario> ObtenerUsuario(string id) => await Obtener(id);

        /// <summary>
        /// Obtiene todos los usuarios de la base de datos.
        /// </summary>
        /// <returns>Lista de usuarios obtenidos.</returns>
        public async Task<List<Usuario>> ObtenerUsuarios() => await ObtenerTodos();

        /// <summary>
        /// Verifica si un usuario existe en la base de datos.
        /// </summary>
        /// <param name="nombreUsuario">El nombre del usuario a verificar.</param>
        /// <returns>True que indica si el usuario existe, false que no.</returns>
        private async Task<bool> ExisteUsuario(string nombreUsuario)
        {
            var usuario = await Obtener(nombreUsuario);
            return usuario != null ? true : false;
        }

        /// <summary>
        /// Crea un nuevo usuario en la base de datos si el nombre de usuario no existe ya.
        /// </summary>
        /// <param name="usuario">Objeto usuario a ser creado en la base de datos.</param>
        /// <returns>Tarea que representa la operación asíncrona, cuyo resultado es un booleano que indica si la operación fue exitosa.</returns>
        /// <exception cref="Exception">Lanza una excepción si el nombre de usuario ya existe.</exception>
        public async Task<bool> CrearUsuario(Usuario usuario)
        {
            if (await ExisteUsuario(usuario.NombreDeUsuario))
            {
                throw new Exception("Ya existe un usuario con ese nombre de usuario.");
            }
           
            await Crear(usuario, usuario.NombreDeUsuario);
            return true;
        }

        /// <summary>
        /// Verifica si las credenciales de usuario son válidas.
        /// </summary>
        /// <param name="nombreUsuario">El nombre del usuario.</param>
        /// <param name="contrasenia">La contraseña del usuario.</param>
        /// <returns>True que indica si las credenciales son válidas, False si no es así</returns>
        public async Task<bool> EsCredencialValidaAsync(string nombreUsuario, string contrasenia)
        {
            if (string.IsNullOrEmpty(nombreUsuario))
            {
                return false;
            }

            var usuario = await Obtener(nombreUsuario);

            if (usuario != null && usuario.NombreDeUsuario == nombreUsuario && usuario.Contrasenia == contrasenia)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public GestorUsuario() : base("Usuarios")
        {
        }
    }
}