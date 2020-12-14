using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

using CapaAccesoDatos;


namespace CapaNegocio
{
    public class negCategoria
    {
        private static readonly negCategoria _instancia = new negCategoria();

        public static negCategoria Instancia
        {
            get { return negCategoria._instancia; }
        }


        public List<Categoria> ListarCategoria()
        {
            List<Categoria> lst = new List<Categoria>();
            

            try
            {
                //llenamos la lista
                lst = datCategoria.Instancia.Listar();
                //si es difernete de null por lo menos un reigsto
                if (lst != null)
                {
                    if (lst.Count <= 0)
                    {
                        throw new ApplicationException("No hay categoria para mostrar");
                    }
                }
                else
                {
                    throw new ApplicationException("Ocurrio un error al cargar la cateogira");
                }
                
            } catch (Exception ex)
            {
                throw ex;
            }
            return lst;


        }

        public string ActualizarCategoria(Categoria cat)
        {
            int resultado;
            string mensaje;

            resultado = datCategoria.Instancia.Actualizar(cat);

            if (resultado == 1)
            {
                mensaje = "Se actualizo la categoria correctamente";
            }
            else
            {
                mensaje = "No se pudo actualizar";
            }

            return mensaje;
        }

        public string InsertarCategoria(Categoria cat) 
        {
            int resultado;
            string mensaje;
            try
            {
                resultado = datCategoria.Instancia.Registrar(cat);

                if (resultado == 2) 
                {
                    return mensaje = "Ya existe el nombre de la categoria";
                }
                if (resultado != 1)
                {
                    return mensaje = "No se puede hacer la inserción";
                }
                else return "Insertado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarCombo()
        {
            DataTable tabla;

            try
            {
                tabla = new DataTable();
                tabla = datCategoria.Instancia.ListarCombo();

                if (tabla != null)
                {
                    if (tabla.Rows.Count <= 0)
                    {
                        throw new ApplicationException("No hay categorias por mostrar");
                    }
                }
                else
                {
                    throw new ApplicationException("Ocurrio un error al cargar la lista de categorias");
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

            return tabla;
        }
    }
}