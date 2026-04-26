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
             public void Agregar(Marca nueva)
        {
            var db = new AccesoDatos();
            try
            {
                db.setearConsulta("INSERT INTO MARCAS (Descripcion) VALUES (@desc)");
                db.setearParametro("@desc", nueva.Descripcion);
                db.ejecutarAccion();
            }
            finally
            {
                db.cerrarConexion();
            }
        }

        public void Modificar(Marca seleccionado)
        {
            var db = new AccesoDatos();
            try
            {
                db.setearConsulta("UPDATE MARCAS SET Descripcion = @desc WHERE Id = @id");
                db.setearParametro("@desc", seleccionado.Descripcion);
                db.setearParametro("@id", seleccionado.Id);
                db.ejecutarAccion();
            }
            finally
            {
                db.cerrarConexion();
            }
        }

        public void Eliminar(int id)
        {
            var db = new AccesoDatos();
            try
            {
                db.setearConsulta("DELETE FROM MARCAS WHERE Id = @id");
                db.setearParametro("@id", id);
                db.ejecutarAccion();
            }
            finally
            {
                db.cerrarConexion();
            }






        }
    }
}
