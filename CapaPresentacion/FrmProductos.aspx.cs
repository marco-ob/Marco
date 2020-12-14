using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class FrmProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Admin"] != null)
            //{
                if (!IsPostBack)
                {
                    CargarProductos();
                }
            //}
            //else
            //{
            //    Response.Redirect("FrmAccesoAdmin.aspx");
            //}
        }

        private void CargarProductos()
        {
            listaproductos.DataSource = negProducto.Instancia.ListarTabla();
            listaproductos.DataBind();
        }


        protected void rowCancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            listaproductos.EditIndex = -1;
            CargarProductos();
        }

        protected void rowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

       
        protected void rowEditing(object sender, GridViewEditEventArgs e)
        {
            listaproductos.EditIndex = e.NewEditIndex;
            CargarProductos();
        }

        protected void rowupdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow fila = listaproductos.Rows[e.RowIndex];
            int id= Convert.ToInt32(listaproductos.DataKeys[e.RowIndex].Values[0]); 
            //string codigo;
            string nombre=(fila.FindControl("txtnombre") as TextBox).Text; ;
            double precio= Convert.ToDouble((fila.FindControl("txtprecio") as TextBox).Text);
            int stocK= Convert.ToInt32((fila.FindControl("txtstock") as TextBox).Text); 
            //string imagen= (fila.FindControl("txtimagen") as TextBox).Text;
            string descripcion= (fila.FindControl("txtdescripcion") as TextBox).Text; 
            int estado= Convert.ToInt32((fila.FindControl("txtestado") as TextBox).Text);
            Categoria cate=new Categoria();
            cate.Cate_ID = Convert.ToInt32((fila.FindControl("txtidcate") as TextBox).Text); ;
            Productos prod = new Productos();
            prod.Prod_ID =id;
            //prod.Prod_codigo = codigo;
            prod.Prod_nombre = nombre;
            prod.Prod_prec = precio;
            prod.Prod_stock = stocK;
            //prod.Prod_imagen = imagen;
            prod.Prod_descripcion = descripcion;
            prod.Prod_estado = estado;
            prod.Categoria = cate;

            string valor = negProducto.Instancia.UpdateProducto(prod);
            string script = @"<script type='text/javascript'>
                            alerta('" + valor + "');</script>";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alerta", script, false);
            if (valor.Equals("Se Actualizo el producto correctamente"))
            {
                listaproductos.EditIndex = -1;
                CargarProductos();
            }
        }
    }
}