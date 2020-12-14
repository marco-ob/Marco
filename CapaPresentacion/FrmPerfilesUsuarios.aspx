<%@ Page Title="" Language="C#" MasterPageFile="~/INICIO.Master" AutoEventWireup="true" CodeBehind="FrmPerfilesUsuarios.aspx.cs" Inherits="CapaPresentacion.FrmPerfilesUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container pt-5 h-25">
        <h1 class="text-center">Elegir el tipo de usuario</h1>
            &nbsp
        <div class="row justify-content-center h-25">
            <div class="col-sm-5 align-self-center text-center">
                <h3 class="text-center">Cliente</h3>
            </div>
            <div class="col-sm-5 align-self-center text-center">
                <h3 class="text-center">Administrador</h3>
            </div>
            </div>
        <div class="row justify-content-center h-25">
            <div class="col-sm-5 align-self-center text-center">
                    <a href="FrmAccesoCliente.aspx"><img src="Imagenes/Usuario/User.jpg" class="float-right rounded-circle bg-dark" width="300" height="300"></a>
                    
            </div>
            
            
            <div class="col-sm-2 align-self-center text-center">
            </div>
            <div class="col-sm-5 align-self-center text-center">
                    <a href="FrmAccesoAdmin.aspx"><img src="Imagenes/Usuario/Admin.jpg"  class="float-left rounded-circle bg-dark" width="300" height="300"></a>      
            </div>
            
        </div>
        <%--<div class="row pb-5 justify-content-center h-25">
            <div class="col-sm-5 pb-5 align-self-center text-center"><p>Usuario</p></div>
            <div class="col-sm-5 pb-5 align-self-center text-center"><p>Administrador</p></div>
        </div>--%>    
    </div>




</asp:Content>
