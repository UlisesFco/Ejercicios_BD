<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AltaPedidos.aspx.cs" Inherits="Tarea6_AltaPedidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 855px; background-color: #5882FA">
    
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Tarea6/Menu.aspx" style="z-index: 1; left: 798px; top: 28px; position: absolute">Regresar</asp:HyperLink>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" style="z-index: 1; left: 493px; top: 25px; position: absolute" Text="Alta de pedidos"></asp:Label>
    
        <asp:DropDownList ID="ddlArticulos" runat="server" AutoPostBack="True" style="z-index: 1; left: 33px; top: 114px; position: absolute" OnSelectedIndexChanged="ddlArticulos_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:TextBox ID="txtNumArts" runat="server" style="z-index: 1; left: 251px; top: 116px; position: absolute" CausesValidation="True" ValidationGroup="AllValidators"></asp:TextBox>
        <asp:RangeValidator ID="valNumArts" runat="server" ControlToValidate="txtNumArts" ErrorMessage="Introduzca cantidad positiva" MaximumValue="9999" MinimumValue="0" ValidationGroup="AllValidators"></asp:RangeValidator>
        <asp:Table ID="tblDatos" runat="server" BorderStyle="Solid" style="z-index: 1; left: 528px; top: 97px; position: absolute; height: 158px; width: 411px">
            <asp:TableRow runat="server" BorderStyle="Solid">
                <asp:TableCell runat="server" BorderStyle="Solid">Folio pedido</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">fecha pedido</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">monto</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">saldo clientes</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">saldo facturas</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server" BorderStyle="Solid">
                <asp:TableCell runat="server" BorderStyle="Solid"></asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid"></asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid"></asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid"></asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 669px; top: 69px; position: absolute" Text="Pedidos recién hechos"></asp:Label>
        <asp:GridView ID="grdPedido" runat="server" style="z-index: 1; left: 84px; top: 301px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
    
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 63px; top: 83px; position: absolute" Text="Artículo"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 272px; top: 86px; position: absolute" Text="Cantidad arts."></asp:Label>
        <asp:Button ID="btnAlta" runat="server" style="z-index: 1; left: 130px; top: 182px; position: absolute" Text="Alta de pedido" OnClick="btnAlta_Click" />
    
        <asp:Label ID="lblMensaje" runat="server" style="z-index: 1; left: 167px; top: 57px; position: absolute" Text="Mensaje"></asp:Label>
    
    </div>
    </form>
</body>
</html>
