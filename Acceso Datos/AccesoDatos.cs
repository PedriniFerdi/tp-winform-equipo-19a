using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;




namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get
            {
                return lector;
            }

        }
        public AccesoDatos()
        { 
            conexion = new SqlConnection(


                "server=localhost; database=CATALOGO_P3_DB; integrated security=true; TrustServerCertificate=True");

            comando = new SqlCommand();


        }
        public void setearConsulta(string consulta)
        {
            comando.Parameters.Clear();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw;
            }
        }



        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                conexion.Close();
            }
        }
        public int insertarYobtenerId()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                return (int)comando.ExecuteScalar();
            }
            catch { throw; }
            finally
            {
                cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            try
            {
                setearConsulta("delete from articulos where id = @id");
                agregarParametro("@id", id);
                ejecutarAccion();
            }
            catch { throw; }
            finally
            {
                cerrarConexion();
            }
        }
        public void cerrarConexion()
        {
            lector?.Close();
            conexion.Close();

        }
        public void agregarParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor ?? DBNull.Value);
        }
    }
}
