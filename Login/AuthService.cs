using Gestores;

namespace Login
{
    /// <summary>
    /// Clase que maneja las funciones de autenticación del usuario.
    /// </summary>
    public class AuthService
    {
        private readonly GestorUsuario _gestorUsuario;

        /// <summary>
        /// Constructor que inicializa una nueva instancia de la clase AuthService.
        /// </summary>
        /// <param name="gestorUsuario">El gestor de usuarios a usar para la autenticación.</param>
        public AuthService(GestorUsuario gestorUsuario)
        {
            _gestorUsuario = gestorUsuario;
        }

        /// <summary>
        /// Autentica a un usuario en el sistema.
        /// </summary>
        /// <param name="nombreUsuario">El nombre de usuario.</param>
        /// <param name="contrasenia">La contraseña del usuario.</param>
        /// <returns>True si las credenciales son válidas, false en caso contrario.</returns>
        public async Task<bool> IniciarSesion(string nombreUsuario, string contrasenia)
        {
            return await _gestorUsuario.EsCredencialValidaAsync(nombreUsuario, contrasenia);
        }
    }
}
