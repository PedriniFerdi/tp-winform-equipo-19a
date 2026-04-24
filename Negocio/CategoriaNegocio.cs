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



        public void agregar(Categoria nueva)
        {
            AccesoDatos db = new AccesoDatos(); 
            try
            {
               
                db.setearConsulta("INSERT INTO CATEGORIAS (Descripcion) VALUES (@desc)");
                db.setearParametro("@desc", nueva.Descripcion);
                db.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.cerrarConexion();
            }

        }


        public void modificar(Categoria seleccionado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("UPDATE CATEGORIAS SET Descripcion = @desc WHERE Id = @id");


                datos.setearParametro("@desc", seleccionado.Descripcion);
                datos.setearParametro("@id", seleccionado.Id);


                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }



        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from CATEGORIAS where Id = @id");

               
                datos.setearParametro("@id", id);

                
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


    }
}
