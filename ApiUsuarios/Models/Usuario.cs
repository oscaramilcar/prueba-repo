using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ApiUsuarios.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public ClaimsIdentity identity { get; set; }
        public UsuarioRole UsuarioRole { get; set; } = default!;
    }
}
