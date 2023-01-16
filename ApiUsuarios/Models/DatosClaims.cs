using System.Security.Claims;

namespace ApiUsuarios.Models
{
    public static class DatosClaims
    {
        public static List<Claim> usuario1Claims = new List<Claim>()
        {
            new Claim("user1","Principal")
        };

        public static List<Claim> usuario2Claims = new List<Claim>()
        {
            new Claim("user2","Delegado")
        };
    }
}
