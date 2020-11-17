<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Datos.aspx.cs" Inherits="Tarea6_Datos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 71%;
            z-index: 1;
            left: 134px;
            top: 352px;
            position: absolute;
            height: 147px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 548px; background-color: #5882FA">
    
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Tarea6/Menu.aspx" style="z-index: 1; left: 747px; top: 27px; position: absolute; margin-bottom: 2px">Regresar</asp:HyperLink>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" style="z-index: 1; left: 495px; top: 23px; position: absolute" Text="Datos del Usuario"></asp:Label>
    
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 172px; top: 236px; position: absolute" Text="Pedidos:"></asp:Label>
        <asp:Table ID="TblUsuario" runat="server" BorderStyle="Solid" style="z-index: 1; left: 175px; top: 85px; position: absolute; height: 86px; width: 98px">
            <asp:TableRow runat="server" BorderStyle="Solid">
                <asp:TableCell runat="server" BorderStyle="Solid">Clave</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">Nombre</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">Domicilio</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <table class="auto-style1">
            <caption>
                Artículos y pagos del pedido</caption>
            <tr>
                <td>
                    <asp:GridView ID="GrdArticulos" runat="server">
                    </asp:GridView>
                </td>
                <td>
                    <asp:GridView ID="GrdPagos" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <asp:Table ID="TblPedido" runat="server" BorderStyle="Solid" style="z-index: 1; left: 567px; top: 83px; position: absolute; height: 103px; width: 379px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server" BorderStyle="Solid">No. pedido</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">Fecha</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">Total a pagar</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">Saldo del cliente</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">Saldo en facturas</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 663px; top: 246px; position: absolute; right: 531px" Text="Clientes:" Visible="False"></asp:Label>
        <asp:DropDownList ID="ddlPedidos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPedidos_SelectedIndexChanged" style="z-index: 1; left: 248px; top: 237px; position: absolute">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlClientes" runat="server" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlClientes_SelectedIndexChanged" style="z-index: 1; left: 766px; top: 245px; position: absolute" Visible="False">
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
