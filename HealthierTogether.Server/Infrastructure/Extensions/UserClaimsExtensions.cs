using System.Security.Claims;

namespace HealthierTogether.Server.Infrastructure.Extensions
{
    public static class UserClaimsExtensions
    {
        public static string GetIdentifier(this ClaimsPrincipal user)
            => user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    }
}
