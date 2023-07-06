using Entidades;
using Firestore;
using System.Windows;

namespace Gestores
{
    public class GestorUsuario : GestorFirestore<Usuario>
    {
        public GestorUsuario() : base("Usuarios")
        {
        }

        public async Task ActualizarUsuario(Usuario usuario, string id) => await Actualizar(usuario, id);

        public async Task EliminarUsuario(string id) => await Eliminar(id);

        public async Task<Usuario> ObtenerUsuario(string id) => await Obtener(id);

        public async Task<List<Usuario>> ObtenerUsuarios() => await ObtenerTodos();

        private async Task<bool> ExisteUsuario(string nombreUsuario)
        {
            var usuario = await Obtener(nombreUsuario);
            return usuario != null ? true : false;
        }

        public async Task<bool> CrearUsuario(Usuario usuario)
        {
            if (await ExisteUsuario(usuario.NombreDeUsuario))
            {
                throw new Exception("Ya existe un usuario con ese nombre de usuario.");
            }

            await Crear(usuario, usuario.NombreDeUsuario);
            return true;
        }

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

       
    }
}