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
    public class datAdministrador
    {
        private static readonly datAdministrador _instancia = new datAdministrador();

        public static datAdministrador Instancia
        {
            get { return datAdministrador._instancia; }
        }
        public Administrador Logueo(string documento, string password)
        {

            SqlDataReader dr;
            SqlConnection cn;
            SqlCommand cmd;
            Administrador admin = new Administrador();
            bool existe;

            try
            {
                cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_LogueoAdmin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@documento", documento);
                cmd.Parameters.AddWithValue("@password", password);

                cn.Open();
                dr = cmd.ExecuteReader();
                existe = dr.Read();

                if (existe)
                {

                    admin.Admin_nombre = Convert.ToString(dr.GetString(0));
                    admin.Admin_estado = dr.GetInt32(1);

                }


            }
            catch (Exception e)
            {
                throw e;
            }

            return admin;

        }



    }
}
