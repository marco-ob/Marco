<%@ Page Title="" Language="C#" MasterPageFile="~/INICIO.Master" AutoEventWireup="true"  CodeBehind="FrmCategoriaxProducto.aspx.cs" Inherits="CapaPresentacion.FrmCategoriaxProducto" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    
    <div class="row">
    <div id="sidebar" class="col-2 bg-black" style="background-color:#E0FFFF">
                
               <asp:ListView ID="lvCategorias" runat="server">
                   
                    <ItemTemplate>
                        <ul>
                            <li>
                              
                                <p><a href="FrmCategoriaxProducto.aspx?idcat=<%# Eval("Cate_ID") %>">
                                    <%# Eval("Cate_nombre") %></a></p>
                                <%-- <asp:Label ID="lblCodigocat" runat="server" visible="false" Text='<%# Eval("Cate_ID") %>' />
                                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" ><%# Eval("Cate_nombre") %></asp:LinkButton>--%>
                            </li>
                        </ul>
                    </ItemTemplate>
                </asp:ListView>
    </div>

    <div id="content" class="col-10 mt-3">  

        <asp:DataList ID="dlsProductos" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" Font-Size="15px" 
            BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" OnItemCommand="dlsProductos_ItemCommand" CellPadding="2" ForeColor="Black">

            <AlternatingItemStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />

       <ItemTemplate>
           <div>
               <table>
                   <tr>
                       <td>
                           <img class="img-responsive" src="data:image/jpg;base64,<%# Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem,"Prod_imagen")) %>" />
                       </td>
                   </tr>
                    <tr>
                        <td>Codigo: 
                            <asp:Label ID="lblCodigo" runat="server" Text='<%# Eval("Prod_codigo") %>' />
                            <asp:Label ID="lblProdCod" runat="server" Visible="false" Text ='<%# Eval("Prod_id") %>' />
                        </td>
                    </tr>
                   <tr>
                        <td>Sección: 
                            <asp:Label ID="lblMarca" runat="server" Text='<%# Eval("Cate_nombre") %>' />
                        </td>
                    </tr>
                   <tr>
                        <td>Producto: 
                            <asp:Label ID="lblNombrePro" runat="server" Text='<%# Eval("Prod_nombre") %>' />
                        </td>
                    </tr>
                   <tr>
                        <td>Precio: s/.
                            <asp:Label ID="lblPrecio" runat="server" Text='<%# Eval("Prod_prec") %>' />
                        </td>
                    </tr>
                   <tr>
                        <td>Cantidad
                            <asp:Label ID="lblStock" runat="server" Text='<%# Eval("Prod_stock") %>' />
                        </td>
                    </tr>
                   <tr>
                        <td>
                            <asp:Label ID="lblDescripcion" runat="server" Text='<%# Eval("Prod_descripcion") %>' />
                        </td>
                    </tr>
                   <tr>
                        <td>
                            <asp:TextBox ID="txtCantidad" runat="server" Text=""  CommandName="txtCantidad" TextMode="Number" Width="60px" />
                            <asp:Button ID="btnComprar"  runat="server" Text="Comprar" CommandName="btnComprar"/>
                          
                        </td>
                    </tr>
               </table>
           </div>
       </ItemTemplate>
            <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
   </asp:DataList>

    </div>
       
        </div>

</asp:Content>
