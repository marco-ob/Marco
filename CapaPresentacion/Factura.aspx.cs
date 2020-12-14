using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Factura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["pedido"] != null)
            {

                Session.Remove("pedido");
                int codped;
                negPedido negped = new negPedido();
                ReporteFactura factura = new ReporteFactura();
                codped = negped.Cod_Detalle_Carrito();
                factura.SetParameterValue("@pedi_id", codped);
                CrystalReportViewer1.ReportSource = factura;
            }
            else
            {
                Response.Redirect("FrmCategoriaxProductoLogueado.aspx");
            }

        }
    }
}