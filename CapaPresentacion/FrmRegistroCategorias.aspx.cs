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
    public partial class FrmRegistroCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] != null)
            {

            }
            else
            {
                Response.Redirect("FrmAccesoAdmin.aspx");
            }
        }


       

       
        protected void Button1_Click(object sender, EventArgs e)
        {
            Insertar_Categoria();
            Vacio();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "modals();", true);
        }

        void Insertar_Categoria() 
        {
            string aviso;
            Categoria cat = new Categoria();

            cat.Cate_nombre = nombre.Text;

            aviso = negCategoria.Instancia.InsertarCategoria(cat);

            mensaje.Text = aviso;
        }
        private void Vacio()
        {
            nombre.Text = "";
        }

        
    }
}