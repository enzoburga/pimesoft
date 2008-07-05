<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaClientePedido.aspx.cs" Inherits="WebApplication.AltaClientePedido" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span style="font-size: 9pt; font-family: Arial">Los campos marcados con <span style="color: #ff0000">
            * <span style="color: #000000">son obligatorios.<br />
                Debe completar al menos un teléfono.</span></span><br />
        </span>
        <table style="font-size: 9pt; color: #000000; font-family: Arial">
            <tr>
                <td style="width: 138px">
                    Dirección de e-mail</td>
                <td style="width: 100px">
                    <asp:TextBox ID="tbEmail" runat="server" ReadOnly="True"></asp:TextBox></td>
                <td style="width: 267px">
                </td>
            </tr>
            <tr>
                <td style="width: 138px">
                    Nombre</td>
                <td style="width: 100px">
                    <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox><span style="color: #ff0000">*</span></td>
                <td style="width: 267px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbNombre"
                        ErrorMessage="Debe completar este campo para continuar." Width="100%"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 138px">
                    Apellido</td>
                <td style="width: 100px">
                    <asp:TextBox ID="tbApellido" runat="server"></asp:TextBox><span style="color: #ff0000">*</span></td>
                <td style="width: 267px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbApellido"
                        ErrorMessage="Debe completar este campo para continuar." Width="100%"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 138px">
                    Teléfono Personal</td>
                <td style="width: 100px">
                    <asp:TextBox ID="tbTelPersonal" runat="server"></asp:TextBox><span style="color: #ff0000"></span></td>
                <td style="width: 267px">
                </td>
            </tr>
            <tr>
                <td style="width: 138px">
                    Teléfono Laboral</td>
                <td style="width: 100px">
                    <asp:TextBox ID="tbTelLaboral" runat="server"></asp:TextBox><span style="color: #ff0000"></span></td>
                <td style="width: 267px">
                </td>
            </tr>
            <tr>
                <td style="width: 138px">
                    Teléfono Celular</td>
                <td style="width: 100px">
                    <asp:TextBox ID="tbTelCelular" runat="server"></asp:TextBox><span style="color: #ff0000"></span></td>
                <td style="width: 267px">
                </td>
            </tr>
            <tr>
                <td style="width: 138px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 267px">
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:Label ID="lError" runat="server" Font-Names="Arial" Font-Size="Small" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:ImageButton ID="bContinuar" runat="server" OnClick="bContinuar_Click" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
