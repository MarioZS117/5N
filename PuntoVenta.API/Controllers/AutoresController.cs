using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/Autores")]

public class AutoresController:ControllerBase{
    readonly IAutor  _autores;

    public AutoresController(IAutor autor){
        this._autores = autor;
    }
    [HttpPost("GuardarAutores")]
    public IActionResult GuardarAutor(PuntoVenta.Models.Response.Autores autores){
        var _consulta = _autores.GuardarAutor(autores);
        return Ok(_consulta);
    }
}