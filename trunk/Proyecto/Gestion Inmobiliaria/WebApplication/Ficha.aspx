<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="WebApplication.Ficha" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Ficha de propiedad</title>
    <style type="text/css">
<!--
.style1 {
	color: #FFFFFF;
	font-weight: bold;
}
.style2 {
	font-size: 12pt;
	font-weight: bold;
}
a:link {
	color: #000000;
	text-decoration: none;
}
a:visited {
	text-decoration: none;
	color: #333333;
}
a:hover {
	text-decoration: none;
	color: #333333;
}
a:active {
	text-decoration: none;
	color: #333333;
}
.style4 {font-size: 10px}
.style5 {font-size: 10pt}
.style6 {
	color: #FF0000;
	font-weight: bold;
}
body {
	background-image: url(images/fondos%20iimg/fdo_pag.jpg);
}
-->
    </style>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1"></head>
<body>
    <table width="802" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td bgcolor="#FFFFFF"><img src="images/hojas-enc.gif" width="800" height="131" /><br />
          <form id="form1" runat="server">
            <div style="text-align: center">
              <div align="center">
                <table width="802" border="1" cellspacing="0" cellpadding="0">
                  <tr>
                    <td bgcolor="#FFFFFF"><table width="800" style="font-size: 10pt; font-family: Arial">
                        <tr bgcolor="#FF0000">
                          <td height="30" colspan="10" style="text-align: center">
                            <asp:Label ID="lDireccion" runat="server" Font-Size="16pt" Font-Names="Arial" Font-Bold="true" ForeColor="#FFFFFF"></asp:Label></td>
                        </tr>
                        <tr>
                          <td colspan="10" style="text-align: center"> </td>
                        </tr>
                        <tr>
                          <td style="border-right: thin solid; border-top: thin solid; border-left: thin solid; border-bottom: thin solid; text-align: center;" colspan="5" rowspan="17">
                            <asp:Image ID="iFachada" runat="server" ImageAlign="Middle" /></td>
                          <td height="15" colspan="5" style="text-align: center; background-color: #ff0000;">
                            <div align="center" class="style1"> CARACTER&Iacute;STICAS GENERALES</div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="2" style="width: 197px; text-align: right;">
                            <div align="right"> C&oacute;digo:</div></td>
                          <td width="53" height="15" style="width: 5px"> </td>
                          <td width="133" height="15" colspan="2" style="text-align: left">
                            <div align="left">
                              <asp:Label ID="lCodigo" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                          </div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="2" style="text-align: right; width: 197px;">
                            <div align="right"> <span class="style5">Operaci&oacute;n</span>:</div></td>
                          <td height="15" style="width: 5px"><span class="style4"></span> </td>
                          <td height="15" colspan="2" align="left">
                            <div align="left" class="style4">
                              <asp:Label ID="lOperacion" runat="server" Font-Names="Arial" Font-Size="12pt" Font-Bold="true"></asp:Label>
                          </div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="2" style="text-align: right; width: 197px;">
                            <div align="right">Ubicaci&oacute;n:</div></td>
                          <td height="15" style="width: 5px"> </td>
                          <td height="15" colspan="2" align="left">
                            <div align="left">
                              <asp:Label ID="lLocalizacion" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                          </div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="2" style="text-align: right; width: 197px;">
                            <div align="right">Ambientes:</div></td>
                          <td height="15" style="width: 5px"> </td>
                          <td height="15" colspan="2" align="left">
                            <div align="left">
                              <asp:Label ID="lAmbientes" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                          </div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="2" style="text-align: right; width: 197px;">
                            <div align="right">Tipo de unidad:</div></td>
                          <td height="15" style="width: 5px"> </td>
                          <td height="15" colspan="2" align="left">
                            <div align="left">
                              <asp:Label ID="lTipoUnidad" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                          </div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="2" style="text-align: right; width: 197px;">
                            <div align="right">Orientaci&oacute;n:</div></td>
                          <td height="15" style="width: 5px"> </td>
                          <td height="15" colspan="2" align="left">
                            <div align="left">
                              <asp:Label ID="lOrientacion" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                          </div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="2" style="text-align: right; width: 197px;">
                            <div align="right">Antig&uuml;edad:</div></td>
                          <td height="15" style="width: 5px"> </td>
                          <td height="15" colspan="2" align="left">
                            <div align="left">
                              <asp:Label ID="lAntiguedad" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                          </div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="2" style="text-align: right; width: 197px;">
                            <div align="right">Estado:</div></td>
                          <td height="15" style="width: 5px"> </td>
                          <td height="15" colspan="2" align="left">
                            <div align="left">
                              <asp:Label ID="lEstado" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                          </div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="5" style="text-align: center">
                            <div align="right"></div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="5" style="text-align: center; background-color: #ff0000;">
                            <div align="center" class="style1"> SUPERFICIES</div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="2" style="text-align: right; width: 197px;">
                            <div align="right">
                              <asp:Label ID="lNombSup1" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                          </div></td>
                          <td height="15" style="width: 5px"> </td>
                          <td height="15" colspan="2" align="left">
                            <div align="left">
                              <asp:Label ID="lSup1" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                          </div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="2" style="text-align: right; width: 197px;">
                            <div align="right">
                              <asp:Label ID="lNombSup2" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                          </div></td>
                          <td height="15" style="width: 5px"> </td>
                          <td height="15" colspan="2" align="left">
                            <div align="left">
                              <asp:Label ID="lSup2" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                          </div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="2" style="text-align: right; width: 197px;">
                            <div align="right">
                              <asp:Label ID="lNombSup3" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                          </div></td>
                          <td height="15" style="width: 5px"> </td>
                          <td height="15" colspan="2" align="left">
                            <div align="left">
                              <asp:Label ID="lSup3" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                          </div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="2" style="text-align: right; width: 197px;">
                            <div align="right"></div></td>
                          <td height="15" style="width: 5px"> </td>
                          <td height="15" colspan="2">
                            <div align="left"></div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="5" style="background-color: #ff0000; text-align: center;">
                            <div align="center" class="style1"> PRECIO</div></td>
                        </tr>
                        <tr>
                          <td height="15" colspan="2" bgcolor="#CCCCCC" style="width: 197px; text-align: right">
                            <div align="right"><span class="style2">Precio</span>:</div></td>
                          <td height="15" bgcolor="#CCCCCC" style="width: 5px"> </td>
                          <td height="15" colspan="2" align="left" bgcolor="#CCCCCC">
                            <div align="left">
                              <asp:Label ID="lPrecio" runat="server" Font-Names="Arial" Font-Size="Large" Font-Bold="true"></asp:Label>
                          </div></td>
                        </tr>
                        <tr>
                          <td width="86" style="width: 100px"> </td>
                          <td width="86" style="width: 100px"> </td>
                          <td width="86" style="width: 100px"> </td>
                          <td width="86" style="width: 100px"> </td>
                          <td width="85" style="width: 100px"> </td>
                          <td colspan="2" style="text-align: right; width: 197px;"> </td>
                          <td style="width: 5px"> </td>
                          <td colspan="2"> </td>
                        </tr>
                      </table>
                        <br />
                        <table width="800px" cellpadding="5">
                          <tr>
                            <td style="width: 800px; text-align: left; height: 18px; background-color: #ff0000;"> <span style="font-size: 10pt; font-family: Arial"><span class="style1">GALERIA DE FOTOS</span>
                                  <asp:Label ID="lSinFotos"
                        runat="server" Font-Names="Arial" Font-Size="10pt"></asp:Label>
                            </span></td>
                          </tr>
                          <tr>
                            <td style="height: 100%">
                              <div style="vertical-align top; width:780px; height: 135px; overflow:auto;">
                                <asp:DataList ID="DataList1" runat="server" Height="110px" RepeatColumns="30"
                        ShowFooter="False" ShowHeader="False" Width="100%" CellPadding="2" HorizontalAlign="Center" RepeatDirection="Horizontal" OnItemCommand="DataList1_ItemCommand">
                                  <ItemTemplate> <a href="<%# DataBinder.Eval(Container.DataItem, "Link")%>" target="_self"><img alt="Foto" align="top" src='<%# DataBinder.Eval(Container.DataItem, "Thumbnail")%>' height="110" width="110"/></a> </ItemTemplate>
                                  <ItemStyle BorderColor="White" BorderWidth="0px" Height="110px"
                            HorizontalAlign="Center" VerticalAlign="Middle" Width="110px" Wrap="False" />            
                    </asp:DataList>
                            </div></td>
                          </tr>
                        </table>
                        <br />
                        <span style="font-size: 9pt; font-family: Arial">&nbsp; &nbsp;&nbsp;</span>
                        <table width="800" style="font-size: 9pt; font-family: Arial">
                          <tr>
                            <td colspan="3" style="background-color: #ff0000; text-align: center">
                              <asp:Label ID="lTituloDetalles1" runat="server" Font-Names="Arial" Font-Size="10pt" Font-Bold="true" ForeColor="#FFFFFF" R></asp:Label></td>
                            <td style="width: 15px"> </td>
                            <td colspan="3" bgcolor="#FF0000" style="background-color: #ff0000; text-align: center"> <span style="font-size: 10pt; color: #FFFFFF; font-weight: bold;"> DETALLE AMBIENTES</span></td>
                          </tr>
                          <tr>
                            <td style="width: 200px" align="right">
                              <asp:Label ID="r1c1" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 5px"> </td>
                            <td style="width: 200px" align="left">
                              <asp:Label ID="r1v1" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 20px"> </td>
                            <td align="right" bordercolor="#CCCCCC" style="width: 240px;">
                              <asp:Label ID="r2c1" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td bordercolor="#CCCCCC" style="width: 5px"> </td>
                            <td align="left" bordercolor="#CCCCCC" style="width: 220px">
                              <asp:Label ID="r2v1" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                          </tr>
                          <tr>
                            <td style="width: 200px;" align="right">
                              <asp:Label ID="r1c2" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 5px"> </td>
                            <td style="width: 200px" align="left">
                              <asp:Label ID="r1v2" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 15px"> </td>
                            <td align="right" bordercolor="#CCCCCC" style="width: 240px;">
                              <asp:Label ID="r2c2" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td bordercolor="#CCCCCC" style="width: 5px"> </td>
                            <td align="left" bordercolor="#CCCCCC" style="width: 220px">
                              <asp:Label ID="r2v2" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                          </tr>
                          <tr>
                            <td style="width: 200px;" align="right" >
                              <asp:Label ID="r1c3" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 5px"> </td>
                            <td style="width: 200px" align="left">
                              <asp:Label ID="r1v3" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 15px"> </td>
                            <td align="right" bordercolor="#CCCCCC" style="width: 240px;" >
                              <asp:Label ID="r2c3" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label>
                            </td>
                            <td bordercolor="#CCCCCC" style="width: 5px"> </td>
                            <td align="left" bordercolor="#CCCCCC" style="width: 220px">
                              <asp:Label ID="r2v3" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                          </tr>
                          <tr>
                            <td style="width: 200px;" align="right">
                              <asp:Label ID="r1c4" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 5px"> </td>
                            <td style="width: 200px" align="left">
                              <asp:Label ID="r1v4" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 15px"> </td>
                            <td align="right" bordercolor="#CCCCCC" style="width: 240px;" >
                              <asp:Label ID="r2c4" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td bordercolor="#CCCCCC" style="width: 5px"> </td>
                            <td align="left" bordercolor="#CCCCCC" style="width: 220px">
                              <asp:Label ID="r2v4" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                          </tr>
                          <tr>
                            <td style="width: 200px;" align="right" >
                              <asp:Label ID="r1c5" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 5px"> </td>
                            <td style="width: 200px" align="left">
                              <asp:Label ID="r1v5" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 15px"> </td>
                            <td align="right" bordercolor="#CCCCCC" style="width: 240px;">
                              <asp:Label ID="r2c5" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td bordercolor="#CCCCCC" style="width: 5px"> </td>
                            <td align="left" bordercolor="#CCCCCC" style="width: 220px">
                              <asp:Label ID="r2v5" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                          </tr>
                          <tr>
                            <td style="width: 200px;" align="right">
                              <asp:Label ID="r1c6" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 5px"> </td>
                            <td style="width: 200px" align="left">
                              <asp:Label ID="r1v6" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 15px"> </td>
                            <td align="right" bordercolor="#CCCCCC" style="width: 240px;">
                              <asp:Label ID="r2c6" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td bordercolor="#CCCCCC" style="width: 5px"> </td>
                            <td align="left" bordercolor="#CCCCCC" style="width: 220px">
                              <asp:Label ID="r2v6" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                          </tr>
                          <tr>
                            <td style="width: 200px;" align="right">
                              <asp:Label ID="r1c7" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 5px"> </td>
                            <td style="width: 200px" align="left">
                              <asp:Label ID="r1v7" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 15px"> </td>
                            <td align="right" bordercolor="#CCCCCC" style="width: 240px;" >
                              <asp:Label ID="r2c7" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td bordercolor="#CCCCCC" style="width: 5px"> </td>
                            <td align="left" bordercolor="#CCCCCC" style="width: 220px">
                              <asp:Label ID="r2v7" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                          </tr>
                          <tr>
                            <td style="width: 200px;" align="right" >
                              <asp:Label ID="r1c8" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 5px"> </td>
                            <td style="width: 200px" align="left">
                              <asp:Label ID="r1v8" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 15px"> </td>
                            <td align="right" bordercolor="#CCCCCC" style="width: 240px;" >
                              <asp:Label ID="r2c8" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td bordercolor="#CCCCCC" style="width: 5px"> </td>
                            <td align="left" bordercolor="#CCCCCC" style="width: 220px">
                              <asp:Label ID="r2v8" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                          </tr>
                          <tr>
                            <td style="width: 200px;" align="right" >
                              <asp:Label ID="r1c9" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 5px"> </td>
                            <td style="width: 200px" align="left">
                              <asp:Label ID="r1v9" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td style="width: 15px"> </td>
                            <td align="right" bordercolor="#CCCCCC" style="width: 240px;" >
                              <asp:Label ID="r2c9" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            <td bordercolor="#CCCCCC" style="width: 5px"> </td>
                            <td align="left" bordercolor="#CCCCCC" style="width: 220px">
                              <asp:Label ID="r2v9" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                          </tr>
                            <tr>
                                <td align="right" style="width: 200px">
                                </td>
                                <td style="width: 5px">
                                </td>
                                <td align="left" style="width: 200px">
                                </td>
                                <td style="width: 15px">
                                </td>
                                <td align="right" bordercolor="#cccccc" style="width: 240px">
                                    <asp:Label ID="r2c10" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                                <td bordercolor="#cccccc" style="width: 5px">
                                </td>
                                <td align="left" bordercolor="#cccccc" style="width: 220px">
                                    <asp:Label ID="r2v10" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 200px">
                                </td>
                                <td style="width: 5px">
                                </td>
                                <td align="left" style="width: 200px">
                                </td>
                                <td style="width: 15px">
                                </td>
                                <td align="right" bordercolor="#cccccc" style="width: 240px">
                                    <asp:Label ID="r2c11" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                                <td bordercolor="#cccccc" style="width: 5px">
                                </td>
                                <td align="left" bordercolor="#cccccc" style="width: 220px">
                                    <asp:Label ID="r2v11" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 200px">
                                </td>
                                <td style="width: 5px">
                                </td>
                                <td align="left" style="width: 200px">
                                </td>
                                <td style="width: 15px">
                                </td>
                                <td align="right" bordercolor="#cccccc" style="width: 240px">
                                    <asp:Label ID="r2c12" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                                <td bordercolor="#cccccc" style="width: 5px">
                                </td>
                                <td align="left" bordercolor="#cccccc" style="width: 220px">
                                    <asp:Label ID="r2v12" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 200px">
                                </td>
                                <td style="width: 5px">
                                </td>
                                <td align="left" style="width: 200px">
                                </td>
                                <td style="width: 15px">
                                </td>
                                <td align="right" bordercolor="#cccccc" style="width: 240px">
                                    <asp:Label ID="r2c13" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                                <td bordercolor="#cccccc" style="width: 5px">
                                </td>
                                <td align="left" bordercolor="#cccccc" style="width: 220px">
                                    <asp:Label ID="r2v13" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 200px">
                                </td>
                                <td style="width: 5px">
                                </td>
                                <td align="left" style="width: 200px">
                                </td>
                                <td style="width: 15px">
                                </td>
                                <td align="right" bordercolor="#cccccc" style="width: 240px">
                                    <asp:Label ID="r2c14" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                                <td bordercolor="#cccccc" style="width: 5px">
                                </td>
                                <td align="left" bordercolor="#cccccc" style="width: 220px">
                                    <asp:Label ID="r2v14" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 200px">
                                </td>
                                <td style="width: 5px">
                                </td>
                                <td align="left" style="width: 200px">
                                </td>
                                <td style="width: 15px">
                                </td>
                                <td align="right" bordercolor="#cccccc" style="width: 240px">
                                    <asp:Label ID="r2c15" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                                <td bordercolor="#cccccc" style="width: 5px">
                                </td>
                                <td align="left" bordercolor="#cccccc" style="width: 220px">
                                    <asp:Label ID="r2v15" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 200px">
                                </td>
                                <td style="width: 5px">
                                </td>
                                <td align="left" style="width: 200px">
                                </td>
                                <td style="width: 15px">
                                </td>
                                <td align="right" bordercolor="#cccccc" style="width: 240px">
                                    <asp:Label ID="r2c16" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                                <td bordercolor="#cccccc" style="width: 5px">
                                </td>
                                <td align="left" bordercolor="#cccccc" style="width: 220px">
                                    <asp:Label ID="r2v16" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 200px">
                                </td>
                                <td style="width: 5px">
                                </td>
                                <td align="left" style="width: 200px">
                                </td>
                                <td style="width: 15px">
                                </td>
                                <td align="right" bordercolor="#cccccc" style="width: 240px">
                                    <asp:Label ID="r2c17" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                                <td bordercolor="#cccccc" style="width: 5px">
                                </td>
                                <td align="left" bordercolor="#cccccc" style="width: 220px">
                                    <asp:Label ID="r2v17" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 200px">
                                </td>
                                <td style="width: 5px">
                                </td>
                                <td align="left" style="width: 200px">
                                </td>
                                <td style="width: 15px">
                                </td>
                                <td align="right" bordercolor="#cccccc" style="width: 240px">
                                    <asp:Label ID="r2c18" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                                <td bordercolor="#cccccc" style="width: 5px">
                                </td>
                                <td align="left" bordercolor="#cccccc" style="width: 220px">
                                    <asp:Label ID="r2v18" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 200px">
                                </td>
                                <td style="width: 5px">
                                </td>
                                <td align="left" style="width: 200px">
                                </td>
                                <td style="width: 15px">
                                </td>
                                <td align="right" bordercolor="#cccccc" style="width: 240px">
                                </td>
                                <td bordercolor="#cccccc" style="width: 5px">
                                </td>
                                <td align="left" bordercolor="#cccccc" style="width: 220px">
                                </td>
                            </tr>
                          <tr>
                            <td colspan="7" style="background-color: #ff0000; text-align: center"> <span style="font-size: 10pt; color: #FFFFFF; font-weight: bold;"> OBSERVACIONES</span></td>
                          </tr>
                          <tr>
                            <td colspan="7" style="text-align: center">
                              <asp:Label ID="lObservaciones" runat="server" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                          </tr>
                        </table>
                        <br />
                        <table width="800" border="1" bordercolor="#666666" style="border-top: thin solid">
                          <tr>
                            <td bordercolor="#CCCCCC" style="width: 200px">
                              <div align="center">
                                <asp:Image ID="Image1" runat="server" Height="60px" ImageUrl="~/imagenes/logo_PieFicha.gif"
                        Width="135px" />            
                </div></td>
                            <td bordercolor="#CCCCCC" style="width: 400px">
                              <div align="center"><span style="font-family: Arial"><span style="font-size: 10pt"> <span class="style6">PIME Negocios Inmobiliarios</span><br />
                    (011) 4796.5127<br />
                            </span></span> <a href="mailto:info@pime.com.ar"><span style="font-size: 10pt;
                                font-family: Arial">info@pime.com.ar</span></a><span style="font-size: 10pt; font-family: Arial"> </span> </div></td>
                            <td bordercolor="#CCCCCC" style="width: 200px">
                              <div align="center"><a href="Propiedades.aspx"><span style="font-size: 10pt; font-family: Arial"> Volver al Listado</span></a></div></td>
                            <td bordercolor="#CCCCCC" style="width: 200px"><div align="center"><a href="javascript:window.print() "><img src='images/i_print.jpg' alt='imprimir ficha' name='imprimir'width='30'height='30'border='0' id="imprimir" /></a></div></td>
                          </tr>
                      </table></td>
                  </tr>
                </table>
              </div>
            </div>
        </form></td>
      </tr>
    </table>
    <p align="center">&nbsp;</p>
    </body>
</html>
