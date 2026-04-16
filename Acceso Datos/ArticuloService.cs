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
                //_accesoDatos.setearParametro("@idMarca", articulo.Marca.Id); (falta clase marca)
                _accesoDatos.setearParametro("@idCategoria", articulo.Categoria.Id);
                _accesoDatos.setearParametro("@precio", articulo.Precio);
                _accesoDatos.setearParametro("@id", articulo.Id);
                _accesoDatos.ejecutarAccion();
            }

            catch (Exception ex) { throw; }
            finally
            {
                _accesoDatos.cerrarConexion();
            }
        }

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();
           // ImagenService imagenService = new ImagenService(); falta img service

            try
            {
                accesoDatos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, M.Descripcion Nombre_Marca,C.Descripcion Nombre_Categoria, M.Id Id_Marca, C.Id Id_Categoria, A.Precio FROM ARTICULOS A INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN MARCAS M ON A.IdMarca = M.Id ORDER BY A.Id ASC");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.Id = (int)accesoDatos.Lector["Id"];
                    articulo.CodigoArticulo = (string)accesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)accesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)accesoDatos.Lector["Descripcion"];


                    articulo.Marca = new Marca();
                    //articulo.Marca.Descripcion = (string)accesoDatos.Lector["Nombre_Marca"]; (falta clase marca)
                    //articulo.Marca.Id = (int)accesoDatos.Lector["IdMarca"]; (falta clase marca)


                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = (string)accesoDatos.Lector["Nombre_Categoria"];
                    articulo.Categoria.Id = (int)accesoDatos.Lector["IdCategoria"];

                    articulo.Precio = (decimal)accesoDatos.Lector["Precio"];

                    lista.Add(articulo);
                }

                foreach (var a in lista)
                {
                    //List<Imagen> imagenes = imagenService.listarPorIdArticulo(a.Id);
                    //a.Imagenes = imagenes;
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                accesoDatos.cerrarConexion();

            }
        }
    }
}
