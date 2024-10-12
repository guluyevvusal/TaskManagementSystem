using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagementSystem.Application.DTOs;
using TaskManagementSystem.Application.Interfaces;
using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthControllers : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthControllers(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserDTO userDto)
        {
            // İstifadəçi doğrulamasını burada həyata keçirin
            // Əgər uğurludursa:
            var token = _authService.GenerateToken(new User { Username = userDto.Username });
            return Ok(new { Token = token });
        }
    }
}
