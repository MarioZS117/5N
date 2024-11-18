using PuntoVenta.Models.Response;

public class ClasificacionesService : IClasificaciones
{
    public object GuardarClasificacion(Clasificaciones clasificaciones)
    {
        using (var conexion = new BDBiblioteca())
        {
            Guid llave = Guid.NewGuid();
            clasificaciones.idClasificacion= llave;
            conexion.Clasificaciones.Add(clasificaciones);
            return conexion.SaveChanges() == 1;
        }
    }
}