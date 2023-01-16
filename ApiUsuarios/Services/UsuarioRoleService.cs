using ApiUsuarios.Models;

namespace ApiUsuarios.Services
{
    public class UsuarioRoleService : IUsuarioRoleService
    {
        public IEnumerable<UsuarioRole> allRoles => new List<UsuarioRole>()
        {
            new UsuarioRole { Id = 1, Roles = "Principal" },
            new UsuarioRole { Id = 2, Roles = "Delegado" }
        };
    }
}
