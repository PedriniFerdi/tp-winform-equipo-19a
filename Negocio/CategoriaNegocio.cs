using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            var lista = new List<Categoria>();
            var db = new AccesoDatos();
            try
            {
                db.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS ORDER BY Descripcion");
                db.ejecutarLectura();
                while (db.Lector.Read())
                {
                    lista.Add(new Categoria(
                        Convert.ToInt32(db.Lector["Id"]),
                        db.Lector["Descripcion"] is DBNull
                            ? string.Empty
                            : Convert.ToString(db.Lector["Descripcion"]) ?? string.Empty));
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
