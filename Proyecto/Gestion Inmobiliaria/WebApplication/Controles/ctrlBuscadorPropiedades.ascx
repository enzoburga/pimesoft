<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlBuscadorPropiedades.ascx.cs" Inherits="WebApplication.Controles.ctrlBuscadorPropiedades" %>
<table width="900" border=0 cellpadding=5 cellspacing=0>
    <tr>
        <td style="width: 117px; height: 24px;">
            <span style="font-size: 11pt">
            Tipo de operación</span></td>
        <td style="width: 10px; height: 24px;">
        </td>
        <td style="width: 140px; height: 24px;">
            <asp:DropDownList ID="ddlTipoOperacion" runat="server">
            </asp:DropDownList></td>
        <td style="width: 21px; height: 24px;">
        </td>
        <td style="width: 91px; height: 24px;">
            <span style="font-size: 11pt">
            Ambientes</span></td>
        <td style="width: 10px; height: 24px;">
        </td>
        <td style="width: 140px; height: 24px;">
            <asp:DropDownList ID="ddlAmbientes" runat="server">
            </asp:DropDownList></td>
        <td style="width: 20px; height: 24px;">
        </td>
        <td style="width: 116px; height: 24px;">
            <span style="font-size: 11pt">
            Tipo de propiedad</span></td>
        <td style="width: 130px; height: 24px;">
            <asp:DropDownList ID="ddlTipoPropiedad" runat="server" Width="133px">
            </asp:DropDownList></td>
    </tr>
   
    <tr>
        <td style="width: 117px; height: 26px;">
            <span style="font-size: 11pt">
            Valor Minimo</span></td>
        <td style="width: 10px; height: 26px;">
        </td>
        <td style="width: 140px; height: 26px;">
            <asp:TextBox ID="tbValorDesde" runat="server" Width="100px"></asp:TextBox></td>
        <td style="width: 21px; height: 26px;">
        </td>
        <td style="width: 91px; height: 26px;">
            <span style="font-size: 11pt">
            Valor Máximo</span></td>
        <td style="width: 10px; height: 26px;">
        </td>
        <td style="width: 140px; height: 26px;">
            <asp:TextBox ID="tbValorHasta" runat="server" Width="100px"></asp:TextBox></td>
        <td style="width: 20px; height: 26px;">
        </td>
        <td style="width: 116px; height: 26px;">
            <span style="font-size: 11pt">
            Buscar en</span></td>
        <td style="width: 130px; height: 26px;">
            <asp:DropDownList ID="ddlMoneda" runat="server">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td colspan="3" style="height: 16px">
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbValorDesde"
                ErrorMessage="El valor minimo debe es un campo numérico" ValidationExpression="\d?\d?\d?\d?\d?\d?\d?\d?\d?\d" Font-Size="X-Small"></asp:RegularExpressionValidator></td>
        <td style="width: 21px; height: 16px;">
        </td>
        <td colspan="3" style="height: 16px">
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tbValorHasta"
                ErrorMessage="El valor máximo es un campo numérico" ValidationExpression='\d?\d?\d?\d?\d?\d?\d?\d?\d?\d' Font-Size="X-Small"></asp:RegularExpressionValidator></td>
        <td style="width: 20px; height: 16px;">
        </td>
        <td style="width: 116px; height: 16px;">
        </td>
        <td style="width: 130px; height: 16px;">
        </td>
    </tr>
    <tr>
        <td style="width: 117px; height: 21px;">
            <span style="font-size: 11pt">
            Ubicación</span></td>
        <td style="width: 10px; height: 21px;">
        </td>
        <td style="width: 140px; height: 21px;">
        </td>
        <td style="width: 21px; height: 21px;">
        </td>
        <td style="width: 91px; height: 21px;">
        </td>
        <td style="width: 10px; height: 21px;">
        </td>
        <td style="width: 140px; height: 21px;">
        </td>
        <td style="width: 20px; height: 21px;">
        </td>
        <td style="width: 116px; height: 21px;">
        </td>
        <td style="width: 130px; height: 21px;">
        </td>
    </tr>
    <tr>
        <td style="width: 117px; height: 24px">
            <span style="font-size: 11pt">
            Pais</span></td>
        <td style="width: 10px; height: 24px">
        </td>
        <td style="width: 140px; height: 24px">
            <asp:DropDownList ID="ddlPais" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPais_SelectedIndexChanged"
                Width="140px">
            </asp:DropDownList></td>
        <td style="width: 21px; height: 24px">
        </td>
        <td style="width: 91px; height: 24px">
            <span style="font-size: 11pt">
            Provincia</span></td>
        <td style="width: 10px; height: 24px">
        </td>
        <td style="width: 140px; height: 24px">
            <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"
                Width="140px">
            </asp:DropDownList></td>
        <td style="width: 20px; height: 24px">
        </td>
        <td style="width: 116px; height: 24px">
        </td>
        <td style="width: 130px; height: 24px">
        </td>
    </tr>
    <tr>
        <td style="width: 117px">
        </td>
        <td style="width: 10px">
        </td>
        <td style="width: 140px">
        </td>
        <td style="width: 21px">
        </td>
        <td style="width: 91px">
        </td>
        <td style="width: 10px">
        </td>
        <td style="width: 140px">
        </td>
        <td style="width: 20px">
        </td>
        <td style="width: 116px">
        </td>
        <td style="width: 130px">
        </td>
    </tr>
    <tr>
        <td style="width: 117px">
            <span style="font-size: 11pt">
            Localidad</span></td>
        <td style="width: 10px">
        </td>
        <td style="width: 140px">
            <asp:DropDownList ID="ddlLocalidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLocalidad_SelectedIndexChanged"
                Width="140px">
            </asp:DropDownList></td>
        <td style="width: 21px">
        </td>
        <td style="width: 91px">
            <span style="font-size: 11pt">
            Barrio</span></td>
        <td style="width: 10px">
        </td>
        <td style="width: 140px">
            <asp:DropDownList ID="ddlBarrio" runat="server" Width="140px">
            </asp:DropDownList></td>
        <td style="width: 20px">
        </td>
        <td style="width: 116px">
        </td>
        <td style="width: 130px">
        </td>
    </tr>
    <tr>
        <td style="width: 117px; height: 21px;">
        </td>
        <td style="width: 10px; height: 21px;">
        </td>
        <td style="width: 140px; height: 21px;">
        </td>
        <td style="width: 21px; height: 21px;">
        </td>
        <td style="width: 91px; height: 21px;">
        </td>
        <td style="width: 10px; height: 21px;">
        </td>
        <td style="width: 140px; height: 21px;">
        </td>
        <td style="width: 20px; height: 21px;">
        </td>
        <td style="width: 116px; height: 21px;">
        </td>
        <td style="width: 130px; height: 21px;">
        </td>
    </tr>
    <tr>
        <td colspan="10" style="text-align: center; height: 31px;">
            <asp:ImageButton ID="ibBuscar" runat="server"  /></td>
    </tr>
</table>
