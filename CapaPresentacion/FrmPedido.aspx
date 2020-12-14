<%@ Page Title="" Language="C#" MasterPageFile="~/INICIO_ADMIN.Master" AutoEventWireup="true" CodeBehind="FrmPedido.aspx.cs" Inherits="CapaPresentacion.FrmPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    &nbsp&nbsp
    <div >
    <asp:GridView ID="listapedidos" runat="server" AutoGenerateColumns="false" DataKeyNames="Pedi_id" CssClass="ml-2"
        CellPadding="1"  ForeColor="#333333"  GridLines="None" 
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


             <asp:TemplateField HeaderText="ID">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server"  Text='<% # Bind("Pedi_id")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtid" Width="50px" runat="server" ReadOnly="true" Text='<% # Bind("Pedi_id")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="Codigo">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<% # Bind("Pedi_codigo")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtcodigo" Width="125px" runat="server" ReadOnly="true" Text='<% # Bind("Pedi_codigo")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="Nombre">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<% # Bind("Pedi_nombre")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtnombre" Width="200px" runat="server" ReadOnly="true" Text='<% # Bind("Pedi_nombre")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Apellido">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<% # Bind("Pedi_apellidos")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtapellido" Width="150px" runat="server" ReadOnly="true" Text='<% # Bind("Pedi_apellidos")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Documento" >
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<% # Bind("Pedi_nro_documento")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtdocumentno" runat="server" Width="135px" ReadOnly="true" Text='<% # Bind("Pedi_nro_documento")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Dirección">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<% # Bind("Pedi_direccion_envio")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtdireccion" runat="server" ReadOnly="true" Text='<% # Bind("Pedi_direccion_envio")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Fecha">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<% # Bind("Pedi_fech_pedido")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtfecha" runat="server"  ReadOnly="true" Width="150px" Text='<% # Bind("Pedi_fech_pedido")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Telefono">
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<% # Bind("Pedi_telefono")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txttelefono" runat="server"  ReadOnly="true" Width="110px" Text='<% # Bind("Pedi_telefono")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Estado">
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<% # Bind("Pedi_estado")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtestado" runat="server" Width="50px" Text='<% # Bind("Pedi_estado")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:CommandField ButtonType="Button" ShowEditButton="true" ShowDeleteButton="false" />

         </Columns>

    </asp:GridView>
        </div>

</asp:Content>
