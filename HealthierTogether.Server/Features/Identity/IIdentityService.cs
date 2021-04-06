namespace HealthierTogether.Server.Features.Identity
{
    using System.Security.Claims;

    public interface IIdentityService
    {
        string GetJwtToken(AppSettings appSettings, ClaimsPrincipal user);
    }
}
