using PuntoVenta.Models.Response;

public class PrestamoService : IPrestamo
{
    public object DetallePrestamo(string? busqueda)
    {
        List<Libros> ListaLibros = new List<Libros>();
        using (var conexion = new BDBiblioteca())
        {
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                return "No hay datos";
            }
            else
            {
                // Realiza la consulta uniendo "Libros" con "Copias" y filtrando por el título
               
                var consulta=( from l in conexion.Libros join c in conexion.Copias on l.idLibro equals c.idLibro 
                             where l.Titulo.Contains(busqueda)
                               select new {
                                   l.Titulo,
                                   c.Estado ,
                                   c.Cantidad
                                   }
                               ).ToList();
                                foreach (var item in consulta)
                                   {
                                    Console.WriteLine(item .Titulo);
                                   }
                                   return consulta;

                              

            }
        }
    
    }

    public object GuardarPrestamo(Libros libros, Copias copias)
    {
        return 0;
    }


}
