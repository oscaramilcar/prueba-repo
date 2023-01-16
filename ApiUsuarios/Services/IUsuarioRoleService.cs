using ApiUsuarios.Models;

namespace ApiUsuarios.Services
{
    public interface IUsuarioRoleService
    {
        IEnumerable<UsuarioRole> allRoles { get; }
    }
}
