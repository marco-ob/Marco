using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CarritoCompras
    {

        
        public int Prod_ID { get; set; }

        public int Pedi_ID { get; set; }

        public int Carcom_cantidad { get; set; }

        public decimal Carcom_prec_unit { get; set; }

        public decimal Carcom_total { get; set; }

    }
}
