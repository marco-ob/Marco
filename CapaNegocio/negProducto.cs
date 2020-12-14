using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaAccesoDatos;
using Entidades;

namespace CapaNegocio
{
    public class negProducto
    {
        private static readonly negProducto _instancia = new negProducto();

        public static negProducto Instancia
        {
            get { return negProducto._instancia; }
        }

        //public List<Productos> ListarProductoxCategoria(int idcategoria)
        //{
        //    List<Productos> lista = new List<Productos>();


        //    try
        //    {

        //        lista = datProducto.Instancia.ListarProductosxCategoria(idcategoria);
        //        if (lista != null)
        //        {
        //            if (lista.Count <= 0)
        //            {
        //                throw new ApplicationException("No hay productos para mostrar");
        //            }
        //        }
        //        else
        //        {
        //            throw new ApplicationException("Ocurrio un error al cargar la lista de Productos");
        //        }

        //    }
        //    catch(ApplicationException msg)
        //    {
        //        throw msg;
        //    }catch(Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return lista;
        //}


        public List<Productos> Listar()
        { 
            List<Productos> lista = new List<Productos>();


            try
            {

                lista = datProducto.Instancia.Listar();
                if (lista != null)
                {
                    if (lista.Count <= 0)
                    {
                        throw new ApplicationException("No hay suficientes productos para mostrar");
                    }
                }
                else
                {
                    throw new ApplicationException("Ocurrio un error al cargar la lista de Productos");
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


        public string UpdateProducto(Productos prod)
        {
            int resultado;
            string mensaje;

            resultado = datProducto.Instancia.Actualizar(prod);

            if (resultado == 1)
            {
                mensaje = "Se Actualizo el producto correctamente";

            }
            else
            {
                mensaje = "No se pudo actualizar";
            }


            return mensaje;

        }

        public string InsertarProducto(Productos prod)
        {
            int resultado;
            string mensaje;
            try
            {
                //llenamos la lista
                resultado = datProducto.Instancia.Registrar(prod);
                //si es difernete de null por lo menos un reigsto
                if (resultado == 2)
                {
                    return mensaje = "Ya existe el nombre producto";
                }
                else if (resultado == 3)
                {
                    return mensaje = "Ya existe el titulo de la imagen";
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

        public DataTable ListarTabla()
        {
            DataTable tabla;

            try
            {
                tabla = new DataTable();
                tabla = datProducto.Instancia.ListarTable();

                if (tabla != null)
                {
                    if (tabla.Rows.Count <= 0)
                    {
                        throw new ApplicationException("No hay productos para mostrar");
                    }
                }
                else
                {
                    throw new ApplicationException("Ocurrio un error al cargar la lista de Productos");
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

        public DataTable ListarCategoriaxProducto(int codigo)
        {
            DataTable tabla;

            try
            {
                tabla = new DataTable();
                tabla = datProducto.Instancia.ListarProductosxCategoria(codigo);

                if (tabla != null)
                {
                    if (tabla.Rows.Count <= 0)
                    {
                        throw new ApplicationException("No hay productos asociado a esa categoria para mostrar");
                    }
                }
                else
                {
                    throw new ApplicationException("Ocurrio un error al cargar la lista de productos asociado a esa categoria");
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
