using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace CapaAccesoDatos
{
    public class datProducto: CRUD<Productos>
    {
        //patron singleton
        private static readonly datProducto _instancia = new datProducto();

        public static datProducto Instancia
        {
            get { return datProducto._instancia; }
        }

        public int Actualizar(Productos prod)
        {
            SqlCommand cmd = null;
            int resultado = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ActualizarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                cmd.Parameters.AddWithValue("@id", prod.Prod_ID);
                cmd.Parameters.AddWithValue("@nombre", prod.Prod_nombre);
                cmd.Parameters.AddWithValue("@precio", prod.Prod_prec);
                cmd.Parameters.AddWithValue("@stock", prod.Prod_stock);
                //cmd.Parameters.AddWithValue("@imagen", prod.Prod_imagen);
                cmd.Parameters.AddWithValue("@descripcion", prod.Prod_descripcion);
                cmd.Parameters.AddWithValue("@estado", prod.Prod_estado);
                //int catecod = prod.Categoria.Cate_ID;
                cmd.Parameters.AddWithValue("@cate_id", prod.Categoria.Cate_ID);
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

        public List<Productos> Listar()
        {

            List<Productos> lst = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("sp_listaproductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                 dr = cmd.ExecuteReader();

                lst = new List<Productos>();
                while (dr.Read())
                {
                   Productos prod = new Productos();
                    Categoria cate = new Categoria(); 

                    prod.Prod_ID = Convert.ToInt32(dr["Prod_ID"]);
                    prod.Prod_codigo= dr["Prod_codigo"].ToString();
                    cate.Cate_ID= Convert.ToInt32(dr["Cate_ID"]);
                    prod.Categoria = cate;
                    prod.Prod_nombre = dr["Prod_nombre"].ToString();
                    prod.Prod_prec = Convert.ToDouble(dr["Prod_prec"]);
                    prod.Prod_stock = Convert.ToInt32(dr["Prod_stock"]);
                    prod.Prod_descripcion = dr["Prod_descripcion"].ToString();
                    byte[] data = Encoding.Unicode.GetBytes(dr["Prod_imagen"].ToString());
                    prod.Prod_imagen = data;


                    prod.Prod_estado = Convert.ToInt32(dr["Prod_estado"]);
                   
                    
                    lst.Add(prod);


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
            return lst;

        }

        public int Registrar(Productos prod)
        {

            SqlCommand cmd = null;
            int ejecutado;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("sp_InsertarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@nombre", SqlDbType.Text).Value = prod.Prod_nombre;
                cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = prod.Prod_prec;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = prod.Prod_stock;
                cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = prod.Prod_imagen;
                cmd.Parameters.Add("@titulo", SqlDbType.Text).Value = prod.Prod_titulo_imagen;
                cmd.Parameters.Add("@descripcion", SqlDbType.Text).Value = prod.Prod_descripcion;
                cmd.Parameters.Add("@cateID", SqlDbType.Int).Value = prod.Categoria.Cate_ID;

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

        public DataTable ListarProductosxCategoria(int idcategoria)
        {

           
            SqlCommand cmd = null;
            DataTable tabla = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ListarProductosxCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcategoria", idcategoria);


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




        public DataTable ListarTable()
        {

            DataTable tabla = null;
            SqlCommand cmd = null;
            try
            {
                tabla = new DataTable();
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("sp_listaproductos", cn);
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
