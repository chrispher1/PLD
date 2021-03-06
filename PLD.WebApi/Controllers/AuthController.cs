using Microsoft.AspNetCore.Mvc;
using PLD.Repositories;
using PLD.Models;
using System.Threading.Tasks;
using PLD.DTO;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using System;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using PLD.Repositories.Interface;

namespace PLD.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController:ControllerBase
    {
        private readonly IUserRepository<User> _userRepository ;
        private readonly IConfiguration _config;
        
        public AuthController(IUserRepository<User> userRepository, IConfiguration config)
        {
            _userRepository = userRepository;
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDTO userDTO)
        {
            if (await _userRepository.UserExists(userDTO.Username.ToLower()))
            return BadRequest("UserName already exists.");

            var user = await _userRepository.Register(userDTO.Username.ToLower(), userDTO.Password,
                userDTO.BirthDate, userDTO.FirstName, userDTO.LastName);
            //return Ok(user);
            return Ok(new { token = GenerateToken(user), user
            });
        }

        [AllowAnonymous]
        [HttpGet("login")]
        public async Task<IActionResult> Login([FromQuery] UserForLoginDTO userDTO)
        {
            var user = await _userRepository.LogIn(userDTO.Username.ToLower(),userDTO.Password);

            if( user == null)
            return Unauthorized(); 
            return Ok(new { token = GenerateToken(user), user
            });
        }

        private string GenerateToken(User user) {
            var claims = new[]
            {
                new Claim( ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim("WorkPlace", "Seven Seven Global")
            };            
            
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));
            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            
            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(claims),
                SigningCredentials = credential,
                Expires = DateTime.Now.AddDays(1)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);            
        }

    }
}