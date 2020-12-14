using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {

        public int Clie_Id { get; set; }

        public String Clie_codigo { get; set; }

        public String Clie_nombre { get; set; }

        public String Clie_apellidos{ get; set; }

        public String Clie_direccion { get; set; }
        public int Clie_celular { get; set; }
        public DateTime  Clie_fech_registro { get; set; }
        public String Clie_correo { get; set; }
        public String Clie_clave { get; set; }
        public String Clie_tp_documento { get; set; }
        public String Clie_nro_documento { get; set; }
        public int Clie_estado { get; set; }


    }
}
