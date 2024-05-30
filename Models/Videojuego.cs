namespace tw.Models;

public class Videojuego{
    public int VideojuegoId {get; set; }

    public string Titulo {get; set;} = "sin titulo";

    public string Descripcion {get; set;} = "sin descripcion";

    public int Anio {get; set;}

    public string Poster {get; set;} = "N/A";

    public ICollection<Categoria>? Categorias {get; set;}
}