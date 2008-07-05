<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresarEmailCliente.aspx.cs" Inherits="WebApplication.IngresarEmailCliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ingresar dirección de Email</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span style="font-size: 9pt; font-family: Arial">
        &nbsp; Ingrese su dirección de e-mail</span><table cellpadding="5" style="font-size: 9pt; font-family: Arial">
            <tr>
                <td style="width: 140px">
                    <asp:Label ID="Label1" runat="server" Text="E-mail"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbEmail"
                        ErrorMessage="Email inválido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td style="width: 140px">
                    Confirme su E-mail</td>
                <td style="width: 100px">
                    <asp:TextBox ID="tbConfirmar" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tbConfirmar"
                        ErrorMessage="Email inválido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:Label ID="lError" runat="server" Font-Names="Arial" Font-Size="Small" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
        <asp:ImageButton ID="bAceptar" runat="server" OnClick="bAceptar_Click" /></td>
                <td colspan="1" style="text-align: center">
                </td>
            </tr>
        </table>
        <br />
        </div>
    </form>
</body>
</html>
