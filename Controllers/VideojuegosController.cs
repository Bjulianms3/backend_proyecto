using System.Data.Common;
using tw.Data;
using tw.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;


namespace tw.Controllers;

[Route("api/[controller]")]
[ApiController]

public class VideojuegosController(IdentityContext context) : Controller{
 /*   private readonly IdentityContext _context;

    public PeliculasController(IdentityContext context){
            _context = context;
    } */

    [HttpGet]
    [Authorize(Roles = "Usuario, Administrador")]


    public async Task<ActionResult<IEnumerable<Videojuego>>> GetVideojuego(string? s){

        if(string.IsNullOrEmpty(s))
            return await context.Videojuego.Include(i => i.Categorias).AsNoTracking().ToListAsync();
        
        return await context.Videojuego.Include(i => i.Categorias).Where(c => c.Titulo.Contains(s)).AsNoTracking().ToListAsync();
    }

    [HttpGet("{id}")]
    [Authorize(Roles = "Usuario, Administrador")]


    public async Task<ActionResult<Videojuego>> GetVideojuego(int id){
        var videojuego = await context.Videojuego.Include(i => i.Categorias).AsNoTracking().FirstOrDefaultAsync(s => s.VideojuegoId == id);

        if(videojuego == null){
            return NotFound();
        }

        return videojuego;
    }

    [HttpPost]
    [Authorize(Roles = "Administrador")]

    public async Task<ActionResult<Videojuego>> PostVideojuego(VideojuegoDTO videojuegoDTO){
        Videojuego videojuego = new(){
            Titulo = videojuegoDTO.Titulo,
            Descripcion = videojuegoDTO.Descripcion,
            Anio = videojuegoDTO.Anio,
            Poster = videojuegoDTO.Poster,
            Categorias = []

        };
/*
        if(peliculaDTO.Categorias != null){
            foreach(var categoriaId in peliculaDTO.Categorias){
                Categoria? categoria = await context.Categoria.FindAsync(categoriaId);
                if(categoria != null)
                pelicula.Categorias.Add(categoria);
            }
        } */

        context.Videojuego.Add(videojuego);
        await context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetVideojuego), new {id = videojuego.VideojuegoId }, videojuego);
    }

    [HttpPut("{id}")]

    public async Task<IActionResult> PutVideojuego(int id, VideojuegoDTO videojuegoDTO){
        if(id != videojuegoDTO.VideojuegoId){
            return BadRequest();
        }

        var videojuego = await context.Videojuego.FirstOrDefaultAsync(s => s.VideojuegoId == id);

        if (videojuego == null){
            return NotFound();
        }

        videojuego.Titulo = videojuegoDTO.Titulo;
        videojuego.Descripcion = videojuegoDTO.Descripcion;
        videojuego.Anio = videojuegoDTO.Anio;
        videojuego.Poster = videojuegoDTO.Poster;
//pelicula.Categorias = [];
        await context.SaveChangesAsync();

   /*     if(peliculaDTO.Categorias != null){
            foreach (var categoriaId in peliculaDTO.Categorias){
                Categoria? categoria = await context.Categoria.FindAsync(categoriaId);
                if(categoria != null)
                pelicula.Categorias.Add(categoria);
            }
        }

        try{
            await context.SaveChangesAsync();
        }catch(DbException ex){
            Console.WriteLine(ex.Message);
            return BadRequest();
        } */

        return NoContent();
    }

    [HttpDelete("{id}")]

    public async Task<IActionResult> DeleteVideojuego(int id){
        var videojuego = await context.Videojuego.FindAsync(id);
        if(videojuego == null){
            return NotFound();
        }

        context.Videojuego.Remove(videojuego);
        await context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPost("{id}/categoria")]

    public async Task<IActionResult> PostCategoriaVideojuego(int id, AsignaCategoriaDTO itemToAdd){
         Categoria? categoria = await context.Categoria.FindAsync(itemToAdd.CategoriaId);
        if (categoria == null) return NotFound();

        var videojuego = await context.Videojuego.Include(i => i.Categorias).FirstOrDefaultAsync(s => s.VideojuegoId == id);
        if (videojuego == null) return NotFound();

        if (videojuego?.Categorias?.FirstOrDefault(categoria) != null)
        {
            videojuego.Categorias.Remove(categoria);
            await context.SaveChangesAsync();
        }

        return NoContent();
    }

    [HttpDelete("{id}/categoria/{categoriaid}")]
    public async Task<IActionResult> DeleteCategoriaVideojuego(int id, int categoriaid)
    {
        Categoria? categoria = await context.Categoria.FindAsync(categoriaid);
        if (categoria == null) return NotFound();

        var videojuego = await context.Videojuego.Include(i => i.Categorias).FirstOrDefaultAsync(s => s.VideojuegoId == id);
        if (videojuego== null) return NotFound();

        if (videojuego?.Categorias?.FirstOrDefault(categoria) != null)
        {
            videojuego.Categorias.Remove(categoria);
            await context.SaveChangesAsync();
        }

        return NoContent();
    }
}