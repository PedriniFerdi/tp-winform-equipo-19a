using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    public class ArticuloService
    {
        public void modificar(Articulo articulo)
        {
            AccesoDatos _accesoDatos = new AccesoDatos();
            try
            {
                _accesoDatos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @desc, IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio WHERE Id = @id");


                _accesoDatos.setearParametro("@codigo", articulo.CodigoArticulo);
                _accesoDatos.setearParametro("@nombre", articulo.Nombre);
                _accesoDatos.setearParametro("@desc", articulo.Descripcion);

                _accesoDatos.setearParametro("@idCategoria", articulo.Categoria.Id);
                _accesoDatos.setearParametro("@precio", articulo.Precio);
                //_accesoDatos.setearParametro("@idMarca", articulo.Marca.Id); (falta clase marca)
                _accesoDatos.setearParametro("@id", articulo.Id);

                _accesoDatos.ejecutarAccion();
            }

            catch (Exception ex) { throw; }
            finally
            {
                _accesoDatos.cerrarConexion();
            }
        }
    }
}
