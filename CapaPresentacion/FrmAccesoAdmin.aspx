<%@ Page Title="" Language="C#" MasterPageFile="~/INICIO.Master" AutoEventWireup="true" CodeBehind="FrmAccesoAdmin.aspx.cs" Inherits="CapaPresentacion.FrmAccesoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Estilos/prueba.css"  rel="stylesheet"/>

    <script type="text/javascript">

        
        //function alerta(numero) {
        //    alert(numero);
        //}
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
                    LOGUEO ADMIN
                </div>

                <div class="col-lg-12 login-form">
                    <div class="col-lg-12 login-form">
                            <div class="form-group">
                                <label class="form-control-label text-light">DOCUMENTO</label>
                                 <asp:TextBox ID="document" runat="server" CssClass="form-control" placeholder="Ingrese su docummento "></asp:TextBox>
                               

                            </div>
                        <div class="form-group">
                                <asp:RequiredFieldValidator ID="rfv_documento" runat="server" ErrorMessage="El documento es requerido" CssClass="text-light" ControlToValidate="document"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="rev_documento" runat="server" ErrorMessage="DNI: 8 digitos" ControlToValidate="document" CssClass="text-light" ValidationExpression="[0-9]{8,12}"></asp:RegularExpressionValidator>
                            </div>
                            <div class="form-group ">
                                <label class="form-control-label text-light">PASSWORD</label>
                                 <asp:TextBox ID="pass" runat="server" CssClass="form-control" TextMode="Password" placeholder="Ingrese su contraseña"></asp:TextBox>
                            </div>
                        <div class="form-group">
                                <asp:RequiredFieldValidator ID="rfv_password" runat="server" ErrorMessage="El password es requirido" CssClass="text-light" ControlToValidate="pass"></asp:RequiredFieldValidator>
                              
                            </div>
                            <div class="col-lg-12 loginbttm">
                                <div class="col-lg-6 login-btm login-text">
                                    <a href="FrmRegistroCliente.aspx" class="text-light"></a> 
                                </div>
                                <div class="col-lg-6 login-btm login-button">
                                    
                                    <asp:Button runat="server" ID="ENVIAR" Text="LOGIN" class="btn btn-outline-primary" OnClick="ENVIAR_Click"/>
                                </div>
                            </div>
                    </div>
                </div>
                <div class="col-lg-3 col-md-2"></div>
            </div>
        </div>
         </div>





</asp:Content>
