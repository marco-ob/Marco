<%@ Page Title="" Language="C#" MasterPageFile="~/INICIO.Master" AutoEventWireup="true" CodeBehind="FrmAccesoCliente.aspx.cs" Inherits="CapaPresentacion.FrmAccesoCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Estilos/prueba.css"  rel="stylesheet"/>
    <script type="text/javascript">

        
        
        function alerta(numero) {
            setTimeout(function () { alert(numero); }, 1000);

        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container mb-5">
        <div class="row">
            <div class="col-lg-3 col-md-2"></div>
            <div class="col-lg-6 col-md-8 login-box">
                <div class="col-lg-12 login-key">
                    <i class="fa fa-key" aria-hidden="true"></i>
                </div>
                <div class="col-lg-12 login-title">
                    INICIAR SESIÓN
                </div>

                <div class="col-lg-12 login-form">
                    <div class="col-lg-12 login-form">
                            <div class="form-group">
                                <label class="form-control-label text-light">CORREO</label>%>
                                <asp:TextBox ID="usuarios" runat="server" CssClass="form-control" placeholder="Ingrese su correo electrónico"></asp:TextBox>
                               
                            </div>
                            <div class="form-group">
                                 <asp:RequiredFieldValidator ID="rfv_usuario" runat="server" ErrorMessage="El correo es requerido" ControlToValidate="usuarios" CssClass="text-light"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="revemail" runat="server" ErrorMessage="Formato de email incorrecto" CssClass="text-light" ControlToValidate="usuarios" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                </div>
                            <div class="form-group ">
                                <label class="form-control-label text-light">PASSWORD</label>
                                 <asp:TextBox ID="password1" runat="server" CssClass="form-control" placeholder="Ingrese su password" TextMode="Password"></asp:TextBox>
                                 
                            </div>
                            <div class="form-group">
                                <asp:RequiredFieldValidator ID="rfv_password" runat="server" ErrorMessage="El password es requerido" CssClass="text-light" ControlToValidate="password1"></asp:RequiredFieldValidator>
                         
                            </div>
                            <div class="col-lg-12 loginbttm">
                                <div class="col-lg-6 login-btm login-text">
                                    <a href="FrmInsertarCliente.aspx" class="text-light">Registrarse</a> 
                                </div>
                                <div class="col-lg-6 login-btm login-button">
                                    
                                    <asp:Button runat="server" ID="ENVIAR" Text="LOGIN" class="btn btn-outline-primary" OnClick="btnLogin_Click"/>
                                </div>
                            </div>
                    </div>
                </div>
                <div class="col-lg-3 col-md-2"></div>
            </div>
        </div>
         </div>






</asp:Content>
