using PuntoVenta.Models.Response;

public class AutorService : IAutor
{
    public object GuardarAutor(Autores autores)
    {
        using (var conexion = new BDBiblioteca())
        {
            Guid llave = Guid.NewGuid();
            autores.idAutor = llave;
            conexion.Autores.Add(autores);
            return conexion.SaveChanges() == 1;

        }
    }
}
