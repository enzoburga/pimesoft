<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlBuscadorPropiedades.ascx.cs" Inherits="WebApplication.Controles.ctrlBuscadorPropiedades" %>
<style type="text/css">
<!--
body,td,th {
	color: #FFFFFF;
}
body {
	background-color: #FF0000;
}
-->
</style>

<table width="700" cellpadding=5 cellspacing=0 style="font-size: 9pt; font-family: Arial">
    <tr>
        <td style="width: 119px; height: 20px;">
            <div align="right"><strong> Tipo de búsqueda</strong></div></td>
        <td style="height: 20px;" colspan="5">
            <div align="left"></div>
            <span>
            <asp:RadioButtonList id="radioListTipoBusqueda" runat="server" Font-Names="Arial" Font-Size="9pt" RepeatDirection="Horizontal" Width="319px" AutoPostBack="True" OnSelectedIndexChanged="radioListTipoBusqueda_SelectedIndexChanged">
               <asp:ListItem selected="True" Value="GI.BR.Propiedades.Venta">Ventas</asp:ListItem>
               <asp:ListItem Value="GI.BR.Propiedades.Alquiler">Alquileres</asp:ListItem>
               <asp:ListItem Value="Codigo">Por C&#243;digo</asp:ListItem>
            </asp:RadioButtonList>
            </span>
            <span></span>
        </td>
    </tr>
    <tr>
      <td style="height: 25px;" colspan="6">
                
                
                
                            <asp:Panel ID="panelCodigo" runat="server" Height="60px" Width="700px">
                <table width="700" style="font-size: 9pt; font-family: Arial" cellpadding="5">
                    <tr>
                        <td style="width: 44px; height: 20px; font-weight: bold;">                          Código</td>
                        <td style="width: 50px; height: 20px; font-weight: bold;">
                            <asp:TextBox ID="tbCodigo" runat="server" CausesValidation="True" Width="50px" MaxLength="4"></asp:TextBox></td>
                        <td style="width: 413px; height: 20px; text-align: left; font-weight: bold;" align="left">
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="tbCodigo"
                                ErrorMessage="El código es un campo numérico (4 dig máx)." Font-Size="Small" ValidationExpression="\d?\d?\d?\d"></asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="3" style="height: 20px; text-align: left; font-weight: bold;">
                            Ingrese el número del código de propiedad (Ej: P0000023, ingrese 23)</td>
                    </tr>
                </table>
                                </asp:Panel>
                            <asp:Panel ID="panelFiltros" runat="server" Height="315px" Width="700px">
                              <table width="700" border=0 cellpadding=5 cellspacing=0 style="font-size: 9pt; font-family: Arial; text-align: left;">
                                <tr>
                                  <td style="width: 74px; height: 24px; color: #FFFFFF; font-weight: bold;">  Ambientes</td>
                                  <td style="width: 130px; height: 24px; color: #FFFFFF; font-weight: bold;">
                                    <asp:DropDownList ID="ddlAmbientes" runat="server" Font-Names="Arial" Font-Size="9pt"> </asp:DropDownList></td>
                                  <td style="width: 105px; height: 24px; color: #FFFFFF; font-weight: bold;">  Tipo de propiedad</td>
                                  <td style="width: 130px; height: 26px; color: #FFFFFF; font-weight: bold;">
                                    <asp:DropDownList ID="ddlTipoPropiedad" runat="server" Width="120px" Font-Names="Arial" Font-Size="9pt"> </asp:DropDownList></td>
                                  <td style="width: 73px; height: 24px; color: #FFFFFF; font-weight: bold;">&nbsp; </td>
                                  <td style="width: 60px; height: 24px; color: #FFFFFF; font-weight: bold;"> </td>
                                </tr>
                                <tr>
                                  <td style="width: 74px; height: 26px; color: #FFFFFF; font-weight: bold;">  Valor Minimo</td>
                                  <td style="width: 130px; height: 24px; color: #FFFFFF; font-weight: bold;">
                                    <asp:TextBox ID="tbValorDesde" runat="server" Width="100px" Font-Names="Arial" Font-Size="9pt" MaxLength="8"></asp:TextBox></td>
                                  <td style="width: 105px; height: 26px; color: #FFFFFF; font-weight: bold;"> Valor Máximo</td>
                                  <td style="width: 130px; height: 26px; color: #FFFFFF; font-weight: bold;">
                                    <asp:TextBox ID="tbValorHasta" runat="server" Width="100px" Font-Names="Arial" Font-Size="9pt" MaxLength="8"></asp:TextBox></td>
                                  <td style="width: 73px; height: 26px; color: #FFFFFF; font-weight: bold;">  Buscar en</td>
                                  <td style="width: 60px; height: 26px; color: #FFFFFF; font-weight: bold;">
                                    <asp:DropDownList ID="ddlMoneda" runat="server" Font-Names="Arial" Font-Size="9pt" Width="60px"> </asp:DropDownList></td>
                                </tr>
                                <tr>
                                  <td colspan="6" style="height: 16px; color: #FFFFFF; font-weight: bold;">
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbValorDesde"
                ErrorMessage="El valor minimo es un campo numérico (8 dig máx)." ValidationExpression="\d?\d?\d?\d?\d?\d?\d?\d" Font-Size="X-Small"></asp:RegularExpressionValidator>
                                    <br />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tbValorHasta"
                ErrorMessage="El valor máximo es un campo numérico  (8 dig máx)." ValidationExpression='\d?\d?\d?\d?\d?\d?\d?\d' Font-Size="X-Small"></asp:RegularExpressionValidator></td>
                                </tr>
                                <tr>
                                  <td style="width: 74px; height: 20px; color: #FFFFFF; font-weight: bold;"> Ubicación</td>
                                  <td style="width: 130px; height: 20px; color: #FFFFFF; font-weight: bold;"> </td>
                                  <td style="width: 105px; height: 20px; color: #FFFFFF; font-weight: bold;"> </td>
                                  <td style="width: 130px; height: 20px; color: #FFFFFF; font-weight: bold;"> </td>
                                  <td style="width: 73px; height: 20px; color: #FFFFFF; font-weight: bold;"> </td>
                                  <td style="width: 60px; height: 20px; color: #FFFFFF; font-weight: bold;"> </td>
                                </tr>
                                <tr>
                                  <td style="width: 74px; height: 26px; color: #FFFFFF; font-weight: bold;">  Pais</td>
                                  <td style="width: 130px; height: 26px; color: #FFFFFF; font-weight: bold;">
                                    <asp:DropDownList ID="ddlPais" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPais_SelectedIndexChanged"
                Width="130px" Font-Names="Arial" Font-Size="9pt"> </asp:DropDownList></td>
                                  <td style="width: 105px; height: 26px; color: #FFFFFF; font-weight: bold;">  Provincia</td>
                                  <td style="width: 130px; height: 26px; color: #FFFFFF; font-weight: bold;">
                                    <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"
                Width="130px" Font-Names="Arial" Font-Size="9pt"> </asp:DropDownList></td>
                                  <td style="width: 73px; height: 26px; color: #FFFFFF; font-weight: bold;"> </td>
                                  <td style="width: 60px; height: 26px; color: #FFFFFF; font-weight: bold;"> </td>
                                </tr>
                                <tr>
                                  <td style="width: 74px; height: 31px; color: #FFFFFF; font-weight: bold;">  Localidad</td>
                                  <td style="width: 130px; height: 31px; color: #FFFFFF; font-weight: bold;">
                                    <asp:DropDownList ID="ddlLocalidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLocalidad_SelectedIndexChanged"
                Width="130px" Font-Names="Arial" Font-Size="9pt"> </asp:DropDownList></td>
                                  <td style="width: 105px; height: 31px; color: #FFFFFF; font-weight: bold;">  Barrio 1</td>
                                  <td style="width: 130px; height: 31px; color:Black; font-weight:normal;"><asp:DropDownList ID="ddlBarrio1" runat="server" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"
                Width="130px" Font-Names="Arial" Font-Size="9pt">
                                  </asp:DropDownList></td>
                                  <td style="width: 60px; height: 31px; color: #FFFFFF; font-weight: bold;"> </td>
                                </tr>
                                  <tr>
                                      <td style="font-weight: bold; width: 74px; color: #ffffff; height: 31px">
                                      </td>
                                      <td style="font-weight: bold; width: 130px; color: #ffffff; height: 31px">
                                      </td>
                                      <td style="font-weight: bold; width: 105px; color: #ffffff; height: 31px">
                                          Barrio 2</td>
                                      <td style="font-weight: normal; width: 130px; color: black; height: 31px">
                                          <asp:DropDownList ID="ddlBarrio2" runat="server" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"
                Width="130px" Font-Names="Arial" Font-Size="9pt">
                                          </asp:DropDownList></td>
                                      <td style="font-weight: bold; width: 60px; color: #ffffff; height: 31px">
                                      </td>
                                  </tr>
                                  <tr>
                                      <td style="font-weight: bold; width: 74px; color: #ffffff; height: 31px">
                                      </td>
                                      <td style="font-weight: bold; width: 130px; color: #ffffff; height: 31px">
                                      </td>
                                      <td style="font-weight: bold; width: 105px; color: #ffffff; height: 31px">
                                          Barrio 3</td>
                                      <td style="font-weight: normal; width: 130px; color: black; height: 31px">
                                          <asp:DropDownList ID="ddlBarrio3" runat="server" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"
                Width="130px" Font-Names="Arial" Font-Size="9pt">
                                          </asp:DropDownList></td>
                                      <td style="font-weight: bold; width: 60px; color: #ffffff; height: 31px">
                                      </td>
                                  </tr>
                              </table>
      </asp:Panel></td>
    </tr>
</table>
