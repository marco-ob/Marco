using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class FrmInsertarProductos : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            //if (Session["Admin"] != null)
            //{
                if (!Page.IsPostBack)
                {
                    //selectCate.DataTextField = "cate_nombre";
                    //selectCate.DataValueField = "cate_id";
                    selectCate.DataSource = negCategoria.Instancia.ListarCombo();
                    selectCate.DataBind();
                 }
        //} 
        //    else
        //    {
        //        Response.Redirect("FrmAccesoAdmin.aspx");
        //    }

        }

        protected void btnSubir_Click(object sender, EventArgs e)
        {
            //Obtener datos de la imagen
            int tamanio = fuploadImagen.PostedFile.ContentLength;
            byte[] ImagenOriginal = new byte[tamanio];
            fuploadImagen.PostedFile.InputStream.Read(ImagenOriginal, 0, tamanio);
            Bitmap ImagenOriginalBinaria = new Bitmap(fuploadImagen.PostedFile.InputStream);


            //Crear una imagen Thumbnail
            System.Drawing.Image imgThumbnail;
            int TamanioThumbnail = 200;
            imgThumbnail = RedimencionarImagen(ImagenOriginalBinaria,TamanioThumbnail);
            byte[] bImagenThumbnail = new byte[TamanioThumbnail];

            ImageConverter Convertidor = new ImageConverter();
            bImagenThumbnail = (byte[])Convertidor.ConvertTo(imgThumbnail, typeof(byte[]));


            Productos prod = new Productos();
            prod.Prod_nombre = txtNombreProducto.Text;
            prod.Prod_prec = Convert.ToDouble(txtPrecio.Text);
            prod.Prod_stock = Convert.ToInt32(txtStock.Text);
            prod.Prod_imagen = bImagenThumbnail;
            prod.Prod_titulo_imagen = txtTitulo.Text;
            prod.Prod_descripcion = txtDescripcion.Text;
            Categoria cat = new Categoria();
            cat.Cate_ID = Convert.ToInt32(selectCate.SelectedItem.Value);
            prod.Categoria = cat;

            string respuesta=negProducto.Instancia.InsertarProducto(prod);
            if (respuesta.Equals("Insertado Correctamente")) {
                mensaje.Text = respuesta;
                Vacio();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "modals();", true);
                
            }

        }

        public void Vacio()
        {
            txtNombreProducto.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtTitulo.Text = "";
            txtDescripcion.Text = "";
        }

        public System.Drawing.Image RedimencionarImagen(System.Drawing.Image ImagenOriginal, int Alto) 
        {
            var Radio = (double)Alto / ImagenOriginal.Height;
            var NuevoAncho = (int)(ImagenOriginal.Width * Radio);
            var NuevoAlto = (int)(ImagenOriginal.Height * Radio);
            var NuevaImagenRedimencionada = new Bitmap(NuevoAncho, NuevoAlto);
            var g = Graphics.FromImage(NuevaImagenRedimencionada);
            g.DrawImage(ImagenOriginal, 0, 0, NuevoAncho, NuevoAlto);
            return NuevaImagenRedimencionada;
        }

       
    }
}