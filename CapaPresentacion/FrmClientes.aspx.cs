using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class FrmClientes : System.Web.UI.Page


    {


        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Admin"]!=null) {
                if (!IsPostBack)
                {
                    CargarClientes();
                }
            //}
            //else
            //{
            //    Response.Redirect("FrmAccesoAdmin.aspx");
            //}
        }


        public void CargarClientes()
        {
            listaClientes.DataSource = negCliente.Instancia.Listar();
            listaClientes.DataBind();
        }

        protected void rowCancelEditEvent(object sender, GridViewCancelEditEventArgs e)
        {
            listaClientes.EditIndex = -1;
            CargarClientes();
        }

        protected void rowDeletingEvent(object sender, GridViewDeleteEventArgs e)
        {
            
        }

        protected void rowEditingEvent(object sender, GridViewEditEventArgs e)
        {
            listaClientes.EditIndex = e.NewEditIndex;
            CargarClientes();
        }

      
        protected void rowUpdatetingEvent(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow fila = listaClientes.Rows[e.RowIndex];
            int id = Convert.ToInt32(listaClientes.DataKeys[e.RowIndex].Values[0]);
           // String codigo = (fila.FindControl("txtcodigo") as TextBox).Text;
            String nombre = (fila.FindControl("txtnombre") as TextBox).Text;
            String apellido = (fila.FindControl("txtapellido") as TextBox).Text;
            String direccion = (fila.FindControl("txtdireccion") as TextBox).Text;
            int celular = Convert.ToInt32((fila.FindControl("txtcelular") as TextBox).Text);
            //DateTime fecha = Convert.ToDateTime((fila.FindControl("txtfech") as TextBox).Text);
            String correo = (fila.FindControl("txtcorreo") as TextBox).Text;
            String clave = (fila.FindControl("txtpassword") as TextBox).Text;
            String tipo = (fila.FindControl("txttipodoc") as TextBox).Text;
            String documento = (fila.FindControl("txtdocumento") as TextBox).Text;
            int estado= Convert.ToInt32((fila.FindControl("txtestado") as TextBox).Text);

            Cliente clie = new Cliente();
            clie.Clie_Id = id;
            //clie.Clie_codigo = codigo;
            clie.Clie_nombre = nombre;
            clie.Clie_apellidos = apellido;
            clie.Clie_direccion = direccion;
            clie.Clie_celular = celular;
            //clie.Clie_fech_registro = fecha;
            clie.Clie_correo = correo;
            clie.Clie_clave = clave;
            clie.Clie_tp_documento = tipo;
            clie.Clie_nro_documento = documento;
            clie.Clie_estado = estado;

            string valor=negCliente.Instancia.UpdateCliente(clie);

            if (valor.Equals("Se Actualizo al cliente correctamente"))
            {
                listaClientes.EditIndex = -1;
                CargarClientes();
            }


            

        }

       
    }

    



}