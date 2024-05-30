using System.Security.Claims;
using tw.Models;
using tw.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace tw.Controllers;

[Route("api/[controller]")]
[ApiController]

public class AuthController(UserManager<CustomIdentityUser> userManager, JwtTokenService jwtTokenService) : Controller
{
    [HttpPost]

    public async Task<IActionResult> PostAsync([FromBody] LoginDTO loginDTO)
    {
        var usuario = await userManager.FindByEmailAsync(loginDTO.Email);

        if (usuario == null || !await userManager.CheckPasswordAsync(usuario, loginDTO.Password))
        {
            return Unauthorized(new { mensaje = "Usuario o contraseña incorrectos" });
        }

        var roles = await userManager.GetRolesAsync(usuario);
        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, usuario.Email!),
            new(ClaimTypes.GivenName, usuario.Nombre),
            new(ClaimTypes.Role, roles.First()),
        };

        var jwt = jwtTokenService.GeneraToken(claims);

        return Ok(new
        {
            usuario.Email,
            usuario.Nombre,
            rol = string.Join(",", roles),
            jwt
        });
    }

    [Authorize]
    [HttpGet("tiempo")]

    public IActionResult GetTiempo()
    {
        string? tiempo = jwtTokenService.TiempoRestanteToken();
        if (tiempo is null)
            return BadRequest();
        return Ok(tiempo);
    }

}