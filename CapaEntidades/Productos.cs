using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        public int Prod_ID { get; set; }

        public String Prod_codigo { get; set; }

        public String Prod_nombre { get; set; }

        public Double Prod_prec { get; set; }

        public int Prod_stock { get; set; }

        public byte[] Prod_imagen { get; set; }

        public string  Prod_titulo_imagen { get; set; }

        public String Prod_descripcion { get; set; }

        public int Prod_estado { get; set; }

        public Categoria Categoria { get; set; }


    }
}
