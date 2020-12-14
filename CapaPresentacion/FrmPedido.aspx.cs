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
    public partial class FrmPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Admin"] != null)
            //{
                if (!IsPostBack)
                {
                    CargarPedidos();
                }
            //}
            //else
            //{
            //    Response.Redirect("FrmAccesoAdmin.aspx");
            //}
        }

        private void CargarPedidos()
        {
            listapedidos.DataSource = negPedido.Instancia.Listar();
            listapedidos.DataBind();
        }

        protected void rowCancelEditEvent(object sender, GridViewCancelEditEventArgs e)
        {
            listapedidos.EditIndex = -1;
            CargarPedidos();
        }

        protected void rowDeletingEvent(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void rowEditingEvent(object sender, GridViewEditEventArgs e)
        {
            listapedidos.EditIndex = e.NewEditIndex;
            CargarPedidos();
        }

        protected void rowUpdatetingEvent(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow fila = listapedidos.Rows[e.RowIndex];
            int id = Convert.ToInt32(listapedidos.DataKeys[e.RowIndex].Values[0]);
            int estado = Convert.ToInt32((fila.FindControl("txtestado") as TextBox).Text);
            Pedido ped = new Pedido();
            ped.Pedi_ID = id;
            ped.Pedi_estado = estado;
            string valor = negPedido.Instancia.UpdatePedido(ped);
            if (valor.Equals("Se Actualizo al pedido correctamente"))
            {
                listapedidos.EditIndex = -1;
                CargarPedidos();
            }


        }
    }
}