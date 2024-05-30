using Microsoft.AspNetCore.Identity;

namespace tw.Models;

public class CustomIdentityUser : IdentityUser{
    public required string Nombre { get; set;}

    public bool Protegido { get; set; } = false;
}