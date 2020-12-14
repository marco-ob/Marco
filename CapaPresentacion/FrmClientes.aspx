<%@ Page Title="" Language="C#" MasterPageFile="~/INICIO_ADMIN.Master" AutoEventWireup="true" CodeBehind="FrmClientes.aspx.cs" Inherits="CapaPresentacion.FrmClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    &nbsp&nbsp
    <div >
    <asp:GridView ID="listaClientes" runat="server" CssClass="ml-2" AutoGenerateColumns="false" DataKeyNames="Clie_Id"
        CellPadding="1"  ForeColor="#333333" GridLines="None" 
        OnRowCancelingEdit="rowCancelEditEvent" OnRowDeleting="rowDeletingEvent" OnRowEditing="rowEditingEvent" OnRowUpdating="rowUpdatetingEvent" >
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />


        <Columns>
            <asp:TemplateField HeaderText="Id">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server"  Text='<% # Bind("Clie_ID")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtid" Width="25px" runat="server" ReadOnly="true" Text='<% # Bind("Clie_ID")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="Codigo">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<% # Bind("Clie_codigo")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtcodigo" Width="75px" runat="server" ReadOnly="true" Text='<% # Bind("Clie_codigo")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Nombre">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<% # Bind("Clie_nombre")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtnombre" Width="150px" runat="server" Text='<% # Bind("Clie_nombre")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Apellido" >
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<% # Bind("Clie_apellidos")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtapellido" runat="server" Width="135px" Text='<% # Bind("Clie_apellidos")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Dirección">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<% # Bind("Clie_direccion")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtdireccion" runat="server" Text='<% # Bind("Clie_direccion")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Celular">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<% # Bind("Clie_celular")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtcelular" runat="server"  Width="100px" Text='<% # Bind("Clie_celular")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Fecha">
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<% # Bind("Clie_fech_registro")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtfech" runat="server"  ReadOnly="true" Text='<% # Bind("Clie_fech_registro")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Correo">
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<% # Bind("Clie_correo")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtcorreo" runat="server" Text='<% # Bind("Clie_correo")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Password">
                <ItemTemplate>
                    <asp:Label ID="Label9" runat="server" Text='<% # Bind("Clie_clave")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtpassword" runat="server" Width="85px" Text='<% # Bind("Clie_clave")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Tipo_Doc">
                <ItemTemplate>
                    <asp:Label ID="Label10" runat="server" Text='<% # Bind("Clie_tp_documento")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txttipodoc" Width="50px" runat="server" Text='<% # Bind("Clie_tp_documento")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Documento">
                <ItemTemplate>
                    <asp:Label ID="Label11" runat="server" Text='<% # Bind("Clie_nro_documento")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtdocumento" Width="85px" runat="server" Text='<% # Bind("Clie_nro_documento")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Estado">
                <ItemTemplate>
                    <asp:Label ID="Label12"  runat="server"  Text='<% # Bind("Clie_estado")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtestado" Width="25px" runat="server" Text='<% # Bind("Clie_estado")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>


            <asp:CommandField ButtonType="Button" ShowEditButton="true" ShowDeleteButton="false" />
        </Columns>




    </asp:GridView>
        </div>



    
            <%--<script src="js/Clientes.js" type="text/javascript"></script>--%>
</asp:Content>
