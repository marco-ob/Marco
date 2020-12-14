using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaNegocio;
using Entidades;

namespace CapaPresentacion
{
    public partial class FrmCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //if (Session["Admin"] != null)
            //{
                if (!IsPostBack)
                {
                    CargarCategorias();
                }
            //}
            //else
            //{
            //    Response.Redirect("FrmAccesoAdmin.aspx");
            //}
        }

        private void CargarCategorias()
        {
            listarcategorias.DataSource = negCategoria.Instancia.ListarCategoria();
            listarcategorias.DataBind();
        }

        protected void rowCancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            listarcategorias.EditIndex = -1;
            CargarCategorias();
        }

        protected void rowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }


        protected void rowEditing(object sender, GridViewEditEventArgs e)
        {
            listarcategorias.EditIndex = e.NewEditIndex;
            CargarCategorias();
        }

        protected void rowupdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow fila = listarcategorias.Rows[e.RowIndex];
            int id = Convert.ToInt32(listarcategorias.DataKeys[e.RowIndex].Values[0]);
            //string codigo;
            string nombre = (fila.FindControl("txtnombre") as TextBox).Text; 
            int estado = Convert.ToInt32((fila.FindControl("txtestado") as TextBox).Text);
            Categoria cate = new Categoria();
            cate.Cate_ID = id;
            //prod.Prod_codigo = codigo;
            cate.Cate_nombre = nombre;
            cate.Cate_estado = estado;

            string valor = negCategoria.Instancia.ActualizarCategoria(cate);
            string script = @"<script type='text/javascript'>
                            alerta('" + valor + "');</script>";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alerta", script, false);
            if (valor.Equals("Se Actualizo el producto correctamente"))
            {
                listarcategorias.EditIndex = -1;
                CargarCategorias();
            }
        }

       
       
    }
}