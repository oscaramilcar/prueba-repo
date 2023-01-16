using ApiUsuarios.Models;

namespace ApiUsuarios.Services
{
    public interface IUsuarioService
    {
        IEnumerable<Usuario> GetUsuarios { get; }
        Usuario? ValidarCredenciales(String nombreUsuario, string password);

        string ObtenerRolesUsuario(Usuario usuario);
    }
}
