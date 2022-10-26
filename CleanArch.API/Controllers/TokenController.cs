using CleanArch.API.Models;
using CleanArch.Domain.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IAutenthicate _authenticate;
        private readonly IConfiguration _configuration;

        public TokenController(IAutenthicate authenticate, IConfiguration configuration)
        {
            _authenticate = authenticate ?? throw new ArgumentNullException(nameof(authenticate));
            _configuration = configuration;
        }

        [HttpPost("LoginUser")]
        public async Task<ActionResult<UserToken>> Login([FromBody] LoginModel userInfo)
        {
            var result = await _authenticate.Authenticate(userInfo.Email, userInfo.Password);

            if (!result)
                return GenerateToken(userInfo);
               // return Ok($"User { userInfo.Email} login sucesses");
            else
            {
                ModelState.AddModelError(string.Empty, "invalid login");
                return BadRequest();
            }
        }

        private UserToken GenerateToken(LoginModel userInfo)
        {

            var claims = new[]
            {
              new Claim("email", userInfo.Email),
              new Claim("meuValor", "oque quiser"),
              new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var privatekey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));

            var crendetials = new SigningCredentials(privatekey, SecurityAlgorithms.HmacSha256);

            var expiration = DateTime.UtcNow.AddMinutes(10);

            JwtSecurityToken token = new JwtSecurityToken(
                 issuer: _configuration["JWT:Issuer"],
                 audience: _configuration["JWt:Audience"],
                 claims: claims,
                 expires: expiration,
                 signingCredentials:crendetials
                );

            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };

        }
    }
}
