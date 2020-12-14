using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                //if (Session["Usuario"] == null)
                //{
                //    Response.Redirect("FrmAccesoCliente.aspx");
                //}

                if (Session["pedido"] != null)
                {


                    DataTable dt = (DataTable)Session["pedido"];
                    if (dt.Rows.Count == 0)
                    {
                        Response.Redirect("FrmCategoriaxProductoLogueado.aspx");
                    }
                    else
                    {
                        cargarcarrito();
                        // Ultimo();
                    }
                }else
                {
                    Response.Redirect("FrmCategoriaxProductoLogueado.aspx");
                }
                
            }


        }


        public void cargarcarrito()
        {
            GridView1.DataSource = Session["pedido"];
            GridView1.DataBind();
            CalcularIGVxTotal();
        }

        private void CalcularIGVxTotal()
        {
            int i;
            double total = 0, prec = 0, subtotal = 0, igv;
            string cod, desc;
            int cant;

            var items = (DataTable)Session["pedido"];
            //DataRow fila = items.NewRow();
            for (i = 0; i < GridView1.Rows.Count; i++)
            {
                cod = (GridView1.Rows[i].Cells[1].Text);
                desc = (GridView1.Rows[i].Cells[2].Text);
                prec = System.Convert.ToDouble(GridView1.Rows[i].Cells[3].Text);
                // cant = System.Convert.ToInt16(((TextBox)this.GridView1.Rows[i].Cells[3].FindControl("TextBox1")).Text);
                cant = Convert.ToInt32((GridView1.Rows[i].Cells[4]).Text);

                double prec1 = System.Convert.ToDouble(prec);
                subtotal = cant * prec1;
                GridView1.Rows[i].Cells[5].Text = subtotal.ToString();
                foreach (DataRow dr in items.Rows)
                {
                    if (dr["CODIGO"].ToString() == cod.ToString())
                    {
                        dr["CANTIDAD"] = cant;
                        dr["SUBTOTAL"] = subtotal;
                    }
                }

                total = total + subtotal;
            }

            igv = total * 0.18;
            subtotal = total - igv;

            lblIGV.Text = igv.ToString("0.00");
            lblSubTotal.Text = subtotal.ToString("0.00");
            lblTotal.Text = total.ToString("0.00");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("FrmCategoriaxProductoLogueado.aspx");
        }
     

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmRegistroPedido.aspx");
        }

        /* private void Ultimo()
         {
             negPedido cnper = new negPedido();
             List<Pedido> per = cnper.UltimoEmp();
             foreach (Pedido ma in per)
             {
                 int codigo = 0;
                 codigo = Convert.ToInt32(ma._codigo);
                 codigo = codigo + 1;
                 if (codigo < 10)
                 {
                     ma._codigo = "000" + codigo.ToString();
                 }
                 if (codigo < 100 && codigo > 9)
                 {
                     ma._codigo = "00" + codigo.ToString();
                 }
                 if (codigo < 1000 && codigo > 99)
                 {
                     ma._codigo = "0" + codigo.ToString();
                 }
                // txtCodigo.Text = ma.Codigo;
             }
         }*/


    
}
}