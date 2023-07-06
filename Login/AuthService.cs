using Gestores;

namespace Login
{
    public class AuthService
    {
        private readonly GestorUsuario _gestorUsuario;

        public AuthService(GestorUsuario gestorUsuario)
        {
            _gestorUsuario = gestorUsuario;
        }

        public async Task<bool> IniciarSesion(string nombreUsuario, string contrasenia)
        {
            return await _gestorUsuario.EsCredencialValidaAsync(nombreUsuario, contrasenia);
        }
    }
}
