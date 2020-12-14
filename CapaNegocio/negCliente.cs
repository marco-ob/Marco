using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using CapaAccesoDatos;

namespace CapaNegocio
{
    public class negCliente
    {

        private static readonly negCliente _instancia = new negCliente();

        public static negCliente Instancia
        {
            get { return negCliente._instancia; }
        }

        public string InsertarCliente(Cliente clie)
        {
            int resultado;
            string mensaje;
            try
            {
                //llenamos la lista
                resultado = datCliente.Instancia.Registrar(clie);
                //si es difernete de null por lo menos un reigsto
                if (resultado == 2)
                {
                    return mensaje = "Ya existe el Documento con ese numero";
                }else if(resultado == 3)
                {
                    return mensaje = "Ya existe el Correo";
                }
                if (resultado != 1)
                {
                    return mensaje = "No se pudo hacer la inserccion";

                }
                else return "Insertado Correctamente";
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string UpdateCliente(Cliente clie)
        {
            int resultado;
            string mensaje;

            resultado = datCliente.Instancia.Actualizar(clie);

            if(resultado == 0)
            {
                mensaje = "Se Actualizo al cliente correctamente";

            }
            else
            {
                mensaje = "No se pudo actualizar";
            }


            return mensaje;

        }

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            try
            {

                lista = datCliente.Instancia.Listar();
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

            public Cliente Logueo(string usuario,string password)
        {
            Cliente usu;
            try
            {
                usu = datCliente.Instancia.Logueo(usuario, password);

                //id celular estado
                if (usu.Clie_estado==0)
            {
                    return usu;
            }

             }
            catch (Exception ex)
            {
                throw ex;
            }
            return usu;
            }



        }
}
