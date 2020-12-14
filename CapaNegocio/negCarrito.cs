using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaAccesoDatos;

namespace CapaNegocio
{
    public class negCarrito
    {

        private static readonly negCarrito _instancia = new negCarrito();

        public static negCarrito Instancia
        {
            get { return negCarrito._instancia; }
        }


        public string InsertarCarrito(List<CarritoCompras> listacarrito)
        {
            string mensaje;
            mensaje = datCarrito.Instancia.InsertarCarrito(listacarrito);
            return mensaje;
        }
    }
}
