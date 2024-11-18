using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/Libros")]

public class LibrosController:ControllerBase{
    readonly ILibro _libro;
    public LibrosController(ILibro libro){
        _libro = libro;
    }
    [HttpPost("GuardarLibros")]
    public IActionResult GuadarLibros(PuntoVenta.Models.Response.Libros libros){
        var consulta = _libro.GuardarLibro(libros);
        return Ok(consulta);
    }
}