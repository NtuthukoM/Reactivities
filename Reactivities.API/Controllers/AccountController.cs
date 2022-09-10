using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reactivities.API.DTOs;
using Reactivities.API.Services;
using Reactivities.Domain;
using System.Security.Claims;

namespace Reactivities.API.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class AccountController:ControllerBase
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly TokenService tokenService;

        public AccountController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            TokenService tokenService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await userManager.Users.Include(x => x.Photos)
                .FirstOrDefaultAsync(x => x.Email == loginDto.Email);
            if (user == null)
                return Unauthorized();
            var result = await signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            if (result.Succeeded)
            {
                return CreateUser(user);
            }
            return Unauthorized();
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto register)
        {
            if(await userManager.Users.AnyAsync(x => x.Email == register.Email))
            {
                ModelState.AddModelError("Email","Email taken");
                return ValidationProblem();
            }
            if(await userManager.Users.AnyAsync(x => x.UserName == register.Username))
            {
                ModelState.AddModelError("Username", "Username taken");
                return ValidationProblem();
            }

            var user = new AppUser
            {
                Email = register.Email,
                UserName = register.Username,
                DisplayName = register.DisplayName,
            };            
            var result = await userManager.CreateAsync(user, register.Password);
            if (result.Succeeded)
            {
                return CreateUser(user);
            }
            
            return BadRequest("Problem registering user.");
        }
        [Authorize]
        [HttpGet("GetCurrentUser")]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            string email = User.FindFirstValue(ClaimTypes.Email);
            var user = await userManager.Users.Include(x => x.Photos)
                .FirstOrDefaultAsync(x => x.Email == email);
            return CreateUser(user);
        }

        private UserDto CreateUser(AppUser user)
        {
            return new UserDto
            {
                Username = user.UserName,
                DisplayName = user.DisplayName,
                Image = user.Photos?.FirstOrDefault(x => x.IsMain)?.Url,
                Token = tokenService.CreateToken(user)
            };
        }
    }
}
