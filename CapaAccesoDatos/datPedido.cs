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
    public class datPedido
    {

        private static readonly datPedido _instancia = new datPedido();

        public static datPedido Instancia
        {
            get { return datPedido._instancia; }
        }

        SqlCommand cmd = null;

        public int Registrar(Pedido ped)
        {
            
            int resultado = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_Registrar_Pedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                cmd.Parameters.AddWithValue("@nombre", ped.Pedi_nombre);
                cmd.Parameters.AddWithValue("@apellidos", ped.Pedi_apellidos);
                cmd.Parameters.AddWithValue("@direccion", ped.Pedi_direccion_envio);
                cmd.Parameters.AddWithValue("@tp_tarjeta", ped.Pedi_tp_tarjeta);
                cmd.Parameters.AddWithValue("@nro_tarjeta", ped.Pedi_nro_tarjeta);
                cmd.Parameters.AddWithValue("@nro_cvv", ped.Pedi_nro_cvv);
      
                cmd.Parameters.AddWithValue("@clie_id", ped.Clie_ID);

                cmd.Parameters.AddWithValue("@telefono", ped.Pedi_Telefono);
                cmd.Parameters.AddWithValue("@correo", ped.Pedi_correo);
                cmd.Parameters.AddWithValue("@caducidad", ped.Pedi_caducidad);
                cmd.Parameters.AddWithValue("@tp_documento", ped.Pedi_tp_documento);
                cmd.Parameters.AddWithValue("@nro_documento", ped.Pedi_nro_documento);

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

        public int CodDetalleCarrito()
        {
            int codigo = 0;
            SqlDataReader lector;
            SqlConnection cn = Conexion.Instancia.Conectar();
            cmd = new SqlCommand("sp_Obtener_Codigo_Pedido", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                codigo = (int)lector[0];
            }
            return codigo;
        }


        public List<Pedido> Listar()
        {
            List<Pedido> lst = null;
            SqlDataReader dr;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("sp_ListPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                lst = new List<Pedido>();
                while (dr.Read())
                {
                    Pedido pedi = new Pedido();

                    pedi.Pedi_ID= Convert.ToInt32(dr["Pedi_id"]);
                    pedi.Pedi_codigo= dr["Pedi_codigo"].ToString();
                    pedi.Pedi_nombre = dr["Pedi_nombre"].ToString();
                    pedi.Pedi_apellidos = dr["Pedi_apellidos"].ToString();
                    pedi.Pedi_nro_documento = dr["Pedi_nro_documento"].ToString();
                    pedi.Pedi_direccion_envio = dr["Pedi_direccion_envio"].ToString();
                    pedi.Pedi_fech_pedido = Convert.ToDateTime(dr["Pedi_fech_pedido"]);
                    pedi.Pedi_Telefono = Convert.ToInt32(dr["Pedi_telefono"]);
                    pedi.Pedi_estado = Convert.ToInt32(dr["Pedi_estado"]);

                    lst.Add(pedi);


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

        public int Actualizar(Pedido pedi)
        {
            SqlCommand cmd = null;
            int resultado = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ActualizarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                cmd.Parameters.AddWithValue("@pedi_id", pedi.Pedi_ID);
                cmd.Parameters.AddWithValue("@estado", pedi.Pedi_estado);
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

    }
}