using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/Prestamos")]

public class PrestamoController:ControllerBase{
    readonly IPrestamo _prestamo;
    //Utilizar la inyección de dependencias
    public PrestamoController(IPrestamo prestamo)
    {
       this._prestamo = prestamo;
    }

    [HttpGet("Revisar Estado")]
    public IActionResult DetallePrestamo(string? consulta){
        var resultado=_prestamo.DetallePrestamo(consulta);
        return Ok(resultado);
    }
}