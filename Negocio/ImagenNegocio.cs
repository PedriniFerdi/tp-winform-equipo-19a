using Dominio;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> ListarPorIdArticulo(int idArticulo)
        {
            var lista = new List<Imagen>();
            var db = new AccesoDatos();
            try
            {
                db.setearConsulta(
                    "SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = @idArt ORDER BY Id");
                db.agregarParametro("@idArt", idArticulo);
                db.ejecutarLectura();
                while (db.Lector.Read())
                {
                    lista.Add(new Imagen(
                        Convert.ToInt32(db.Lector["Id"]),
                        Convert.ToInt32(db.Lector["IdArticulo"]),
                        db.Lector["ImagenUrl"] is DBNull
                            ? string.Empty
                            : Convert.ToString(db.Lector["ImagenUrl"]) ?? string.Empty));
                }
                return lista;
            }
            finally
            {
                db.cerrarConexion();
            }
        }

        public void AgregarImagen(Imagen imagen, int idArticulo)
        {
            var db = new AccesoDatos();
            try
            {
                db.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArt, @url)");
                db.agregarParametro("@idArt", idArticulo);
                db.agregarParametro("@url", imagen.ImagenUrl ?? string.Empty);
                db.ejecutarAccion();
            }
            finally
            {
                db.cerrarConexion();
            }
        }

        public void EliminarImagen(Imagen imagen, int idArticulo)
        {
            var db = new AccesoDatos();
            try
            {
                db.setearConsulta("DELETE FROM IMAGENES WHERE Id = @id AND IdArticulo = @idArt");
                db.agregarParametro("@id", imagen.Id);
                db.agregarParametro("@idArt", idArticulo);
                db.ejecutarAccion();
            }
            finally
            {
                db.cerrarConexion();
            }
        }
    }
}
