using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using sample_webapi.Models;
using sample_webapi.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace sample_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel user)
        {
            if (user == null)
            {
                return BadRequest("Invalid Client Request");
            }
            // if user Exist then generate token
            var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, false, false);
            if (result.Succeeded)
            {
                // Code to Generate the token
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MySecucretKey@845"));
                var signInCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                // Payload
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub,"ProductAPIAccessToken"),
                     new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                     new Claim("Email",user.Email)
                };

                var tokenOptions = new JwtSecurityToken(issuer: "http://localhost:3420", audience: "http://localhost:3420",
                    claims: claims, expires: DateTime.Now.AddMinutes(10), signingCredentials: signInCredentials);

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions); //  Generating the token
                return Ok(new { token = tokenString });        


            }
            else
            {
                return Unauthorized();
            }

        }
    }
}
