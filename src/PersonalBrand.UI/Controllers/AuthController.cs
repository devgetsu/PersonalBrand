using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PersonalBrand.Domain.Entities.Auth;
using PersonalBrand.Domain.IdentityModels;

namespace PersonalBrand.UI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController(UserManager<UserModel> userManager) : ControllerBase
    {
        private readonly UserManager<UserModel> _userManager = userManager;

        [HttpPost]
        public async Task<IActionResult> Register(Register registerModel)
        {
            return Ok(registerModel);
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login loginModel)
        {
            return Ok(loginModel);
        }
    }
}
