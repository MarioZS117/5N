public class SeguridadService : Iseguridad
{
    public string Login(LoginUsuario loginUsuario)
    {
        using (var conexion = new BDBiblioteca())
        {
            var consulta = (from c in conexion.Usuarios
                            where
            c.Usuario == loginUsuario.Usuario && c.Password == loginUsuario.password
                            select c).FirstOrDefault();
            if (consulta != null)
            {
                return $"Conexion Satisfactoria";
            }
            else
            {
                return $"Error de usuario o contraseña";
            }
        }
    }
}
