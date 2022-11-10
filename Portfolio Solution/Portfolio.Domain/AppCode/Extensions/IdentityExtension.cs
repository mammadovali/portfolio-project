using System.Linq;
using System.Security.Claims;

namespace Portfolio.Domain.AppCode.Extensions
{
    public static partial class Extension
    {
        public static string GetPrincipalName(this ClaimsPrincipal principal)
        {
            string name = principal.Claims.FirstOrDefault(c => c.Type.Equals("name"))?.Value;
            string surname = principal.Claims.FirstOrDefault(c => c.Type.Equals("surname"))?.Value;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname))
            {
                return $"{name} {surname}";
            }

            return principal.Claims.FirstOrDefault(c=>c.Type.Equals(ClaimTypes.Email))?.Value;
        }
    }
}
