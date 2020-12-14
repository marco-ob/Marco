using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador
    {
        public int Admin_ID { get; set; }
        public String Admin_codigo { get; set; }
        public String Admin_nombre { get; set; }
        public String Admin_apellidos { get; set; }
        public String Admin_tp_documento { get; set; }
        public String Admin_nro_documento { get; set; }
        public int Admin_estado { get; set; }
        public String Admin_password { get; set; }
    }
}
