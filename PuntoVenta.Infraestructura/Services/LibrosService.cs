using PuntoVenta.Models.Response;
public class LibrosService : ILibro
{
    object ILibro.GuardarLibro(Libros libros)
    {

        using (var conexion = new BDBiblioteca())
        {
            Guid llave = Guid.NewGuid();
            libros.idLibro = llave;
            conexion.Libros.Add(libros);
            return conexion.SaveChanges() == 1;

        }
    }
}