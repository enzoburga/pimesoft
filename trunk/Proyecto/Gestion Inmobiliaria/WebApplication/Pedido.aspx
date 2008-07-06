<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="WebApplication.Pedido" %>

<%@ Register Src="Controles/ctrlPedido.ascx" TagName="ctrlPedido" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Cargar Pedido</title>
</head>
<body style="color: #000000">
    <form id="form1" runat="server">
    <div>
        <table style="font-size: 9pt; font-family: Arial" cellpadding="5">
            <tr>
                <td colspan="6">
                    Cliente:
                    <asp:Label ID="lNombres" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="6">
                    Email:
                    <asp:Label ID="lEmail" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="6">
                    <uc1:ctrlPedido id="CtrlPedido1" runat="server">
                    </uc1:ctrlPedido></td>
            </tr>
            <tr>
                <td colspan="6" style="text-align: center">
                    <asp:Label ID="lError" runat="server" Font-Names="Arial" Font-Size="Small" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="6" style="text-align: center">
                    <asp:ImageButton ID="bEnviarPedido" runat="server" OnClick="bEnviarPedido_Click" ImageUrl="~/imagenes/enviarPedido.jpg" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
