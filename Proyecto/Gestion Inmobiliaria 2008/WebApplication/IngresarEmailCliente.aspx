<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresarEmailCliente.aspx.cs" Inherits="WebApplication.IngresarEmailCliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ingresar dirección de Email</title>
    <style type="text/css">
<!--
.style1 {color: #FFFFFF}
.style2 {	font-family: Arial, Helvetica, sans-serif;
	color: #FFFFFF;
}
.style22 {color: #FFFFFF;
	font-weight: bold;
	font-family: Geneva, Arial, Helvetica, sans-serif;
	font-size: 36px;
}
.style23 {font-size: 20px}
body {
	background-image: url(images/fondos%20iimg/fdo_pag.jpg);
}
a:link {
	color: #666666;
	text-decoration: none;
}
a:visited {
	color: #666666;
	text-decoration: none;
}
a:hover {
	color: #666666;
	text-decoration: none;
}
a:active {
	color: #666666;
	text-decoration: none;
}
.style24 {font-size: 8pt}
.style25 {color: #FFFFFF; font-size: 8pt; }
-->
    </style>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1"></head>
<body>
    <div align="center">
      <table width="750" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td><object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,29,0" width="750" height="130">
              <param name="movie" value="flash/encabezado.swf" />
              <param name="quality" value="high" />
              <embed src="flash/encabezado.swf" quality="high" pluginspage="http://www.macromedia.com/go/getflashplayer" type="application/x-shockwave-flash" width="750" height="130"></embed>
          </object></td>
        </tr>
      </table>
    </div>
    <table width="750" height="659" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr bordercolor="#333333">
        <td width="6" valign="top" bordercolor="#333333" background="images/fondos%20iimg/LINEA-vert.jpg" class="style5 style14"><p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p></td>
        <td width="735" valign="top" class="style5 style14"><div align="center">
            <p>&nbsp;</p>
            <div align="center">
              <table width="740" align="center" cellpadding="0" cellspacing="0">
                <tr>
                  <td height="30" bgcolor="#000000"><div align="center"><strong><span class="style2">Carga de Pedido de Propiedad </span></strong></div></td>
                </tr>
              </table>
              <br />
          </div>
            <form id="form1" runat="server">
              <div>
                <div align="center"><span style="font-size: 9pt; font-family: Arial"> &nbsp;<span class="style1"> Ingrese su direcci&oacute;n de e-mail para ingresar al sistema </span></span>
                  <table border="1" cellpadding="0" cellspacing="0" bordercolor="#990000">
                    <tr>
                      <td><p><img src="images/persona.gif" width="100" height="126" /></p>                      </td>
                      <td><table cellpadding="5" style="font-size: 9pt; font-family: Arial">
                        <tr>
                          <td style="width: 140px"> <span class="style1">
                            <asp:Label ID="Label1" runat="server" Text="E-mail"></asp:Label>
                          </span></td>
                          <td style="width: 100px"> <span class="style1">
                            <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
                          </span></td>
                          <td style="width: 100px"> <span class="style1">
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbEmail"
                                  ErrorMessage="Debe ingresar un correo"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbEmail"
                        ErrorMessage="Email inv&aacute;lido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                          </span></td>
                        </tr>
                        <tr>
                          <td style="width: 140px"><span class="style1"> Confirme su E-mail</span></td>
                          <td style="width: 100px"> <span class="style1">
                            <asp:TextBox ID="tbConfirmar" runat="server"></asp:TextBox>
                          </span></td>
                          <td style="width: 100px"> <span class="style1">
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbConfirmar"
                                  ErrorMessage="Debe ingresar un correo"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tbConfirmar"
                        ErrorMessage="Email inv&aacute;lido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                          </span></td>
                        </tr>
                        <tr>
                          <td colspan="3" style="text-align: center"> <span class="style1">
                            <asp:Label ID="lError" runat="server" Font-Names="Arial" Font-Size="Small" ForeColor="Red"></asp:Label>
                          </span></td>
                        </tr>
                        <tr valign="middle" bgcolor="#5d5d5d">
                          <td colspan="3" style="text-align: center"> <span class="style1">
                            <asp:ImageButton ID="bAceptar" ImageUrl="images/enviar1.gif" runat="server" OnClick="bAceptar_Click" /></span> </td>
                        </tr>
                      </table></td>
                    </tr>
                  </table>
                  <br />
                </div>
              </div>
            </form>
            <p>&nbsp;</p>
            <p align="center"><br />
&nbsp;&nbsp;&nbsp;&nbsp;</p>
            <p align="center">&nbsp; </p>
            <p><span class="style22">4796-5127<br />
                  <a href="mailto:info@pime.com.ar"><span class="style23">info@pime.com.ar</span></a></span></p>
        </div></td>
        <td width="5" valign="top" bordercolor="#333333" background="images/fondos%20iimg/LINEA-vert1.jpg" class="style5 style14">&nbsp;</td>
      </tr>
    </table>
    <p align="center">&nbsp;</p>
    <p>&nbsp;</p>
</body>
</html>
