using ApiProductos.Models;

namespace ApiProductos.Services
{
    public interface IProductoService
    {
        IEnumerable<Producto> allProducts { get; }
    }
}
