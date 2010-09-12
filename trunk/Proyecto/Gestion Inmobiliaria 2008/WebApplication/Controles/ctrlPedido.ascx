<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlPedido.ascx.cs" Inherits="WebApplication.Controles.ctrlPedido" %>

<table style="font-size: 9pt; font-family: Arial" cellpadding="5">
            <tr>
                <td style="width: 117px">
                    Tipo de operación</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="ddlTipoOperacion" runat="server" Font-Names="Arial" Font-Size="9pt"
                        Width="120px">
                    </asp:DropDownList></td>
                <td style="width: 110px">
                    </td>
                <td style="width: 100px">
                    </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 117px">
                    Categoría</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="ddlCategoria" runat="server" Font-Names="Arial" Font-Size="9pt"
                        Width="120px" AutoPostBack="True" OnSelectedIndexChanged="ddlCategoria_SelectedIndexChanged">
                    </asp:DropDownList></td>
                <td style="width: 110px">
                    Tipo de propiedad</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="ddlTipoPropiedad" runat="server" Font-Names="Arial" Font-Size="9pt"
                        Width="120px">
                    </asp:DropDownList></td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 117px">
                    Ubicación</td>
                <td style="width: 100px">
                </td>
                <td style="width: 110px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 117px">
                    País</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="ddlPais" runat="server" AutoPostBack="True" Font-Names="Arial"
                        Font-Size="9pt" OnSelectedIndexChanged="ddlPais_SelectedIndexChanged" Width="130px">
                    </asp:DropDownList></td>
                <td style="width: 110px">
                    Provincia</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="True" Font-Names="Arial"
                        Font-Size="9pt" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged" Width="130px">
                    </asp:DropDownList></td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 117px">
                    Localidad</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="ddlLocalidad" runat="server" AutoPostBack="True" Font-Names="Arial"
                        Font-Size="9pt" OnSelectedIndexChanged="ddlLocalidad_SelectedIndexChanged" Width="130px">
                    </asp:DropDownList></td>
                <td style="width: 110px">
                    Barrio</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="ddlBarrio" runat="server" Font-Names="Arial" Font-Size="9pt"
                        Width="129px">
                    </asp:DropDownList></td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 117px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 110px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 117px">
                    Valor Mínimo</td>
                <td style="width: 100px">
                    <asp:TextBox ID="tbValorDesde" runat="server" Font-Names="Arial" Font-Size="9pt"
                        MaxLength="8" Width="100px"></asp:TextBox></td>
                <td style="width: 110px">
                    Valor Máximo</td>
                <td style="width: 100px">
                    <asp:TextBox ID="tbValorHasta" runat="server" Font-Names="Arial" Font-Size="9pt"
                        MaxLength="8" Width="100px"></asp:TextBox></td>
                <td style="width: 100px">
                    Buscar en</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="ddlMoneda" runat="server" Font-Names="Arial" Font-Size="9pt"
                        Width="60px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbValorDesde"
                        ErrorMessage="El valor minimo es un campo numérico (8 dig máx)." Font-Names="Arial"
                        Font-Size="X-Small" ValidationExpression="\d?\d?\d?\d?\d?\d?\d?\d"></asp:RegularExpressionValidator><br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tbValorHasta"
                        ErrorMessage="El valor máximo es un campo numérico  (8 dig máx)." Font-Names="Arial"
                        Font-Size="X-Small" ValidationExpression="\d?\d?\d?\d?\d?\d?\d?\d"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td style="width: 117px">
                    Metros Terreno</td>
                <td style="width: 100px">
                </td>
                <td style="width: 110px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 117px">
                    Mínimo</td>
                <td style="width: 100px">
                    <asp:TextBox ID="tbMetrosTerrenoMin" runat="server" Font-Names="Arial" Font-Size="9pt"
                        MaxLength="8" Width="100px"></asp:TextBox></td>
                <td style="width: 110px">
                    Máximo</td>
                <td style="width: 100px">
                    <asp:TextBox ID="tbMetrosTerrenoMax" runat="server" Font-Names="Arial" Font-Size="9pt"
                        MaxLength="8" Width="100px"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="tbMetrosTerrenoMin"
                        ErrorMessage="El minimo es un campo numérico (8 dig máx)." Font-Names="Arial"
                        Font-Size="X-Small" ValidationExpression="\d?\d?\d?\d?\d?\d?\d?\d"></asp:RegularExpressionValidator><br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="tbMetrosTerrenoMax"
                        ErrorMessage="El máximo es un campo numérico  (8 dig máx)." Font-Names="Arial"
                        Font-Size="X-Small" ValidationExpression="\d?\d?\d?\d?\d?\d?\d?\d"></asp:RegularExpressionValidator></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    Metros Cubiertos</td>
                <td style="width: 110px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 117px">
                    Mínimo</td>
                <td style="width: 100px">
                    <asp:TextBox ID="tbMetrosCubiertosMin" runat="server" Font-Names="Arial" Font-Size="9pt"
                        MaxLength="8" Width="100px"></asp:TextBox></td>
                <td style="width: 110px">
                    Máximo</td>
                <td style="width: 100px">
                    <asp:TextBox ID="tbMetrosCubiertosMax" runat="server" Font-Names="Arial" Font-Size="9pt"
                        MaxLength="8" Width="100px"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="tbMetrosCubiertosMin"
                        ErrorMessage="El minimo es un campo numérico (8 dig máx)." Font-Names="Arial"
                        Font-Size="X-Small" ValidationExpression="\d?\d?\d?\d?\d?\d?\d?\d"></asp:RegularExpressionValidator><br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="tbMetrosCubiertosMax"
                        ErrorMessage="El máximo es un campo numérico  (8 dig máx)." Font-Names="Arial"
                        Font-Size="X-Small" ValidationExpression="\d?\d?\d?\d?\d?\d?\d?\d"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td colspan="2">
                    Cantidad de
                    Ambientes</td>
                <td style="width: 110px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 117px">
                    Desde</td>
                <td style="width: 100px"><asp:DropDownList ID="ddlAmbientesDesde" runat="server" Font-Names="Arial" Font-Size="9pt">
                </asp:DropDownList></td>
                <td style="width: 110px">
                    Hasta</td>
                <td style="width: 100px"><asp:DropDownList ID="ddlAmbientesHasta" runat="server" Font-Names="Arial" Font-Size="9pt">
                </asp:DropDownList></td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 117px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 110px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
        </table>