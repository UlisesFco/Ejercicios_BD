<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminUsuarios.aspx.cs" Inherits="AdminUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Administración de usuarios</title>
    <style type="text/css">
        #form1 {
            height: 570px;
        }
    </style>
</head>
<body style="height: 584px">
    <form id="form1" runat="server" style="background-color: #FFCC99">
    <div style="background-color: #FFCC99; height: 528px; z-index: 1; left: 33px; top: 34px; position: absolute; width: 967px;">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 226px; top: 34px; position: absolute; width: 356px" Text="Administración de usuarios"></asp:Label>
        <asp:Button ID="BtnAlta" runat="server" style="z-index: 1; left: 69px; top: 84px; position: absolute; bottom: 410px;" Text="Alta de usuarios" OnClick="BtnAlta_Click" />
        <asp:Button ID="BtnBaja" runat="server" style="z-index: 1; left: 267px; top: 81px; position: absolute" Text="Baja de usuarios" OnClick="BtnBaja_Click" />
        <asp:Button ID="BtnCambio" runat="server" style="z-index: 1; left: 465px; top: 80px; position: absolute" Text="Cambio de datos" />
        <asp:TextBox ID="TxtRFC" runat="server" style="z-index: 1; left: 75px; top: 150px; position: absolute" Visible="False" ToolTip="RFC" OnTextChanged="TxtRFC_TextChanged" ValidationGroup="AllValidators">RFC</asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtRFC" ErrorMessage="Formato a dar: A0" ValidationExpression="(\w|\d){2}" ValidationGroup="AllValidators"></asp:RegularExpressionValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" style="z-index: 1; left: 13px; top: 467px; position: absolute; height: 44px; width: 823px" ValidationGroup="AllValidators" />
        <asp:TextBox ID="TxtNombre" runat="server" style="z-index: 1; left: 75px; top: 199px; position: absolute" Visible="False"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtNombre" ErrorMessage="Dar un nombre" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
        <asp:TextBox ID="TxtPassw" runat="server" style="z-index: 1; left: 75px; top: 254px; position: absolute" Visible="False">Contraseña</asp:TextBox>
        <asp:DropDownList ID="DDLTipo" runat="server" style="z-index: 1; left: 75px; top: 304px; position: absolute" Visible="False" AutoPostBack="True" OnSelectedIndexChanged="DDLTipo_SelectedIndexChanged">
            <asp:ListItem>Tipo de usuario</asp:ListItem>
            <asp:ListItem Value="Cli">Cliente</asp:ListItem>
            <asp:ListItem Value="Emp">Empleado</asp:ListItem>
            <asp:ListItem Value="Ger">Gerente</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="LblMensaje" runat="server" style="z-index: 1; left: 75px; top: 354px; position: absolute" Text="Operación: en espera"></asp:Label>
        <asp:DropDownList ID="DDLUsuarios" runat="server" style="z-index: 1; left: 269px; top: 149px; position: absolute" Visible="False" AutoPostBack="True" OnSelectedIndexChanged="DDLUsuarios_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:TextBox ID="TxtDomicilio" runat="server" style="z-index: 1; left: 270px; top: 198px; position: absolute; width: 131px" Visible="False" ValidationGroup="AllValidators"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TxtDomicilio" ErrorMessage="dar un valor entre 1 y 10" MaximumValue="10" MinimumValue="1" Type="Integer" ValidationGroup="AllValidators"></asp:RangeValidator>
        <asp:TextBox ID="TxtCat" runat="server" style="z-index: 1; left: 269px; top: 254px; position: absolute" Visible="False" Enabled="False">Categoría</asp:TextBox>
        <asp:Button ID="BtnEjecuta" runat="server" Enabled="False" OnClick="BtnEjecuta_Click" style="z-index: 1; left: 472px; top: 297px; position: absolute" Text="Ejecutar operación" ValidationGroup="AllValidators" />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" style="z-index: 1; left: 474px; top: 355px; position: absolute">Página inicial</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
