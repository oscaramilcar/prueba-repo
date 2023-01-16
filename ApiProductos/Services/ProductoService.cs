using ApiProductos.Models;

namespace ApiProductos.Services
{
    public class ProductoService : IProductoService
    {
        public IEnumerable<Producto> allProducts => new List<Producto>()
        {
            new Producto{ Id = 1, Nombre = "Prod_A", Precio = 20.50M },
            new Producto{ Id = 2, Nombre = "Prod_B", Precio = 45.60M },
            new Producto{ Id = 3, Nombre = "Prod_C", Precio = 12.30M }
        };
    }
}
