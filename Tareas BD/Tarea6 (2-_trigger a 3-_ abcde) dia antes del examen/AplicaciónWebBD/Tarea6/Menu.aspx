<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Tarea6_Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 392px; width: 1211px; background-color: #5882FA;">
    
        <asp:HyperLink ID="linkDatosCliente" runat="server" NavigateUrl="~/Tarea6/Datos.aspx" style="z-index: 1; left: 249px; top: 91px; position: absolute; right: 812px;">Datos del Usuario</asp:HyperLink>
        <asp:HyperLink ID="linkAlta" runat="server" Enabled="False" style="z-index: 1; left: 522px; top: 92px; position: absolute; bottom: 523px" Visible="False">Alta de pedidos</asp:HyperLink>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" style="z-index: 1; left: 329px; top: 36px; position: absolute" Text="Menú Principal"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:HyperLink ID="linkRegresar" runat="server" NavigateUrl="~/Default.aspx" style="z-index: 1; left: 407px; top: 148px; position: absolute">Regresar</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
