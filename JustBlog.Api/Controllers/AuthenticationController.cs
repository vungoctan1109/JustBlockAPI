using JustBlog.Entity.Entities;
using JustBlog.Model.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JustBlog.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthenticationController : ControllerBase
{
    private readonly UserManager<ApplicationUser> userManager;
    private readonly IConfiguration configuration;
    private readonly RoleManager<IdentityRole<Guid>> roleManager;
    public AuthenticationController(UserManager<ApplicationUser> userManager, IConfiguration configuration, RoleManager<IdentityRole<Guid>> roleManager)
    {
        this.userManager = userManager;
        this.configuration = configuration;
        this.roleManager = roleManager;
    }

    [HttpPost("Login")]
    public ActionResult Login(UserLogin userLogin)
    {
        ApplicationUser? user = userManager.FindByEmailAsync(userLogin.Username).Result;
        if (user == null)
        {
            return NotFound();
        }
        Task<bool> isUser = userManager.CheckPasswordAsync(user, userLogin.Password);
        if (isUser == null)
        {
            return NotFound();
        }

        string role = userManager.GetRolesAsync(user).Result[0];
        byte[] key = Encoding.ASCII.GetBytes(configuration["Jwt:Key"]);
        string? audience = configuration["Jwt:Audience"];
        string? issuer = configuration["Jwt:Issuer"];
        SecurityTokenDescriptor tokenDescriptor = new()
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, role),
                new Claim(ClaimTypes.Sid, user.Id.ToString())
            }),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature),
            Issuer = issuer,
            Audience = audience,
        };

        JwtSecurityTokenHandler tokenHandler = new();
        SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
        string tokenString = tokenHandler.WriteToken(token);
        return Ok(new { Token = tokenString });

    }

    [HttpPost("Register")]
    public ActionResult Register([FromBody] Register register)
    {
        if (register.Password != register.PasswordConfirm)
        {
            return BadRequest();
        }
        ApplicationUser user = new()
        {
            UserName = register.Email,
            Email = register.Email,
            NormalizedEmail = register.Email.ToUpper(),
            NormalizedUserName = register.Email.ToUpper(),
            SecurityStamp = string.Empty,
            LockoutEnabled = false,

        };
        //roleManager.CreateAsync(new IdentityRole("Admin")).Wait();
        IdentityResult result = userManager.CreateAsync(user, register.Password).Result;
        if (result.Succeeded)
        {
            userManager.AddToRoleAsync(user, "User").Wait();
            return Ok();
        }
        return BadRequest();
    }
}
