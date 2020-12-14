using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmAccesoAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ENVIAR_Click(object sender, EventArgs e)
        {
            //string error;
            Administrador admin = negAdministrador.Instancia.Logueo(document.Text,pass.Text) ;
            //error = (string)Session["error"];
            if (admin.Admin_estado == 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alerta('Datos incorrectos');", true);
            }
            else
            {
                Session["Admin"] = admin;
                Response.Redirect("FrmClientes.aspx");
            }
        }
    }
}