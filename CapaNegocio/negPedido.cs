using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaAccesoDatos;

namespace CapaNegocio
{
   public class negPedido
    {
        private static readonly negPedido _instancia = new negPedido();

        public static negPedido Instancia
        {
            get { return negPedido._instancia; }
        }





        public string ResgistrarPedido(Pedido ped)
        {
            int resultado;
            string mensaje;
            try
            {
                //llenamos la lista
                resultado = datPedido.Instancia.Registrar(ped);
                //si es difernete de null por lo menos un reigsto
                if (resultado == 1)
                {
                     mensaje = "Se registro correctamente el pedido";
                }
                else  mensaje="Hubo un error al registrar su pedido";


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return mensaje;
        }

        public int Cod_Detalle_Carrito()
        {
            int resultado;
            resultado = datPedido.Instancia.CodDetalleCarrito();
            return resultado;
        }

        public List<Pedido> Listar()
        {
            List<Pedido> lista = new List<Pedido>();

            try
            {

                lista = datPedido.Instancia.Listar();
                if (lista != null)
                {
                    if (lista.Count <= 0)
                    {
                        throw new ApplicationException("No hay suficientes clientes para listar");
                    }
                }
                else
                {
                    throw new ApplicationException("Ocurrio un error al cargar la lista de Clientes");
                }

            }
            catch (ApplicationException msg)
            {
                throw msg;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;




        }

        public string UpdatePedido(Pedido pedi)
        {
            int resultado;
            string mensaje;

            resultado = datPedido.Instancia.Actualizar(pedi);

            if (resultado == 0)
            {
                mensaje = "Se Actualizo al pedido correctamente";

            }
            else
            {
                mensaje = "No se pudo actualizar";
            }


            return mensaje;

        }






    }
}
