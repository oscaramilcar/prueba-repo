namespace ApiUsuarios.Models
{
    public class UsuarioRole
    {
        public int Id { get; set; }
        public string? Roles { get; set; }
        public List<Usuario>? Usuarios { get; set; }
    }
}
