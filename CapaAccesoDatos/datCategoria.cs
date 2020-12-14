using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//usamos esto para poder trabajar con la conexion a la base de datos
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace CapaAccesoDatos
{
   public class datCategoria:CRUD<Categoria>
    {
        //patron singleton
        private static readonly datCategoria _instancia = new datCategoria();

        public static datCategoria Instancia
        {
            get { return datCategoria._instancia; }
        }

        public int Actualizar(Categoria cat)
        {
            SqlCommand cmd = null;
            int resultado = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ActualizarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                cmd.Parameters.AddWithValue("@id", cat.Cate_ID);
                cmd.Parameters.AddWithValue("@nombre", cat.Cate_nombre);
                cmd.Parameters.AddWithValue("@estado", cat.Cate_estado);

                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return resultado;
        }

        public int Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> Listar()
        {
           
            SqlCommand cmd = null; // para poder llamar a nuestro procedimiento almacenado          
            SqlDataReader dr = null;  //para obtener un listado de filas
            List<Categoria> lista = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ListarCategorias", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Categoria>(); 
                while (dr.Read())   //rrecorremos la fila 
                {
                    //nuestro datareader va  a llenar 
                    Categoria objcat = new Categoria();
                    objcat.Cate_ID = Convert.ToInt32(dr["Cate_ID"]);
                    objcat.Cate_codigo = Convert.ToString(dr["Cate_codigo"]);
                    objcat.Cate_nombre = Convert.ToString(dr["Cate_nombre"]);
                    objcat.Cate_estado = Convert.ToInt32(dr["Cate_estado"]);

                    lista.Add(objcat);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;

        }

        //public DataTable ListarsELECT()
        //{

        //    SqlCommand cmd = null;
        //    para obtener un listado de filas
        //    DataTable dt = new DataTable();
        //    try
        //    {


        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("sp_ListarCategorias", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cn.Open();





        //    }
        //    catch (Exception E)
        //    {

        //    }
        //    dt.Load(cmd.ExecuteReader());
        //    return dt;
        //}



        public int Registrar(Categoria cat)
        {
            SqlCommand cmd = null;
            int ejecutado;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_InsertarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", cat.Cate_nombre);

                cn.Open();

                SqlParameter returnParameter = cmd.Parameters.Add("@valor", SqlDbType.Int);

                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                return ejecutado = (int)cmd.Parameters["@valor"].Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                cmd.Connection.Close();
            }
        }


        public DataTable ListarCombo()
        {

            DataTable tabla = null;
            SqlCommand cmd = null;
            try
            {
                tabla = new DataTable();
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("sp_ListarCategorias", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                tabla.Load(cmd.ExecuteReader());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return tabla;

        }
    }
}
