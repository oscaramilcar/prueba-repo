using ApiUsuarios.Models;
using ApiUsuarios.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiUsuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IUsuarioRoleService _roleService;

        public UsuariosController(IUsuarioService usuarioService, IUsuarioRoleService roleService)
        {
            _usuarioService = usuarioService;
            _roleService = roleService;
        }

        [HttpPost]
        public ActionResult<Usuario> Login(Usuario usuario)
        {
            Usuario? usuario1 = _usuarioService.ValidarCredenciales(usuario.NombreUsuario, usuario.Password);
            if (usuario1 == null)
            {
                return NotFound();
            }
            return Ok(usuario1); 
        }
    }
}
