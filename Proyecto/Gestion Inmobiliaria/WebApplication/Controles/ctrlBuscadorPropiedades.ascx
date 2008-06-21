<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlBuscadorPropiedades.ascx.cs" Inherits="WebApplication.Controles.ctrlBuscadorPropiedades" %>
<table>
    <tr>
        <td style="width: 140px">
            Tipo de operación</td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
            <asp:DropDownList ID="ddlTipoPropiedad" runat="server">
            </asp:DropDownList></td>
        <td style="width: 30px">
        </td>
        <td style="width: 103px">
            Ambientes</td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
            <asp:DropDownList ID="ddlAmbientes" runat="server">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td style="width: 140px">
        </td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
        </td>
        <td style="width: 30px">
        </td>
        <td style="width: 103px">
        </td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
        </td>
    </tr>
    <tr>
        <td style="width: 140px">
            Buscar en</td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
            <asp:DropDownList ID="ddlMoneda" runat="server">
            </asp:DropDownList></td>
        <td style="width: 30px">
        </td>
        <td style="width: 103px">
        </td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
        </td>
    </tr>
    <tr>
        <td style="width: 140px">
        </td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
        </td>
        <td style="width: 30px">
        </td>
        <td style="width: 103px">
        </td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
        </td>
    </tr>
    <tr>
        <td style="width: 140px">
            Valor Minimo</td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
            <asp:TextBox ID="TextBox1" runat="server" Width="100px"></asp:TextBox></td>
        <td style="width: 30px">
        </td>
        <td style="width: 103px">
            Valor Máximo</td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
            <asp:TextBox ID="TextBox2" runat="server" Width="100px"></asp:TextBox></td>
    </tr>
    <tr>
        <td style="width: 140px">
        </td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
        </td>
        <td style="width: 30px">
        </td>
        <td style="width: 103px">
        </td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
        </td>
    </tr>
    <tr>
        <td style="width: 140px">
            Ubicación</td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
        </td>
        <td style="width: 30px">
        </td>
        <td style="width: 103px">
        </td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
        </td>
    </tr>
    <tr>
        <td style="width: 140px; height: 24px">
            Pais</td>
        <td style="width: 15px; height: 24px">
        </td>
        <td style="width: 140px; height: 24px">
            <asp:DropDownList ID="ddlPais" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPais_SelectedIndexChanged"
                Width="140px">
            </asp:DropDownList></td>
        <td style="width: 30px; height: 24px">
        </td>
        <td style="width: 103px; height: 24px">
            Provincia</td>
        <td style="width: 15px; height: 24px">
        </td>
        <td style="width: 140px; height: 24px">
            <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"
                Width="140px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td style="width: 140px">
        </td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
        </td>
        <td style="width: 30px">
        </td>
        <td style="width: 103px">
        </td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
        </td>
    </tr>
    <tr>
        <td style="width: 140px">
            Localidad</td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
            <asp:DropDownList ID="ddlLocalidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLocalidad_SelectedIndexChanged"
                Width="140px">
            </asp:DropDownList></td>
        <td style="width: 30px">
        </td>
        <td style="width: 103px">
            Barrio</td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
            <asp:DropDownList ID="ddlBarrio" runat="server" Width="140px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td style="width: 140px">
        </td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
        </td>
        <td style="width: 30px">
        </td>
        <td style="width: 103px">
        </td>
        <td style="width: 15px">
        </td>
        <td style="width: 140px">
        </td>
    </tr>
    <tr>
        <td colspan="7" style="text-align: center">
            <asp:ImageButton ID="ibBuscar" runat="server" OnClick="ibBuscar_Click" /></td>
    </tr>
</table>
