namespace HealthierTogether.Server.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Options;
    using System.Threading.Tasks;
    using HealthierTogether.Server;
    using HealthierTogether.Server.Models.Identity;
    using HealthierTogether.Server.Data.Models;
    using HealthierTogether.Server.Features.Identity;
    using HealthierTogether.Server.Features;

    public class IdentityController : ApiController
    {
        private readonly UserManager<User> userManager;
        private readonly IIdentityService identityService;
        private readonly AppSettings appSettings;

        public IdentityController(
            UserManager<User> userManager,
            IIdentityService identityService,
            IOptions<AppSettings> appSettings
            )
        {
            this.userManager = userManager;
            this.identityService = identityService;
            this.appSettings = appSettings.Value;
        }

        [HttpPost]
        [Route(nameof(Register))]
        public async Task<IActionResult> Register(RegisterRequestModel registerModel)
        {
            var user = new User
            {
                Email = registerModel.Email,
                UserName = registerModel.UserName,
            };

            var result = await userManager.CreateAsync(user, registerModel.Password);

            if (result.Succeeded)
            {
                return Ok();
            }

            return BadRequest(result.Errors);
        }

        [HttpPost]
        [Route(nameof(Login))]
        public async Task<object> Login(LoginRequestModel loginModel)
        {
            var user = await userManager.FindByNameAsync(loginModel.UserName);
            if (user == null)
            {
                return Unauthorized();
            }

            var isPasswordValid = await userManager.CheckPasswordAsync(user, loginModel.Password);
            if (!isPasswordValid)
            {
                return Unauthorized();
            }

            return new LoginResponseModel()
            {
                Token = this.identityService.GetJwtToken(this.appSettings, this.User),
            };
        }
    }
}

