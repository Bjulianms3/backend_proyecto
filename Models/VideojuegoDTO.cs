namespace tw.Models;

public class VideojuegoDTO{
    public int? VideojuegoId {get; set;}

    public required string Titulo {get; set;}

    public string Descripcion {get; set;} ="sin descripcion";

    public int Anio {get; set;}

    public string Poster {get; set;} ="N/A";

    public int[]? Categorias {get; set;}
}