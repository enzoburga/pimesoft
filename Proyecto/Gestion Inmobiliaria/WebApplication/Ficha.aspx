<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="WebApplication.Ficha" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <table width="800" style="font-size: 9pt; font-family: Arial">
            <tr>
                <td colspan="10" style="text-align: center">
                    <asp:Label ID="lDireccion" runat="server" Font-Size="12pt" Font-Names="Arial"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="10" style="text-align: center">
                    </td>
            </tr>
            <tr>
                <td style="border-right: thin solid; border-top: thin solid; border-left: thin solid; border-bottom: thin solid; text-align: center;" colspan="5" rowspan="17">
                    <asp:Image ID="iFachada" runat="server" Height="450px" ImageAlign="Middle" Width="450px" /></td>
                <td colspan="5" style="text-align: center; background-color: #6699ff;">
                    <span style="font-size: 10pt">
                    CARACTERÍSTICAS GENERALES</span></td>
            </tr>
            <tr>
                <td colspan="2" style="width: 197px; text-align: right;">
                    Código:</td>
                <td style="width: 5px">
                </td>
                <td colspan="2" style="text-align: left">
                    <asp:Label ID="lCodigo" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right; width: 197px;">
                    Operación:</td>
                <td style="width: 5px">
                </td>
                <td colspan="2" align="left">
                    <asp:Label ID="lOperacion" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right; width: 197px;">
                    Localización:</td>
                <td style="width: 5px">
                </td>
                <td colspan="2" align="left">
                    <asp:Label ID="lLocalizacion" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right; width: 197px;">
                    Ambientes:</td>
                <td style="width: 5px">
                </td>
                <td colspan="2" align="left">
                    <asp:Label ID="lAmbientes" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right; width: 197px;">
                    Tipo de unidad:</td>
                <td style="width: 5px">
                </td>
                <td colspan="2" align="left">
                    <asp:Label ID="lTipoUnidad" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right; width: 197px;">
                    Orientación:</td>
                <td style="width: 5px">
                </td>
                <td colspan="2" align="left">
                    <asp:Label ID="lOrientacion" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right; width: 197px;">
                    Antigüedad:</td>
                <td style="width: 5px">
                </td>
                <td colspan="2" align="left">
                    <asp:Label ID="lAntiguedad" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right; width: 197px;">
                    Estado:</td>
                <td style="width: 5px">
                </td>
                <td colspan="2" align="left">
                    <asp:Label ID="lEstado" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="5" style="text-align: center">
                </td>
            </tr>
            <tr>
                <td colspan="5" style="text-align: center; background-color: #6699ff;">
                    <span style="font-size: 10pt">
                    SUPERFICIES</span></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right; width: 197px;">
                    <asp:Label ID="lNombSup1" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td colspan="2" align="left">
                    <asp:Label ID="lSup1" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right; width: 197px;">
                    <asp:Label ID="lNombSup2" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td colspan="2" align="left">
                    <asp:Label ID="lSup2" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right; width: 197px;">
                    <asp:Label ID="lNombSup3" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td colspan="2" align="left">
                    <asp:Label ID="lSup3" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right; width: 197px;">
                    </td>
                <td style="width: 5px">
                </td>
                <td colspan="2">
                    </td>
            </tr>
            <tr>
                <td style="background-color: #6699ff; text-align: center;" colspan="5">
                    <span style="font-size: 10pt">
                    PRECIO</span></td>
            </tr>
            <tr>
                <td colspan="2" style="width: 197px; text-align: right">
                    Precio:</td>
                <td style="width: 5px">
                </td>
                <td colspan="2" align="left">
                    <asp:Label ID="lPrecio" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td colspan="2" style="text-align: right; width: 197px;">
                    </td>
                <td style="width: 5px">
                </td>
                <td colspan="2">
                    </td>
            </tr>
        </table>
        <br />
        <table width="800px" cellpadding="5">
            <tr>
                <td style="width: 800px; text-align: left; height: 18px; background-color: #6699ff;">
                    <span style="font-size: 10pt; font-family: Arial">GALERIA DE FOTOS</span></td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: left">
                <div style="vertical-align top; width:800px; height: 135px; overflow:auto;"> 
                    <asp:DataList ID="DataList1" runat="server" Height="110px" RepeatColumns="15"
                        ShowFooter="False" ShowHeader="False" Width="100%" CellPadding="2" HorizontalAlign="Center" RepeatDirection="Horizontal">
                        <ItemTemplate>
                            <a href="<%# DataBinder.Eval(Container.DataItem, "Link")%>" target="_blank"><img alt="Foto" align="top" height = "100px" width="100px" src='<%# DataBinder.Eval(Container.DataItem, "Thumbnail")%>'/></a>
                        </ItemTemplate>
                        <ItemStyle BorderColor="White" BorderWidth="0px" Height="110px"
                            HorizontalAlign="Center" VerticalAlign="Middle" Width="110px" Wrap="False" />
                    </asp:DataList></div></td>
                    
            </tr>
        </table>
        <br />
        <span style="font-size: 9pt; font-family: Arial">&nbsp; &nbsp;&nbsp;</span><table width="800" style="font-size: 9pt; font-family: Arial">
            <tr>
                <td colspan="3" style="background-color: #6699ff; text-align: center">
                    <asp:Label ID="lTituloDetalles1" runat="server" Font-Names="Arial" Font-Size="10pt"></asp:Label></td>
                <td style="width: 15px">
                </td>
                <td colspan="3" style="background-color: #6699ff; text-align: center">
                    <span style="font-size: 10pt">
                    DETALLE AMBIENTES</span></td>
            </tr>
            <tr>
                <td style="width: 200px" align="right">
                    <asp:Label ID="r1c1" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 200px" align="left">
                    <asp:Label ID="r1v1" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 20px">
                </td>
                <td style="width: 240px;" align="right">
                    <asp:Label ID="r2c1" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 220px" align="left">
                    <asp:Label ID="r2v1" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 200px;" align="right">
                    <asp:Label ID="r1c2" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 200px" align="left">
                    <asp:Label ID="r1v2" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 15px">
                </td>
                <td style="width: 240px;" align="right">
                    <asp:Label ID="r2c2" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 220px" align="left">
                    <asp:Label ID="r2v2" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 200px;" align="right" >
                    <asp:Label ID="r1c3" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 200px" align="left">
                    <asp:Label ID="r1v3" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 15px">
                </td>
                <td style="width: 240px;" align="right" >
                    <asp:Label ID="r2c3" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                </td>
                <td style="width: 5px">
                </td>
                <td style="width: 220px" align="left">
                    <asp:Label ID="r2v3" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 200px;" align="right">
                    <asp:Label ID="r1c4" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 200px" align="left">
                    <asp:Label ID="r1v4" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 15px">
                </td>
                <td style="width: 240px;" align="right" >
                    <asp:Label ID="r2c4" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 220px" align="left">
                    <asp:Label ID="r2v4" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 200px;" align="right" >
                    <asp:Label ID="r1c5" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 200px" align="left">
                    <asp:Label ID="r1v5" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 15px">
                </td>
                <td style="width: 240px;" align="right">
                    <asp:Label ID="r2c5" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 220px" align="left">
                    <asp:Label ID="r2v5" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 200px;" align="right">
                    <asp:Label ID="r1c6" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 200px" align="left">
                    <asp:Label ID="r1v6" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 15px">
                </td>
                <td style="width: 240px;" align="right">
                    <asp:Label ID="r2c6" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 220px" align="left">
                    <asp:Label ID="r2v6" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 200px;" align="right">
                    <asp:Label ID="r1c7" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 200px" align="left">
                    <asp:Label ID="r1v7" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 15px">
                </td>
                <td style="width: 240px;" align="right" >
                    <asp:Label ID="r2c7" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 220px" align="left">
                    <asp:Label ID="r2v7" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 200px;" align="right" >
                    <asp:Label ID="r1c8" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 200px" align="left">
                    <asp:Label ID="r1v8" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 15px">
                </td>
                <td style="width: 240px;" align="right" >
                    <asp:Label ID="r2c8" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 220px" align="left">
                    <asp:Label ID="r2v8" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 200px;" align="right" >
                    <asp:Label ID="r1c9" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 200px" align="left">
                    <asp:Label ID="r1v9" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 15px">
                </td>
                <td style="width: 240px;" align="right" >
                    <asp:Label ID="r2c9" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                <td style="width: 5px">
                </td>
                <td style="width: 220px" align="left">
                    <asp:Label ID="r2v9" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="7" style="background-color: #6699ff; text-align: center">
                    <span style="font-size: 10pt">
                    OBSERVACIONES</span></td>
            </tr>
            <tr>
                <td colspan="7" style="text-align: center">
                    <asp:Label ID="lObservaciones" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
            </tr>
        </table>
    </div>
        <br />
    </form>
</body>
</html>
