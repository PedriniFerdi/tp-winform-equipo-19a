using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private static void ValidarArticulo(Articulo articulo)
        {
            if (articulo == null)
                throw new Exception("El articulo es obligatorio.");

            if (string.IsNullOrWhiteSpace(articulo.CodigoArticulo))
                throw new Exception("El codigo del articulo es obligatorio.");

            if (string.IsNullOrWhiteSpace(articulo.Nombre))
                throw new Exception("El nombre del articulo es obligatorio.");

            if (string.IsNullOrWhiteSpace(articulo.Descripcion))
                throw new Exception("La descripcion del articulo es obligatoria.");

            if (articulo.Marca == null || articulo.Marca.Id <= 0)
                throw new Exception("Debe seleccionar una marca valida.");

            if (articulo.Categoria == null || articulo.Categoria.Id <= 0)
                throw new Exception("Debe seleccionar una categoria valida.");

            if (articulo.Precio < 0)
                throw new Exception("El precio no puede ser negativo.");

            articulo.CodigoArticulo = articulo.CodigoArticulo.Trim();
            articulo.Nombre = articulo.Nombre.Trim();
            articulo.Descripcion = articulo.Descripcion.Trim();
            articulo.Imagenes ??= new List<Imagen>();
        }

        public int Agregar(Articulo articulo)
        {
            ValidarArticulo(articulo);
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

                int IdArticuloNuevo = db.insertarYobtenerId();

                AgregarImagenesAarticulo(IdArticuloNuevo, articulo);
                return IdArticuloNuevo;
            }
            finally
            {
                db.cerrarConexion();
            }
        }
        private void AgregarImagenesAarticulo(int idArticulo, Articulo articulo)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            try
            {
                foreach (var imagen in articulo.Imagenes)
                {
                    imagenNegocio.AgregarImagen(imagen, idArticulo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Modificar(Articulo articulo)
        {
            ValidarArticulo(articulo);
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
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

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
                    articulo.Marca.Descripcion = (string)accesoDatos.Lector["Nombre_Marca"];
                    articulo.Marca.Id = (int)accesoDatos.Lector["IdMarca"];


                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = (string)accesoDatos.Lector["Nombre_Categoria"];
                    articulo.Categoria.Id = (int)accesoDatos.Lector["IdCategoria"];

                    articulo.Precio = (decimal)accesoDatos.Lector["Precio"];

                    lista.Add(articulo);
                }

                foreach (var a in lista)
                {
                    List<Imagen> imagens = imagenNegocio.ListarPorIdArticulo(a.Id);
                    a.Imagenes = imagens;
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
        public List<Articulo> Fitrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = @"
                SELECT A.Id, Codigo, Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, 
                M.Descripcion AS Nombre_Marca, C.Descripcion AS Nombre_Categoria, 
                A.Precio 
                FROM ARTICULOS A 
                JOIN CATEGORIAS C ON A.IdCategoria = C.Id 
                JOIN MARCAS M ON A.IdMarca = M.Id 
                WHERE 1 = 1 ";

                if (campo == "Codigo")
                {
                    consulta += "AND Codigo = @filtro ";
                }

                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "AND Nombre LIKE @filtro + '%' ";
                            break;
                        case "Termina con":
                            consulta += "AND Nombre LIKE '%' + @filtro ";
                            break;
                        default:
                            consulta += "AND Nombre LIKE '%' + @filtro + '%' ";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "AND A.Descripcion LIKE @filtro + '%' ";
                            break;
                        case "Termina con":
                            consulta += "AND A.Descripcion LIKE '%' + @filtro ";
                            break;
                        default:
                            consulta += "AND A.Descripcion LIKE '%' + @filtro + '%' ";
                            break;
                    }
                }

                consulta += "ORDER BY A.Id ASC";

                datos.setearConsulta(consulta);
                datos.agregarParametro("@filtro", filtro);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo
                    {
                        Id = (int)datos.Lector["Id"],
                        CodigoArticulo = (string)datos.Lector["Codigo"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        Precio = (decimal)datos.Lector["Precio"],

                        Marca = new Marca
                        {
                            Id = (int)datos.Lector["IdMarca"],
                            Descripcion = (string)datos.Lector["Nombre_Marca"]
                        },
                        Categoria = new Categoria
                        {
                            Id = (int)datos.Lector["IdCategoria"],
                            Descripcion = (string)datos.Lector["Nombre_Categoria"]
                        }
                    };

                    lista.Add(articulo);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Eliminar(int id)
        {
            AccesoDatos _accesoDatos = new AccesoDatos();

            try
            {


                _accesoDatos.setearConsulta("delete from Articulos where id = @id");
                _accesoDatos.setearParametro("@id", id);
                _accesoDatos.ejecutarAccion();



            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _accesoDatos.cerrarConexion();

            }
        }
        public void EliminarImagenPorId(int id)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("DELETE IMAGENES from IMAGENES where idArticulo=@id");
                accesoDatos.setearParametro("@id", id);
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
