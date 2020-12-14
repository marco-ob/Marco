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
    public partial class FrmInsertarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //    Insertar_cliente();

        //}

        void Insertar_cliente()
        {

           
            try
            {
                String aviso;
                Cliente clie = new Cliente();
                clie.Clie_nombre = nombre.Text;
                clie.Clie_apellidos = apellido.Text;
                clie.Clie_direccion = direccion.Text;
                clie.Clie_celular = Convert.ToInt32(celular.Text);
                clie.Clie_correo = correo.Text;
                clie.Clie_clave = password.Text;
                clie.Clie_tp_documento = tipo_documento.Items[tipo_documento.SelectedIndex].Text;
                clie.Clie_nro_documento = documento.Text;

                aviso = negCliente.Instancia.InsertarCliente(clie);
                mensaje.Text = aviso;
                Vacio();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "modals();", true);
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "alerta", "alerta('error al insertar')", false);
            }
            catch (Exception e)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alerta", "alerta('error al insertar')", false);
            }

            
        }

        protected void enviarcliente_Click(object sender, EventArgs e)
        {
            Insertar_cliente();
        }

        private void Vacio()
        {
            nombre.Text = "";
            apellido.Text = "";
            direccion.Text = "";
            celular.Text = "";
            correo.Text = "";
            password.Text = "";
            documento.Text = "";
        }
        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //    Response.Redirect("FrmCategoriaxProducto.aspx");
        //}
    }
}