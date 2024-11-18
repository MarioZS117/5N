using Microsoft.AspNetCore.Mvc;
using PuntoVenta.Models.Response;

[ApiController]
[Route("api/Clasificaciones")]
public class ClasificacionesController:ControllerBase{
    readonly IClasificaciones _clasificaciones;
    public ClasificacionesController(IClasificaciones clasificaciones){
        this._clasificaciones = clasificaciones;
    }
    [HttpPost("GuadarClasificacion")]
    public IActionResult GuardarClasificacion(PuntoVenta.Models.Response.Clasificaciones clasificaciones){
        var consulta = _clasificaciones.GuardarClasificacion(clasificaciones);
        return Ok(consulta);
    }
}