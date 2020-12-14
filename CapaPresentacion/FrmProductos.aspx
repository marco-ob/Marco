<%@ Page Title="" Language="C#" MasterPageFile="~/INICIO_ADMIN.Master" AutoEventWireup="true" CodeBehind="FrmProductos.aspx.cs" Inherits="CapaPresentacion.FrmProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<script type="text/javascript">

        function alerta(numero) {
            setTimeout(function () { alert(numero); }, 1000);

        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<div class="col-lg-12 pt-4 ml-4 pb-2 loginbttm">
		<button type="button" runat="server" class="btn btn-outline-primary" onclick="location.href='FrmInsertarProductos.aspx'">
			Ingresar nuevo producto
		</button>
	</div>

    <asp:GridView runat="server" ID="listaproductos" CellPadding="1" CssClass="ml-2" ForeColor="#333333" AutoGenerateColumns="false" DataKeyNames="Prod_ID" GridLines="None" OnRowCancelingEdit="rowCancelEdit" OnRowDeleting="rowDeleting" OnRowEditing="rowEditing" OnRowUpdating="rowupdating" >
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
        <asp:Label ID="Label1" runat="server"  Text='<% # Bind("Prod_ID")%>'></asp:Label>
    </ItemTemplate>
    <EditItemTemplate>
        <asp:TextBox ID="txtid" Width="25px" runat="server" ReadOnly="true" Text='<% # Bind("Prod_ID")%>'></asp:TextBox>
    </EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField HeaderText="Codigo">
	<ItemTemplate>
		<asp:Label ID="Label2" runat="server" Text='<% # Bind("Prod_codigo")%>'></asp:Label>
	</ItemTemplate>
	<EditItemTemplate>
		<asp:TextBox ID="txtcodigo" Width="85px" runat="server" ReadOnly="true" Text='<% # Bind("Prod_codigo")%>'></asp:TextBox>
	</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField HeaderText="Nombre">
	<ItemTemplate>
		<asp:Label ID="Label3" runat="server" Text='<% # Bind("Prod_nombre")%>'></asp:Label>
	</ItemTemplate>
	<EditItemTemplate>
		<asp:TextBox ID="txtnombre" Width="100px" runat="server"  Text='<% # Bind("Prod_nombre")%>'></asp:TextBox>
	</EditItemTemplate>
    </asp:TemplateField>

            <asp:TemplateField HeaderText="Precio">
	<ItemTemplate>
		<asp:Label ID="Label4" runat="server" Text='<% # Bind("Prod_prec")%>'></asp:Label>
	</ItemTemplate>
	<EditItemTemplate>
		<asp:TextBox ID="txtprecio" Width="65px" runat="server"  Text='<% # Bind("Prod_prec")%>'></asp:TextBox>
	</EditItemTemplate>
</asp:TemplateField>

            <asp:TemplateField HeaderText="Stock">
	<ItemTemplate>
		<asp:Label ID="Label5" runat="server" Text='<% # Bind("Prod_stock")%>'></asp:Label>
	</ItemTemplate>
	<EditItemTemplate>
		<asp:TextBox ID="txtstock" Width="65px" runat="server"  Text='<% # Bind("Prod_stock")%>'></asp:TextBox>
	</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField HeaderText="Imagen">
	<ItemTemplate>
		<%--<asp:Label ID="Label6" runat="server" Text='<% # Convert.ToString(Eval("Prod_imagen"))%>'></asp:Label>--%>
		<img class="img-responsive" src="data:image/jpg;base64,<%# Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem,"Prod_imagen")) %>" />
	</ItemTemplate>
	<EditItemTemplate>
		<%--<asp:TextBox ID="txtimagen" Width="80px" runat="server" Text='<% # Bind("Prod_imagen")%>'></asp:TextBox>--%>
		<img class="img-responsive" src="data:image/jpg;base64,<%# Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem,"Prod_imagen")) %>" />
	</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField HeaderText="Descripcion">
	<ItemTemplate>
		<asp:Label ID="Label7" runat="server" Text='<% # Bind("Prod_descripcion")%>'></asp:Label>
	</ItemTemplate>
	<EditItemTemplate>
		<asp:TextBox ID="txtdescripcion" Width="580px" runat="server" Text='<% # Bind("Prod_descripcion")%>'></asp:TextBox>
	</EditItemTemplate>
	</asp:TemplateField>

<asp:TemplateField HeaderText="Estado">
	<ItemTemplate>
		<asp:Label ID="Label8" runat="server" Text='<% # Bind("Prod_estado")%>'></asp:Label>
	</ItemTemplate>
	<EditItemTemplate>
		<asp:TextBox ID="txtestado" Width="75px" runat="server"  Text='<% # Bind("Prod_estado")%>'></asp:TextBox>
	</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField HeaderText="Id Categoria">
	<ItemTemplate>
		<asp:Label ID="Label9" runat="server" Text='<% # Bind("Cate_ID")%>'></asp:Label>
	</ItemTemplate>
	<EditItemTemplate>
		<asp:TextBox ID="txtidcate" Width="75px" runat="server"  Text='<% # Bind("Cate_ID")%>'></asp:TextBox>
	</EditItemTemplate>
</asp:TemplateField>



			<asp:CommandField ButtonType="button" ShowEditButton="true" ShowDeleteButton="false" />


    </Columns>


    
    </asp:GridView>
</asp:Content>
