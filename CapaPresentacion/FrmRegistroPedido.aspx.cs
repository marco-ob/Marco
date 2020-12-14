using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using CapaNegocio;
using System.Data;

namespace CapaPresentacion
{
    public partial class FrmRegistroPedido : System.Web.UI.Page

    {

        Cliente usu = new Cliente();
        List<CarritoCompras> listacarrito = new List<CarritoCompras>();
        negCarrito negca = new negCarrito();
        protected void Page_Load(object sender, EventArgs e)
        {
                usu=(Cliente)Session["Usuario"];

            nombre.Text = usu.Clie_nombre;
            apellido.Text = usu.Clie_apellidos;
            correo.Text = usu.Clie_correo;
            direccion.Text = usu.Clie_direccion;
            telefono.Text = Convert.ToString(usu.Clie_celular);
           

        }

      

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            PedidoNuevo();
            InsertarCarrito();


        }

        public void PedidoNuevo()
        {
            Pedido ped = new Pedido();
            ped.Pedi_nombre = nombre.Text;
            ped.Pedi_apellidos = apellido.Text;
            ped.Pedi_direccion_envio = direccion.Text;
            ped.Pedi_tp_tarjeta = tptarjeta.SelectedItem.Value;
            ped.Pedi_nro_tarjeta = Convert.ToInt64(nrotarjeta.Text);
            ped.Pedi_nro_cvv = tarjeta_ccv.Text;

            usu = (Cliente)Session["Usuario"];
            ped.Clie_ID = usu.Clie_Id;
            ped.Pedi_Telefono = Convert.ToInt32(telefono.Text);
            ped.Pedi_correo = correo.Text;
            ped.Pedi_caducidad = tarjeta_caducidad_m.Text + "/" + tarjeta_caducidad_a.Text;
            ped.Pedi_tp_documento = tpdocumento.SelectedItem.Value;
            ped.Pedi_nro_documento = nrodocumento.Text;

            negPedido.Instancia.ResgistrarPedido(ped);
        }

        public void InsertarCarrito()
        {
            int codigocarrito = negPedido.Instancia.Cod_Detalle_Carrito();

            DataTable carrito = new DataTable();
            carrito=(DataTable)Session["pedido"];
            
            for(int i = 0; i < carrito.Rows.Count; i++)
            {
                CarritoCompras detallecarrito = new CarritoCompras();

                detallecarrito.Pedi_ID = codigocarrito;
                detallecarrito.Prod_ID = Convert.ToInt32(carrito.Rows[i]["ID"].ToString());
                detallecarrito.Carcom_cantidad= Convert.ToInt32(carrito.Rows[i]["CANTIDAD"].ToString());
                detallecarrito.Carcom_prec_unit= Convert.ToDecimal(carrito.Rows[i]["PRECIO"].ToString());
                detallecarrito.Carcom_total= Convert.ToDecimal(carrito.Rows[i]["SUBTOTAL"].ToString());
                listacarrito.Add(detallecarrito);

            }
            string rpta=negca.InsertarCarrito(listacarrito);

            if (rpta.Equals("ok"))
            {
               
                Response.Redirect("Factura.aspx");
            }



        }

    }
}