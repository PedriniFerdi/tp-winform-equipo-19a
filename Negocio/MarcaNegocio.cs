using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> Listar()
        {
            var lista = new List<Marca>();
            var db = new AccesoDatos();
            try
            {
                db.setearConsulta("SELECT Id, Descripcion FROM MARCAS ORDER BY Descripcion");
                db.ejecutarLectura();
                while (db.Lector.Read())
                {
                    lista.Add(new Marca
                    {
                        Id = Convert.ToInt32(db.Lector["Id"]),
                        Descripcion = db.Lector["Descripcion"] is DBNull
                            ? string.Empty
                            : Convert.ToString(db.Lector["Descripcion"]) ?? string.Empty
                    });
                }
                return lista;
            }
            finally
            {
                db.cerrarConexion();
            }
        }
    }
}
