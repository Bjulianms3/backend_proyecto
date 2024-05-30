using System.Text.Json.Serialization;

namespace tw.Models;

public class Categoria{
    public int CategoriaId {get; set;}

    public required string Nombre { get; set;}

    public bool Protegida {get; set;} = false;

    [JsonIgnore]

    public ICollection<Videojuego>? Videojuegos {get; set;}
}