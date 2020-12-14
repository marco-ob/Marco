using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {

        public int Pedi_ID { get; set; }

        public string Pedi_codigo { get; set; }

        public string Pedi_nombre { get; set; }
        public string Pedi_apellidos { get; set; }
        public string Pedi_direccion_envio { get; set; }
        public string Pedi_tp_tarjeta { get; set; }
        public long Pedi_nro_tarjeta { get; set; }
        public string Pedi_nro_cvv { get; set; }
        public DateTime Pedi_fech_pedido { get; set; }
        public int Pedi_estado { get; set; }
        public int Clie_ID { get; set; }
        public int Pedi_Telefono { get; set; }
        public string Pedi_correo { get; set; }
        public string Pedi_caducidad { get; set; }
        public string Pedi_tp_documento { get; set; }
        public string Pedi_nro_documento { get; set; }

    }
}
