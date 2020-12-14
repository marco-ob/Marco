<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRegistroCategorias.aspx.cs" Inherits="CapaPresentacion.FrmRegistroCategorias" %>

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
url('/Imagenes/Producto/categoria.jpg');
background-repeat:no-repeat;
background-size:cover;
background-position:center center;
background-attachment:fixed;

}
</style>
</head>
<body>
    <div class="container pt-5 ">
    <div class="row justify-content-center h-100">
    <form id="form1" runat="server">
        
            
                <div class="col-12 col-md-8 col-lg-8 col-xl-6">
                    <div class="row">
                        <div class="col text-center">
                            <h1  style="color:white">¡Bienvenido!</h1>
                            <p class="text-h3" style="color:white" > Por favor ingresar el nombre de la categoría respectiva, y que guarde relación con los productos a las cuales se agruparán posteriormente</p>
                        </div>
                    </div>
                    <div class="row align-items-center">
                        <div class="col mt-4">
                            <label for="form1"  style="color:white">Nombre de categoría</label>
                            <%--<input id="inputNombre" runat="server" type="text" class="form-control" placeholder="Ej.: Aguas y bebidas" />--%>
                            <asp:TextBox ID="nombre" runat="server" class="form-control" placeholder="Ej.: Aguas y bebidas"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="rfv_categoria" runat="server" ErrorMessage="La Categoria es requerido" CssClass="text-light bg-danger" ControlToValidate="nombre"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rev_categoria" runat="server" CssClass="text-light bg-danger"
            ErrorMessage="Solo caracteres" ValidationExpression="^[a-zA-Z ]*$" ControlToValidate="nombre"  ></asp:RegularExpressionValidator>
                        </div>
                    </div>

               <div class="form-footer text-center mt-4">
                 
                 <asp:Button ID="Button1" class="btn btn-primary btn-success" runat="server" OnClick="Button1_Click" Text="Insertar"/> 
                   <button type="button" runat="server" class="btn btn-danger ml-2"  onclick="location.href='FrmCategorias.aspx'">
			VOLVER
		</button>
                 
                   <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                        <div class="modal-dialog" role="document">
                        <div class="modal-content">
                          <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel">Registro Categoria</h5>
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

                </div>


            <script src="Estilos/javasc.js" type="text/javascript"></script>
        </form>
        </div>
    </div>
</body>
</html>
