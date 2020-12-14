<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmInsertarCliente.aspx.cs" Inherits="CapaPresentacion.FrmInsertarCliente" %>

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
url('/Imagenes/Producto/cliente.jpg');
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
        
        <div class="row">
    <div class="col">
    </div>
    <div class="col">
        <div class="form-header justify-content-center">
          <h3 class="display-3" style="text-align:center;color:white" ><i class="fa fa-user">Formulario de registro</i></h3>

                <div class="input-group mb-3">
                    <span class="input-group-text" >Nombres</span>
                                  
                 <asp:TextBox ID="nombre" runat="server" class="form-control" Width="350px" placeholder="Ingresa sus nombres" aria-label="Nombres" ></asp:TextBox>
                     <asp:RequiredFieldValidator ID="rfv_nombre" runat="server" ErrorMessage="El nombre es requerido" CssClass="text-light bg-danger" ControlToValidate="nombre"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rev_nombre" runat="server" CssClass="text-light bg-danger"
            ErrorMessage="Solo se admite Caracteres" ValidationExpression="^[a-zA-Z ]*$" ControlToValidate="nombre"></asp:RegularExpressionValidator>
                 &nbsp&nbsp
                    </div>
                    
             
              <div class="input-group mb-3">
                    <span class="input-group-text"  >Apellidos</span>
                  
                    <asp:TextBox ID="apellido" runat="server" class="form-control" Width="350px" placeholder="Ingresa sus apellidos" aria-label="apellido"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="rfv_apellido" runat="server" ErrorMessage="El apellido es requerido" CssClass="text-light bg-danger" ControlToValidate="apellido" ></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="rev_apellido" runat="server" ErrorMessage="Solo se admite Caracteres" CssClass="text-light bg-danger" ValidationExpression="^[a-zA-Z ]*$" ControlToValidate="apellido"></asp:RegularExpressionValidator>
                  &nbsp&nbsp
             </div>

              <div class="input-group mb-3">
                  
                    <span class="input-group-text" >Dirección</span>
                  
                 <asp:TextBox ID="direccion" runat="server" class="form-control" Width="350px" placeholder="Ingresa su direccion" aria-label="direccion" aria-describedby="basic-addon1"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfv_direccion" runat="server" ErrorMessage="La direccion es requerido" CssClass="text-light bg-danger" ControlToValidate="direccion"></asp:RequiredFieldValidator>
                  &nbsp&nbsp
                  </div>
             <div class="input-group mb-3">
                      <div class="input-group-prepend">
                        <span class="input-group-text">Celular</span>
                      </div>
                       <asp:TextBox ID="celular" runat="server" class="form-control" Width="350px"  placeholder="Ingresa su celular" aria-label="celular" aria-describedby="basic-addon1"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rfv_celular" runat="server" ErrorMessage="El celular es requerido" CssClass="text-light bg-danger" ControlToValidate="celular"></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="rev_celular" runat="server" CssClass="text-light bg-danger"
            ErrorMessage="Solo numeros de 9 digitos" ValidationExpression="[0-9]{9}" ControlToValidate="celular"></asp:RegularExpressionValidator>
              </div>


             <div class="input-group mb-3">
               
                    <span class="input-group-text">Correo</span>
                 
                 <asp:TextBox ID="correo" runat="server" class="form-control" Width="350px" placeholder="Ingresa su correo" TextMode="Email" aria-label="correo" aria-describedby="basic-addon1"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="rfv_correo" runat="server" ErrorMessage="El correo es requerido" CssClass="text-light bg-danger" ControlToValidate="correo"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="rev_correo" runat="server" CssClass="text-light bg-danger"
            ErrorMessage="ejemplo@gmail.com" ControlToValidate="correo" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ></asp:RegularExpressionValidator>
                  &nbsp&nbsp
                 </div>
             <div class="input-group mb-3">
                      
                        <span class="input-group-text">Contraseña</span>
                      
                      <asp:TextBox ID="password" runat="server" class="form-control" Width="350px"  placeholder="Ingresa su password" TextMode="Password" aria-label="password" aria-describedby="basic-addon1"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_password" runat="server" ErrorMessage="El password es requerido" CssClass="text-light bg-danger" ControlToValidate="password"></asp:RequiredFieldValidator>
             </div>

             <div class="input-group mb-3">
                  <div class="input-group-prepend">
                      <label class="input-group-text" for="tipo_documento" >Tipo de documento</label>
                  </div>
                  <select class="custom-select" id="tipo_documento" runat="server">
                    <option selected>Opciones...</option>
                    <option value="DNI">DNI</option>
                    <option value="RUC">RUC</option>
                    <option value="Pasaporte">Pasaporte</option>
                  </select>
               <asp:RequiredFieldValidator ID="rfv_tipodoc" runat="server" ErrorMessage="Seleccione un tipo" CssClass="text-light bg-danger" ControlToValidate="tipo_documento" ></asp:RequiredFieldValidator>
             </div>
                 <div class="input-group mb-3">
                      <div class="input-group-prepend">
                        <span class="input-group-text" >Número de documento</span>
                      </div>
                     <asp:TextBox ID="documento" runat="server" class="form-control" Width="200px" placeholder="Ingresa su documento" aria-label="documento" aria-describedby="basic-addon1"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="rfv_documento" runat="server" ErrorMessage="El documento es requerido" CssClass="text-light bg-danger" ControlToValidate="documento"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="rev_documento" runat="server" CssClass="text-light bg-danger"
            ErrorMessage="DNI 8 digitos, RUC 11 y Carnet 12" ValidationExpression="[0-9]{8,12}" ControlToValidate="documento"></asp:RegularExpressionValidator>
                 </div>
                 
            <div class="form-footer">
                 
                                
                <asp:Button ID="enviarcliente" class="btn btn-primary btn-dark" runat="server" Text="Registrarse" OnClick="enviarcliente_Click" />
                <button type="button" runat="server" class="btn btn-danger ml-2"  onclick="location.href='FrmAccesoCliente.aspx'">
			VOLVER
		</button>  
                

                        <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                        <div class="modal-dialog" role="document">
                        <div class="modal-content">
                          <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel">Registro Cliente</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                              <span aria-hidden="true">&times;</span>
                            </button>
                          </div>
                          <div class="modal-body">
                            <asp:Label id="mensaje" runat="server"></asp:Label>
                          </div>
                          <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
<%--                              <asp:Button ID="Button1" runat="server" Text="Ir a Pagina Principal" OnClick="Button1_Click" />--%>
                          </div>
                        </div>
                      </div>
                    </div>  



            </div>
            </div>
    </div>
    <div class="col">
    </div>
            </div>
         

        
    </form>

</body>
</html>
