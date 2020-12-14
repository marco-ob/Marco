<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRegistroPedido.aspx.cs" Inherits="CapaPresentacion.FrmRegistroPedido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>
    </title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>

      <style type="text/css">
body
{
background-image:
url('/Imagenes/Producto/Pedido.jpg');
background-repeat:no-repeat;
background-size:cover;
background-position:center center;
background-attachment:fixed;

}
</style>



</head>
<body>
    <form id="form1" runat="server" >

        <div class="container">

         <div class="row">
        <div class="col">
          
        </div>
        <div class="col">

        
  
            <div class="text-center">
              <h2>Concretar Compra</h2>
            </div>
  
 
            <div class="input-group mb-3">

        
          
            <label for="nombre">Nombre</label>
            <asp:TextBox id="nombre"  CssClass="form-control" runat="server"></asp:TextBox>
          

            </div>


            <div class="input-group mb-3">

          
            <label for="apellido">Apellido</label>
            <asp:TextBox id="apellido" CssClass="form-control" runat="server"></asp:TextBox>
          
             </div>

            <div class="input-group mb-3">

            <label for="telefono">Telefono/Celular</label>
            <asp:TextBox id="telefono" CssClass="form-control" runat="server"></asp:TextBox>
          </div>

             <div class="input-group mb-3">

            <label for="correo">Correo</label>
            <asp:TextBox id="correo" CssClass="form-control" TextMode="Email" placeholder="nombre@correo.com" runat="server"></asp:TextBox>
          </div>

             <div class="input-group mb-3">

          <label for="direccion">Direccion</label>
          <asp:TextBox id="direccion" CssClass="form-control" placeholder="1234 Calle Principal" runat="server"></asp:TextBox>
            </div>

             <div class="input-group mb-3">

            <label for="tpdocumento">Elegir el tipo de documento</label>
           <asp:DropDownList ID="tpdocumento" CssClass="custom-select d-block w-100" runat="server">
                <asp:ListItem Value="">Seleccionar tipo de documento</asp:ListItem>
                <asp:ListItem Value="DNI">DNI</asp:ListItem>
                <asp:ListItem Value="RUC">RUC</asp:ListItem>
                <asp:ListItem Value="Carnet Extranjería">Carnet Extranjería</asp:ListItem>
            </asp:DropDownList>

          </div>

             <div class="input-group mb-3">

            <label for="nrodocumento">Número de documento</label>
            <asp:TextBox id="nrodocumento" CssClass="form-control" runat="server"></asp:TextBox>
            </div>

        

        <hr>
             <div class="input-group mb-3">


            <label for="tptarjeta">Elegir el tipo de tarjeta</label>
           
              <asp:DropDownList ID="tptarjeta" CssClass="custom-select d-block w-100" runat="server">
                <asp:ListItem Value="">Seleccionar tipo de tarjeta</asp:ListItem>
                <asp:ListItem Value="Visa">Visa</asp:ListItem>
                <asp:ListItem Value="Mastercard">Mastercard</asp:ListItem>
                <asp:ListItem Value="American Express">American Express</asp:ListItem>
            </asp:DropDownList>


          </div>

             <div class="input-group mb-3">



            <label for="nrotarjeta">Número de tarjeta</label>
            <asp:TextBox id="nrotarjeta" CssClass="form-control" runat="server"></asp:TextBox>
           
          </div>       

             <div class="input-group mb-3">



                    <label for="tarjeta_caducidad_m">Caducidad</label>
                    <asp:TextBox id="tarjeta_caducidad_m" placeholder="MM" Width="55px" CssClass="form-control" runat="server"></asp:TextBox>        
                   
                 
                    <asp:TextBox id="tarjeta_caducidad_a" placeholder="AA"  Width="55px" CssClass="form-control" runat="server"></asp:TextBox>      
                  


             
             </div>
                  
              <div class="input-group mb-3">



            <label for="tarjeta_ccv">CVV</label>
              <asp:TextBox id="tarjeta_ccv" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
<%--            <input type="text" id="tarjeta_ccv" class="form-control" />--%>
          </div>
               <div class="input-group mb-3">
                <hr class="mb-4" />
                <asp:Button Text="Confirmar Pago" runat="server" CssClass="btn btn-block btn-lg btn-primary" OnClick="Unnamed_Click"/>
               <%-- <input type="submit" value="Confirmar Pago" class="btn btn-block btn-lg btn-primary" />--%>
    
                </div>
       </div>
        <div class="col">
            <br />
            <div class="input-group mb-3">
                 <br />
            </div>
            
             <div class="input-group mb-4">
                 <asp:RequiredFieldValidator ID="rfv_nombre" runat="server"  CssClass="text-light bg-danger" ErrorMessage="El nombre es requerido"  ControlToValidate="nombre" ></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rev_nombre" runat="server" CssClass="text-light bg-danger"
            ErrorMessage="Solo se admite Caracteres" ValidationExpression="^[a-zA-Z ]*$" ControlToValidate="nombre"></asp:RegularExpressionValidator>
                  
            </div>
             <div class="input-group mb-4">
                 <asp:RequiredFieldValidator ID="rfv_apellido" runat="server" CssClass="text-light bg-danger" ErrorMessage="El apellido es requerido"  ControlToValidate="apellido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" CssClass="text-light bg-danger"
            ErrorMessage="Solo se admite Caracteres" ValidationExpression="^[a-zA-Z ]*$" ControlToValidate="apellido"></asp:RegularExpressionValidator>
            
             </div>
            
             <div class="input-group mb-4">

                 <asp:RequiredFieldValidator ID="rfv_celular" runat="server" ErrorMessage="El celular es requerido" CssClass="text-light bg-danger"  ControlToValidate="telefono" ></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="rev_celular" runat="server" CssClass="text-light bg-danger"
            ErrorMessage="Solo numeros de 9 digitos" ValidationExpression="[0-9]{9}" ControlToValidate="telefono" ></asp:RegularExpressionValidator>
                  
            </div>
            
             <div class="input-group mb-5">

                  <asp:RequiredFieldValidator ID="rfv_correo" runat="server" ErrorMessage="El correo es requerido" CssClass="text-light bg-danger" ControlToValidate="correo" ></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="rev_correo" runat="server" CssClass="text-light bg-danger"
            ErrorMessage="ejemplo@gmail.com" ControlToValidate="correo" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ></asp:RegularExpressionValidator>
                 
            </div>
            
             <div class="input-group mb-4">

                 
                 <asp:RequiredFieldValidator ID="rfv_direccion" runat="server" ErrorMessage="La direccion es requerido" CssClass="text-light bg-danger"  ControlToValidate="direccion"></asp:RequiredFieldValidator>
                
            </div>
            <div class="input-group mb-3">
            <br /><br />    
            </div>
             <div class="input-group mb-3">

                 
                  <asp:RequiredFieldValidator ID="rfv_nrodoc" runat="server" ErrorMessage="El documento es requerido"  CssClass="text-light bg-danger" ControlToValidate="nrodocumento" ></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="rev_nrodoc" runat="server" CssClass="text-light bg-danger"
            ErrorMessage="DNI 8 digitos, RUC 11 y Carnet 12" ControlToValidate="nrodocumento" ValidationExpression="[0-9]{8,12}" ></asp:RegularExpressionValidator>
                 <br />
            </div>
          <div class="input-group mb-4">
          <br /><br /><br /> 
          </div>

             <div class="input-group mb-3">

                    <asp:RequiredFieldValidator ID="rfv_nrotarjeta" runat="server" ErrorMessage="La tarjeta es requerido" CssClass="text-light bg-danger" ControlToValidate="nrotarjeta" ></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="rev_nrotarjeta" runat="server"
            ErrorMessage="Su tarjeta no se encuentra en el rango requerido" ControlToValidate="nrotarjeta" CssClass="text-light bg-danger" ValidationExpression="[0-9]{12,16}" ></asp:RegularExpressionValidator>
                 
            </div>
          
             <div class="input-group mb-3">
                   <asp:RequiredFieldValidator ID="rfv_mm" runat="server" ErrorMessage="El mes es requerido" CssClass="text-light bg-danger" ControlToValidate="tarjeta_caducidad_m" ></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="rev_mm" runat="server" CssClass="text-light bg-danger"
            ErrorMessage="Solo numeros de 2 digitos" ControlToValidate="tarjeta_caducidad_m" ValidationExpression="[0-9]{2}" ></asp:RegularExpressionValidator>
               
                  <asp:RequiredFieldValidator ID="rfv_aa" runat="server" ErrorMessage="El año es requerido" CssClass="text-light bg-danger"  ControlToValidate="tarjeta_caducidad_a" ></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="rev_aa" runat="server" CssClass="text-light bg-danger"
            ErrorMessage="Solo numero de 2 digitos" ControlToValidate="tarjeta_caducidad_a" ValidationExpression="[0-9]{2}" ></asp:RegularExpressionValidator>
            </div>
          <div class="input-group mb-3">
                  <asp:RequiredFieldValidator ID="rfv_cvv" runat="server" ErrorMessage="El CVV es requerido" CssClass="text-light bg-danger" ControlToValidate="tarjeta_ccv" ></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="rev_cvv" runat="server" CssClass="text-light bg-danger"
            ErrorMessage="Solo numero de 3 digitos" ControlToValidate="tarjeta_ccv" ValidationExpression="[0-9]{3}" ></asp:RegularExpressionValidator>
            </div>
          




        </div>
        </div>
        </div>
       
 
    </form>
</body>
</html>
