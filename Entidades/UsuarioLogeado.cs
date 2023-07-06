namespace Entidades;

public class UsuarioLogeado
{
    private static UsuarioLogeado _instancia;
    private Usuario _usuario;

    private UsuarioLogeado()
    {
        // Constructor privado para evitar que se instancie desde fuera de la clase
    }

    public static UsuarioLogeado ObtenerInstancia()
    {
        if (_instancia == null)
        {
            _instancia = new UsuarioLogeado();
        }
        return _instancia;
    }

    public void SetUsuario(Usuario usuario)
    {
        _usuario = usuario;
    }

    public Usuario GetUsuario()
    {
        return _usuario;
    }
}
