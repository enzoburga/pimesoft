<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlBuscadorPropiedades.ascx.cs" Inherits="WebApplication.Controles.ctrlBuscadorPropiedades" %>
<table width="700" cellpadding=5 cellspacing=0 style="font-size: 9pt; font-family: Arial">
    <tr>
        <td style="width: 119px; height: 24px;">
            <span>
            Tipo de búsqueda</span></td>
        <td style="width: 131px; height: 24px;">
            <asp:DropDownList ID="ddlTipoOperacion" runat="server" Font-Size="9pt" Width="90px" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoOperacion_SelectedIndexChanged">
            </asp:DropDownList></td>
        <td style="width: 91px; height: 24px;">
            <span></span>
        </td>
        <td style="width: 129px; height: 24px;">
        </td>
        <td style="width: 116px; height: 24px;">
            <span></span>
        </td>
        <td style="width: 130px; height: 24px;">
        </td>
    </tr>
    <tr>
        <td style="height: 25px;" colspan="6">
                
                
                
                            <asp:Panel ID="panelCodigo" runat="server" Height="60px" Width="700px">
                <table width="700" style="font-size: 9pt; font-family: Arial" cellpadding="5">
                    <tr>
                        <td style="width: 44px; height: 20px">
                            <span>Código</span></td>
                        <td style="width: 50px; height: 20px">
                            <asp:TextBox ID="tbCodigo" runat="server" CausesValidation="True" Width="50px"></asp:TextBox></td>
                        <td style="width: 413px; height: 20px; text-align: left;" align="left">
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="tbCodigo"
                                ErrorMessage="El código debe es un campo numérico." Font-Size="Small" ValidationExpression="\d?\d?\d?\d?\d?\d?\d?\d?\d?\d"></asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="3" style="height: 20px; text-align: left">
                            Ingrese el número del código de propiedad (Ej: P0000023, ingrese 23)</td>
                    </tr>
                </table>
                                <span style="font-size: 9pt; font-family: Arial"></span></asp:Panel>
            
            <asp:Panel ID="panelFiltros" runat="server" Height="200px" Width="700px">
            <table width="700" border=0 cellpadding=5 cellspacing=0 style="font-size: 9pt; font-family: Arial; text-align: left;">
    <tr>
        <td style="width: 107px; height: 24px;">
            <span>
            Ambientes</span></td>
        <td style="width: 175px; height: 24px;">
            <asp:DropDownList ID="ddlAmbientes" runat="server" Font-Names="Arial" Font-Size="9pt">
            </asp:DropDownList></td>
        <td style="width: 128px; height: 24px;">
            <span>
            Tipo de propiedad</span></td>
        <td style="width: 120px; height: 26px;">
            <asp:DropDownList ID="ddlTipoPropiedad" runat="server" Width="120px" Font-Names="Arial" Font-Size="9pt">
            </asp:DropDownList></td>
        <td style="width: 62px; height: 24px;">
            <span>
            </span></td>
        <td style="width: 87px; height: 24px;">
            </td>
    </tr>
   
    <tr>
        <td style="width: 107px; height: 26px;">
            <span>
            Valor Minimo</span></td>
        <td style="width: 175px; height: 24px;">
            <asp:TextBox ID="tbValorDesde" runat="server" Width="100px" Font-Names="Arial" Font-Size="9pt"></asp:TextBox></td>
        <td style="width: 128px; height: 26px;">
            <span>
            Valor Máximo</span></td>
        <td style="width: 120px; height: 26px;">
            <asp:TextBox ID="tbValorHasta" runat="server" Width="100px" Font-Names="Arial" Font-Size="9pt"></asp:TextBox></td>
        <td style="width: 62px; height: 26px;">
            <span>
            Buscar en</span></td>
        <td style="width: 87px; height: 26px;">
            <asp:DropDownList ID="ddlMoneda" runat="server" Font-Names="Arial" Font-Size="9pt">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td colspan="2" style="height: 16px">
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbValorDesde"
                ErrorMessage="El valor minimo debe es un campo numérico" ValidationExpression="\d?\d?\d?\d?\d?\d?\d?\d?\d?\d" Font-Size="Small"></asp:RegularExpressionValidator></td>
        <td colspan="2" style="height: 16px">
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tbValorHasta"
                ErrorMessage="El valor máximo es un campo numérico" ValidationExpression='\d?\d?\d?\d?\d?\d?\d?\d?\d?\d' Font-Size="Small"></asp:RegularExpressionValidator></td>
        <td style="width: 62px; height: 16px;">
        </td>
        <td style="width: 87px; height: 16px;">
        </td>
    </tr>
    <tr>
        <td style="width: 107px; height: 21px;">
            <span>
            Ubicación</span></td>
        <td style="width: 175px; height: 24px;">
        </td>
        <td style="width: 128px; height: 21px;">
        </td>
        <td style="width: 120px; height: 26px;">
        </td>
        <td style="width: 62px; height: 21px;">
        </td>
        <td style="width: 87px; height: 21px;">
        </td>
    </tr>
    <tr>
        <td style="width: 107px; height: 24px">
            <span>
            Pais</span></td>
        <td style="width: 175px; height: 24px">
            <asp:DropDownList ID="ddlPais" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPais_SelectedIndexChanged"
                Width="120px" Font-Names="Arial" Font-Size="9pt">
            </asp:DropDownList></td>
        <td style="width: 128px; height: 24px">
            <span>
            Provincia</span></td>
        <td style="width: 120px; height: 26px">
            <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"
                Width="120px" Font-Names="Arial" Font-Size="9pt">
            </asp:DropDownList></td>
        <td style="width: 62px; height: 24px">
        </td>
        <td style="width: 87px; height: 24px">
        </td>
    </tr>
    <tr>
        <td style="width: 107px; height: 31px;">
            <span>
            Localidad</span></td>
        <td style="width: 175px; height: 31px;">
            <asp:DropDownList ID="ddlLocalidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLocalidad_SelectedIndexChanged"
                Width="120px" Font-Names="Arial" Font-Size="9pt">
            </asp:DropDownList></td>
        <td style="width: 128px; height: 31px;">
            <span>
            Barrio</span></td>
        <td style="width: 120px; height: 31px;">
            <asp:DropDownList ID="ddlBarrio" runat="server" Width="120px" Font-Names="Arial" Font-Size="9pt">
            </asp:DropDownList></td>
        <td style="width: 62px; height: 31px;">
        </td>
        <td style="width: 87px; height: 31px;">
        </td>
    </tr>
</table>
</asp:Panel>                    

        </td>
    </tr>
</table>