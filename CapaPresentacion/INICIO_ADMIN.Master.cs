using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class INICIO_ADMIN : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] != null)
            {
                Administrador ad = new Administrador();
                ad = (Administrador)Session["Admin"];
                NombreAdmin.Text = "Bienvenido  :  " + ad.Admin_nombre;
            }

        }

        protected void Cerrar_Click(object sender, EventArgs e)
        {
            Session.Remove("Admin");
            Response.Redirect("FrmCategoriaxProducto.aspx");
        }
    }
}