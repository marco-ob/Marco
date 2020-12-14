using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace CapaPresentacion
{
    public partial class INICIO_CLIENTE : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Usuario"] != null)
            {
                Cliente clie;
                clie = (Cliente)Session["Usuario"];
                NombreUsu.Text = "Bienvenido: " + clie.Clie_nombre;
            }

        }

        protected void Cerrar_Click(object sender, EventArgs e)
        {
            Session.Remove("Usuario");
            Response.Redirect("FrmCategoriaxProducto.aspx");
        }
    }
}