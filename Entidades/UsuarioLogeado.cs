namespace Entidades;

public class UsuarioLogeado
{
    private static UsuarioLogeado _instancia;
    private Usuario _usuario;

    /// <summary>
    /// Obtiene la única instancia de UsuarioLogeado. Si no existe, crea una nueva.
    /// </summary>
    public static UsuarioLogeado ObtenerInstancia()
    {
        if (_instancia == null)
        {
            _instancia = new UsuarioLogeado();
        }
        return _instancia;
    }

    /// <summary>
    /// Establece el usuario de la instancia de UsuarioLogeado.
    /// </summary>
    /// <param name="usuario">Usuario a establecer</param>
    public void SetUsuario(Usuario usuario)
    {
        _usuario = usuario;
    }

    /// <summary>
    /// Obtiene el usuario de la instancia de UsuarioLogeado.
    /// </summary>
    public Usuario GetUsuario()
    {
        return _usuario;
    }

    /// <summary>
    /// Constructor privado para evitar que se instancie desde fuera de la clase
    /// </summary>
    private UsuarioLogeado()
    {

    }
}
