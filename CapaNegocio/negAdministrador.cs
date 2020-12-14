using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using Entidades;

namespace CapaNegocio
{
    public class negAdministrador
    {
        private static readonly negAdministrador _instancia = new negAdministrador();

        public static negAdministrador Instancia
        {
            get { return negAdministrador._instancia; }
        }



        public Administrador Logueo(string documento, string password)
        {
            Administrador admin;
            try
            {
                admin = datAdministrador.Instancia.Logueo(documento, password);

                if (admin.Admin_estado==0)
                {

                    return admin;
                    
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return admin;
        }





    }
}
