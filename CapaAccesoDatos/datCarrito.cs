using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace CapaAccesoDatos
{
    public class datCarrito
    {

        private static readonly datCarrito _instancia = new datCarrito();

        public static datCarrito Instancia
        {
            get { return datCarrito._instancia; }
        }

        SqlCommand cmd = null;

        public string InsertarCarrito(List<CarritoCompras> listacarrito)
        {
            int registros = 0;
            string rpta = "";
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_Insertar_Carrito", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();


                foreach (CarritoCompras det in listacarrito)
                {

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@prod_id", det.Prod_ID);
                    cmd.Parameters.AddWithValue("@pedido_id", det.Pedi_ID);
                    cmd.Parameters.AddWithValue("@cantidad", det.Carcom_cantidad);
                    cmd.Parameters.AddWithValue("@precio", det.Carcom_prec_unit);
                    cmd.Parameters.AddWithValue("@total", det.Carcom_total);
                    registros = cmd.ExecuteNonQuery();

                }
                if (registros > 0)
                {
                    rpta = "ok";

                }
                else
                {
                    rpta = "error al insertar";
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
            return rpta;
        }

    }

}
