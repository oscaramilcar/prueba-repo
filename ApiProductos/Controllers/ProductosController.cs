using ApiUsuarios.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProductos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IUsuarioRoleService _usuarioRoleService;

        public ProductosController(IUsuarioRoleService usuarioRoleService)
        {
            _usuarioRoleService = usuarioRoleService;
        }
    }
}
