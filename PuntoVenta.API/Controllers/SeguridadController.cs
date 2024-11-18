using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/seguridad")]
public class SeguridadController:ControllerBase{
    readonly Iseguridad _seguridad;
    //Utilizar la inyección de dependencias
    public SeguridadController(Iseguridad seguridad)
    {
       _seguridad = seguridad; 
    }

    [HttpPost("Iniciar Sesion")]
    public ActionResult IniciarSesion([FromBody] LoginUsuario login){
        var resultado=_seguridad.Login(login);
        return Ok(resultado);
    }
}