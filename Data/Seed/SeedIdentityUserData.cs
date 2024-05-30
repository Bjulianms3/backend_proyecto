using tw.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace tw.Data.Seed;

public static class SeedIdentityUserData{
    
    public static void SeedUserIdentityData(this ModelBuilder modelBuilder){

        string AdministradorRoleId = Guid.NewGuid().ToString();
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
        Id = AdministradorRoleId,
        Name = "Administrador",
        NormalizedName = "Administrador".ToUpper()
    });

    string UsuarioRoleId = Guid.NewGuid().ToString();
    modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
    {
        Id= UsuarioRoleId,
        Name = "Usuario",
        NormalizedName= "Usuario".ToUpper()
    });

    var UsuarioId = Guid.NewGuid().ToString();
    modelBuilder.Entity<CustomIdentityUser>().HasData(
        new CustomIdentityUser{
            Id = UsuarioId,
            UserName = "zS20018182@estudiantes.uv.mx",
            Email = "zS20018182@estudiantes.uv.mx",
            NormalizedEmail = "zS20018182@estudiantes.uv.mx".ToUpper(),
            Nombre = "Bernardo julian marin sanchez",
            NormalizedUserName = "zS20018182@estudiantes.uv.mx".ToUpper(),
            PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null!, "juli"),
            Protegido = true
        }
    );

    modelBuilder.Entity<IdentityUserRole<string>>().HasData(
        new IdentityUserRole<string>
        {
            RoleId = AdministradorRoleId,
            UserId = UsuarioId
        }
    );

    UsuarioId = Guid.NewGuid().ToString();
    modelBuilder.Entity<CustomIdentityUser>().HasData(
        new CustomIdentityUser
        {
            Id = UsuarioId,
            UserName = "bernardojulianmarinsanchez0@gmail.com",
            Email = "bernardojulianmarinsanchez0@gmail.com",
            NormalizedEmail = "bernardojulianmarinsanchez0@gmail.com".ToUpper(),
            Nombre = "usuario juli",
            NormalizedUserName = "bernardojulianmarinsanchez0@gmail.com".ToUpper(),
            PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null!, "juli"),
        }
    );

    modelBuilder.Entity<IdentityUserRole<string>>().HasData(
        new IdentityUserRole<string>
        {
            RoleId= UsuarioRoleId,
            UserId = UsuarioId
        }
    );
}

}