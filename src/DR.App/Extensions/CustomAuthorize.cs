using Microsoft.AspNetCore.Http;
using System.Linq;

namespace DR.App.Extensions
{
    public class CustomAuthorize
    {
        public static bool ValidarClaimsUsuario(HttpContext context, string claimName, string claimValue)
        {
            return context.User.Identity.IsAuthenticated &&
                context.User.Claims.Any(x => x.Type == claimName && x.Value.Contains(claimValue));
        }
    }
}
