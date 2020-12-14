using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class FrmCategoriaxProductoLogueado : System.Web.UI.Page
    {
        DataTable dtb;
        DataTable carrito = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {

                //Cliente usu = (Cliente)Session["Usuario"];
                //nombreusuario.Text = usu.usuario.ToString();

                CargarDetalle();
            }

            try
            {
                if (Page.IsPostBack == false)
                {
                    MostrarCategoria();
                    MostrarProductos();
                }
                //else
                //{
                //    MostrarCategoria();

                //}
            }
            catch (ApplicationException msg)
            {
                MostrarMensaje(msg.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        private void MostrarMensaje(string msg)
        {
            string script = @"<script type='text\javascript'>alert('" + msg + "');<script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alerta", script, false);

        }
        void MostrarProductos()
        {
            int idcategoria = Convert.ToInt32(Request.QueryString["idcat"]);
            //origen de datos
            dlsProductos.DataSource = negProducto.Instancia.ListarCategoriaxProducto(idcategoria);
            //que nos muestra la informacion
            dlsProductos.DataBind();
        }
        void MostrarCategoria()
        {

            lvCategorias.DataSource = negCategoria.Instancia.ListarCategoria();
            //para que establesca el origen
            lvCategorias.DataBind();
        }





        public void CargarDetalle()
        {

            if (Session["pedido"] == null)
            {
                dtb = new DataTable("Carrito");
                dtb.Columns.Add("ID", System.Type.GetType("System.String"));
                dtb.Columns.Add("CODIGO", System.Type.GetType("System.String"));
                dtb.Columns.Add("PRODUCTO", System.Type.GetType("System.String"));
                dtb.Columns.Add("PRECIO", System.Type.GetType("System.Double"));
                dtb.Columns.Add("CANTIDAD", System.Type.GetType("System.Int32"));
                dtb.Columns.Add("SUBTOTAL", System.Type.GetType("System.Double"));
                //antes     dtb.Columns.Add("canproducto", System.Type.GetType("System.Int32"));

                Session["pedido"] = dtb;
                Session["prueba"] = dtb;
            }
            else
            {
                Session["pedido"] = Session["prueba"];
            }


        }




        public void AgregarItem(string id, string cod, string des, double precio)
        {
            double total;
            //int cantidad =1;
            int cantidad = Convert.ToInt32(((TextBox)this.dlsProductos.SelectedItem.FindControl("txtCantidad")).Text);
            //int cantidad = Convert.ToInt32(((TextBox)Page.FindControl("txtCantidad")).Text);
            total = precio * cantidad;
            carrito = (DataTable)Session["pedido"];
            DataRow fila = carrito.NewRow();
            fila[0] = id;
            fila[1] = cod;
            fila[2] = des;
            fila[3] = precio;
            fila[4] = (int)cantidad;
            fila[5] = total;
            carrito.Rows.Add(fila);
            Session["pedido"] = carrito;

        }

        protected void dlsProductos_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("FrmAccesoCliente.aspx");
            }
            else
            {
                string cod;
                string des;
                double precio;
                string id;
                if (e.CommandName == "btnComprar")
                {
                    dlsProductos.SelectedIndex = e.Item.ItemIndex;

                    id = ((Label)this.dlsProductos.SelectedItem.FindControl("lblProdCod")).Text;
                    cod = ((Label)this.dlsProductos.SelectedItem.FindControl("lblCodigo")).Text;
                    des = ((Label)this.dlsProductos.SelectedItem.FindControl("lblNombrePro")).Text;
                    precio = double.Parse(((Label)this.dlsProductos.SelectedItem.FindControl("lblPrecio")).Text);
                    AgregarItem(id, cod, des, precio);
                    ((TextBox)this.dlsProductos.SelectedItem.FindControl("txtCantidad")).Text = "";
                    //dlsProductos.TemplateControl.FindControl("txtcantidad")

                    //(TextBox)(this.dlsProductos.SelectedItem.
                    // lblAgregado.Text = "Producto Agregado: " + nom + " " + des;
                    //Session["prueba"] = "Sesión usuario prueba";

                }
            }

        }





    }
}