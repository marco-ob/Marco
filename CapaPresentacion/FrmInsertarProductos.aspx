<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmInsertarProductos.aspx.cs" Inherits="CapaPresentacion.FrmInsertarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
 


    
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>

    <style type="text/css">
body
{
background-image:
url('/Imagenes/Producto/produc.jpg');
background-repeat:no-repeat;
background-size:cover;
background-position:center center;
background-attachment:fixed;

}
</style>

     <script type="text/javascript">

        
        
        function alerta(numero) {
            setTimeout(function () { alert(numero); }, 1000);

         }

         function modals() {

             $('#myModal').modal('show');
         }

     </script>
</head>
<body>


    <form id="form1" runat="server">

        <div class="container">

            <div class="row">
              <div class="col">
                 
                </div>
             <div class="col">
            
                <div class="input-group mb-3">
                            <h1 style="color:white">Registrar Productos</h1>
                       </div>
                 <div class="input-group mb-3">
                            
                            <asp:TextBox ID="txtNombreProducto" CssClass="form-control" placeholder="Nombre de producto" runat="server"></asp:TextBox>
                             
                </div>
                      <div class="input-group mb-3">
                            <asp:TextBox ID="txtPrecio" CssClass="form-control" placeholder="Precio" runat="server"></asp:TextBox>
                            
                      </div>
                        

                 <div class="input-group mb-3">
                            <asp:TextBox ID="txtStock" CssClass="form-control" placeholder="Stock" runat="server"></asp:TextBox>
                          
                 </div>
                 
                 <div class="input-group mb-3">
                            <asp:TextBox ID="txtDescripcion" CssClass="form-control" placeholder="Descripcion del producto" runat="server"></asp:TextBox>
                           
                 </div>
                 <div class="input-group mb-3">
                            <p style="color:white">Seleccionar categoría:</p>
                            <asp:DropDownList ID="selectCate" DataTextField="cate_nombre" DataValueField="cate_id" runat="server">
                            </asp:DropDownList>
                        
                  </div>
                 <div class="input-group mb-3">
                    <p style="color:white"> Archivo:</p>
                    <asp:FileUpload ID="fuploadImagen" accept=".jpg" runat="server" CssClass="form-control" />
                     
                 </div>
                   <div class="input-group mb-3">
                       <p style="color:white"> Titulo de imagen:</p>
                        <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
                    
                       </div>
                  <div class="input-group mb-3">

                    <asp:Button ID="btnSubir" runat="server" Text="REGISTRAR PRODUCTO" CssClass="btn btn-success" OnClick="btnSubir_Click" />
                      <button type="button" runat="server" class="btn btn-primary ml-2"  onclick="location.href='FrmProductos.aspx'">
			VOLVER
		</button>
                </div>
                  
                     <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                        <div class="modal-dialog" role="document">
                        <div class="modal-content">
                          <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel">Registro de Producto</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                              <span aria-hidden="true">&times;</span>
                            </button>
                          </div>
                          <div class="modal-body">
                            <asp:Label id="mensaje" runat="server"></asp:Label>
                          </div>
                          <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                
                              </div>
                        </div>
                      </div>
                    </div>


                </div>      
                
            <div class="col">
             
                <div class="input-group mb-5">
                    </div>
                <div class="input-group mb-5">
                    </div>
                <div class="input-group mb-4">
                    </div>
                <div class="input-group mb-4">
                      <asp:RequiredFieldValidator ID="rfv_Producto" runat="server" ErrorMessage="El nombre es requerido" CssClass="text-light" ControlToValidate="txtNombreProducto"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rev_producto" runat="server" CssClass="text-light" 
            ErrorMessage="Solo letras" ValidationExpression="^[a-zA-Z ]*$" ControlToValidate="txtNombreProducto" ></asp:RegularExpressionValidator>
                
                </div>
                <div class="input-group mb-4">
                    
                 <asp:RequiredFieldValidator ID="rfv_precio" runat="server" ErrorMessage="El precio es requerido" CssClass="text-light" ControlToValidate="txtPrecio" ></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="rev_precio" runat="server" CssClass="text-light" 
            ErrorMessage="Formato 00.00" ControlToValidate="txtPrecio" ValidationExpression="[0-9]{1,4}[.][0-9]{1,3}"  ></asp:RegularExpressionValidator>
                        
                
                </div>
                <div class="input-group mb-5">
                      <asp:RequiredFieldValidator ID="rfv_stock" runat="server" ErrorMessage="El stock es requerido" CssClass="text-light" ControlToValidate="txtStock"></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="rev_stock" runat="server" CssClass="text-light" 
            ErrorMessage="Mayor 0 y menor que 100" ControlToValidate="txtStock" ValidationExpression="[0-9]{1,4}" ></asp:RegularExpressionValidator>
                 
                
                </div>
                <div class="input-group mb-3">
                    
                   <asp:RequiredFieldValidator ID="rfv_descripcion" runat="server" ErrorMessage="La descripcion es requerido" CssClass="text-light" ControlToValidate="txtDescripcion"></asp:RequiredFieldValidator>
                
                </div>
                <div class="input-group mb-5">
                    </div>
                <div class="input-group mb-2">
                    </div>  
                <div class="input-group mb-5">
                    
                 <asp:RequiredFieldValidator ID="rfv_archivo" runat="server" ErrorMessage="El archivo es requerido" CssClass="text-light" ControlToValidate="fuploadImagen"></asp:RequiredFieldValidator>
             
                </div>
                <div class="input-group mb-3">
                    
                 <asp:RequiredFieldValidator ID="rfv_titulo" runat="server" ErrorMessage="El titulo es requerido" CssClass="text-light" ControlToValidate="txtTitulo"></asp:RequiredFieldValidator>
          
                </div>






            </div>
            </div>


        </div>
       


    </form>
</body>
</html>
