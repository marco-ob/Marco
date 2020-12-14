using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace CapaAccesoDatos
{
   public class datCliente:CRUD<Cliente>
    {
        private static readonly datCliente _instancia = new datCliente();


        public static datCliente Instancia
        {
            get { return datCliente._instancia; }
        }

        public int Actualizar(Cliente clie)
        {
            SqlCommand cmd = null;
            int resultado = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_UpdateCliente",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                cmd.Parameters.AddWithValue("@id",clie.Clie_Id);
                //cmd.Parameters.AddWithValue("@codigo", clie.Clie_codigo);
                cmd.Parameters.AddWithValue("@nombre", clie.Clie_nombre);
                cmd.Parameters.AddWithValue("@apellidos", clie.Clie_apellidos);
                cmd.Parameters.AddWithValue("@direccion", clie.Clie_direccion);
                cmd.Parameters.AddWithValue("@celular", clie.Clie_celular);
                cmd.Parameters.AddWithValue("@correo", clie.Clie_correo);
                cmd.Parameters.AddWithValue("@clave", clie.Clie_clave);
                cmd.Parameters.AddWithValue("@tp_documento", clie.Clie_tp_documento);
                cmd.Parameters.AddWithValue("@nro_documento", clie.Clie_nro_documento);
                cmd.Parameters.AddWithValue("@estado", clie.Clie_estado);
                resultado=cmd.ExecuteNonQuery();


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


        public List<Cliente> Listar()
        {
            List<Cliente> lst=null;
            SqlDataReader dr;
            SqlCommand cmd=null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("sp_ListCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                lst = new List<Cliente>();
                while (dr.Read())
                {
                    Cliente clie = new Cliente();
                    

                    clie.Clie_Id= Convert.ToInt32(dr["Clie_Id"]);
                    clie.Clie_codigo = dr["Clie_codigo"].ToString();
                    clie.Clie_nombre = dr["Clie_nombre"].ToString();
                    clie.Clie_apellidos = dr["Clie_apellidos"].ToString();
                    clie.Clie_direccion = dr["Clie_direccion"].ToString();
                    clie.Clie_celular = Convert.ToInt32(dr["Clie_celular"]);
                    clie.Clie_fech_registro = Convert.ToDateTime(dr["Clie_fech_registro"]);
                    clie.Clie_correo = dr["Clie_correo"].ToString();
                    clie.Clie_clave = Encriptar(dr["Clie_clave"].ToString(),Llave);
                    clie.Clie_tp_documento = dr["Clie_tp_documento"].ToString();
                    clie.Clie_nro_documento = dr["Clie_nro_documento"].ToString();
                    clie.Clie_estado = Convert.ToInt32(dr["Clie_estado"]);
                    lst.Add(clie);


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

        public int Registrar(Cliente clie)
        {
            SqlCommand cmd = null;
            int ejecutado;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_InsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", clie.Clie_nombre);
                cmd.Parameters.AddWithValue("@apellido", clie.Clie_apellidos);
                cmd.Parameters.AddWithValue("@direccion", clie.Clie_direccion);
                cmd.Parameters.AddWithValue("@celular", clie.Clie_celular);
                cmd.Parameters.AddWithValue("@correo", clie.Clie_correo);
                cmd.Parameters.AddWithValue("@clave", clie.Clie_clave);
                cmd.Parameters.AddWithValue("@tipodoc", clie.Clie_tp_documento);
                cmd.Parameters.AddWithValue("@nrodoc", clie.Clie_nro_documento);


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

        public int Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente Logueo(string usuario, string password)
        {

            SqlDataReader dr;
            SqlConnection cn;
            SqlCommand cmd;
            Cliente usu = new Cliente(); 
            bool hay;
            try
            {
                cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_Logueo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@correo", usuario);
                cmd.Parameters.AddWithValue("@password", password);

                cn.Open();
                dr = cmd.ExecuteReader();
                hay = dr.Read();

                if (hay)
                {

                    usu.Clie_nombre = Convert.ToString(dr.GetString(0));
                    usu.Clie_apellidos = Convert.ToString(dr.GetString(1));
                    usu.Clie_direccion = Convert.ToString(dr.GetString(2));
                    usu.Clie_tp_documento = Convert.ToString(dr.GetString(3));
                    usu.Clie_nro_documento = Convert.ToString(dr.GetString(4));
                    usu.Clie_estado = dr.GetInt32(5);
                    usu.Clie_correo = dr.GetString(6);
                    usu.Clie_celular = dr.GetInt32(7);
                    usu.Clie_Id = dr.GetInt32(8);


                }


            }
            catch (Exception e)
            {
                throw e;
            }

            return usu;

        }


        public string Encriptar(string password, string llave)
        {
            byte[] Keyarray;
            byte[] encriptar = Encoding.UTF8.GetBytes(password);

            Keyarray = Encoding.UTF8.GetBytes(llave);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = Keyarray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform ctransform = tdes.CreateEncryptor();
            byte[] resultado = ctransform.TransformFinalBlock(encriptar, 0, encriptar.Length);
            tdes.Clear();

            return Convert.ToBase64String(resultado);
        }



        public static string Llave = "jwey89e09ewhfo24";
    }
}
