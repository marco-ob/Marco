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
    public partial class FrmAccesoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {


            //Cliente usu = negCliente.Instancia.Logueo(usuario.Value, password.Value);
            Cliente usu = negCliente.Instancia.Logueo(usuarios.Text, password1.Text);
            if (usu.Clie_estado == 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alerta('Datos incorrectos');", true);
            }
            else
            {

                Session["Usuario"] = usu;
                Response.Redirect("FrmCategoriaxProductoLogueado.aspx");
            }
            }
    }
}