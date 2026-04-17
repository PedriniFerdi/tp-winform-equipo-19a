using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public int Agregar(Articulo articulo)
        {
            var db = new AccesoDatos();
            try
            {
                db.setearConsulta(
                    """
                    INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)
                    VALUES (@codigo, @nombre, @desc, @idMarca, @idCategoria, @precio);
                    SELECT CAST(SCOPE_IDENTITY() AS int);
                    """);

                db.agregarParametro("@codigo", articulo.CodigoArticulo);
                db.agregarParametro("@nombre", articulo.Nombre);
                db.agregarParametro("@desc", articulo.Descripcion);
                db.agregarParametro("@idMarca", articulo.Marca.Id);
                db.agregarParametro("@idCategoria", articulo.Categoria.Id);
                db.agregarParametro("@precio", articulo.Precio);

                return db.insertarYobtenerId();
            }
            finally
            {
                db.cerrarConexion();
            }
        }

        public void Modificar(Articulo articulo)
        {
            var db = new AccesoDatos();
            try
            {
                db.setearConsulta(
                    """
                    UPDATE ARTICULOS
                    SET Codigo = @codigo,
                        Nombre = @nombre,
                        Descripcion = @desc,
                        IdMarca = @idMarca,
                        IdCategoria = @idCategoria,
                        Precio = @precio
                    WHERE Id = @id
                    """);

                db.agregarParametro("@codigo", articulo.CodigoArticulo);
                db.agregarParametro("@nombre", articulo.Nombre);
                db.agregarParametro("@desc", articulo.Descripcion);
                db.agregarParametro("@idMarca", articulo.Marca.Id);
                db.agregarParametro("@idCategoria", articulo.Categoria.Id);
                db.agregarParametro("@precio", articulo.Precio);
                db.agregarParametro("@id", articulo.Id);

                db.ejecutarAccion();
            }
            finally
            {
                db.cerrarConexion();
            }
        }
    }
}
