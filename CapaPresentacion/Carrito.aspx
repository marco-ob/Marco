<%@ Page Title="" Language="C#" MasterPageFile="~/INICIO_CLIENTE.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="CapaPresentacion.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                        <table class="table">
                        <tr>
            <td style="width: 77px">
                &nbsp;</td>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server"  Width="505px"  utoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
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

                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 77px">
                &nbsp;</td>
            <td style="width: 397px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 77px">
                &nbsp;</td>
            <td style="width: 397px; text-align: right">
                SubTotal S/ :&nbsp;
                <asp:Label ID="lblSubTotal" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 77px">
                &nbsp;</td>
            <td style="width: 397px; text-align: right">
                IGV S/ :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblIGV" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 77px">
                &nbsp;</td>
            <td style="width: 397px; text-align: right">
                Total S/ :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 77px">
                &nbsp;</td>
            <td style="width: 397px">
                <asp:Button ID="Button1" runat="server" Text="Volver a comprar" OnClick="Button1_Click" CssClass="btn btn-primary" />
                <asp:Button ID="Button2" runat="server" Text="Continuar Compras" style="margin-left: 50px"
                    Width="157px" OnClick="Button2_Click" CssClass="btn btn-primary" />
            </td>
            <%--<td>
                <asp:Button ID="Button3" runat="server" style="margin-left: 34px" Text="Comprar" Width="120px"  />
            </td>--%>
        </tr>
                    </table>
               













</asp:Content>
