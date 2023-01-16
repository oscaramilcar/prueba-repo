using ApiUsuarios.Models;
using System.Security.Claims;

namespace ApiUsuarios.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRoleService _usuarioRoleService = new UsuarioRoleService();

        public IEnumerable<Usuario> GetUsuarios => new List<Usuario>
        {
            new Usuario { Id = 1, NombreUsuario = "user1", Password = "1234", identity = new ClaimsIdentity(DatosClaims.usuario1Claims), UsuarioRole = _usuarioRoleService.allRoles.ToList()[0]},
            new Usuario { Id = 2, NombreUsuario = "user2", Password = "4321", identity = new ClaimsIdentity(DatosClaims.usuario2Claims), UsuarioRole = _usuarioRoleService.allRoles.ToList()[1]}
        };

        public Usuario? ValidarCredenciales(string nombreUsuario, string password)
        {
            return GetUsuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Password == password);
        }

        public string ObtenerRolesUsuario(Usuario usuario)
        {
            UsuarioRole usuarioRole = _usuarioRoleService.allRoles.FirstOrDefault(u => u.Id == usuario.UsuarioRole.Id);
            return usuarioRole.Roles;
        }
    }
}
