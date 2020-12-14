using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaAccesoDatos
{
    public class Conexion
    {
        //patron singleton nos sirve para poder hacer una instancia a nuestra
        //clase y poder acceder a los metodos que hemos creado en ella
        private static readonly Conexion _instancia=new Conexion();
     
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        //aqui acaba el patron singleton
        public SqlConnection Conectar()
        {
            try
            {

                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Data source=LAPTOP-PO35PVS0;Initial Catalog=EASYBUY;User Id=sa;Password=marco0223";
                return cn;

            }catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
