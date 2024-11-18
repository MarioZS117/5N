using PuntoVenta.Models.Response;

public interface IPrestamo{
    object DetallePrestamo (string? Consulta);
    object GuardarPrestamo (Libros libros, Copias copias);
}