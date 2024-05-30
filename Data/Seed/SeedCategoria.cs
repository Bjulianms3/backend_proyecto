using tw.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace tw.Data.Seed;

public class SeedCategoria : IEntityTypeConfiguration<Categoria>{

    public void Configure(EntityTypeBuilder<Categoria> builder){
        builder.HasData(            
            new Categoria {CategoriaId = 1, Nombre = "Disparos", Protegida = true},
            new Categoria {CategoriaId = 2, Nombre = "Aventura", Protegida = true},
            new Categoria {CategoriaId = 3, Nombre = "Deportes", Protegida = true},
            new Categoria {CategoriaId = 4, Nombre = "Terror", Protegida = true},
            new Categoria {CategoriaId = 5, Nombre = "Peleas", Protegida = true}
        );
    }

}