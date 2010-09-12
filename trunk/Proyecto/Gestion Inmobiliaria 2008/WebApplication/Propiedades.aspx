<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Propiedades.aspx.cs" Inherits="WebApplication.Propiedades" %>

<%@ Register Src="Controles/ListadoPropiedades.ascx" TagName="ListadoPropiedades"
    TagPrefix="uc2" %>

<%@ Register Src="Controles/ctrlBuscadorPropiedades.ascx" TagName="ctrlBuscadorPropiedades"
    TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Buscador de propiedades</title>
    <style type="text/css">
<!--
.style1 {
	font-family: Verdana, Arial, Helvetica, sans-serif;
	font-weight: bold;
	color: #FFFFFF;
}
body {
	background-image: url(images/fondos%20iimg/fdo_pag.jpg);
}
.style12 {color: #FFFFFF;
	font-weight: bold;
	font-family: Geneva, Arial, Helvetica, sans-serif;
	font-size: 36px;
}
a:link {
	color: #000000;
	text-decoration: none;
}
a:visited {
	text-decoration: none;
	color: #000000;
}
a:hover {
	text-decoration: none;
	color: #000000;
}
a:active {
	text-decoration: none;
	color: #000000;
}
.style14 {font-size: 15px}
.style15 {font-weight: bold; font-family: Geneva, Arial, Helvetica, sans-serif; color: #FFFFFF;}
.style16 {font-family: Geneva, Arial, Helvetica, sans-serif; font-weight: bold;}
-->
    </style>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<script language="JavaScript" type="text/JavaScript">
<!--



function MM_preloadImages() { //v3.0
  var d=document; if(d.images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
}
//-->
</script>
</head>
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
  <table width="750" height="659" border="0" cellpadding="0" cellspacing="0">
    <tr bordercolor="#333333">
      <td width="6" valign="top" bordercolor="#333333" background="images/fondos%20iimg/LINEA-vert.jpg" class="style5 style14"><p>&nbsp;</p>
          <p>&nbsp;</p>
          <p>&nbsp;</p>
          <p>&nbsp;</p></td>
      <td width="730" valign="top" bordercolor="#333333" class="style5 style14"><div align="center">
        <form id="form1" runat="server"><div></div>
  <br />
  <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; height: 100%">
    <tr>
      <td style="height: 0px; width: 730px;"><div align="center"><span class="style1"> Buscar Propiedades</span></div></td>
    </tr>
    <tr >
      <td style="height: 0%; text-align: center; width: 750px;" > &nbsp;
          <table>
            <tr>
              <td align="center" style="height: 100%"> <uc1:ctrlBuscadorPropiedades id="CtrlBuscadorPropiedades1" runat="server"> </uc1:ctrlBuscadorPropiedades> </td>
            </tr>
            <tr>
              <td align="center">
                <p>&nbsp;</p>
                <asp:ImageButton ID="ibBuscar" runat="server" OnClick="ibBuscar_Click" ImageUrl="~/imagenes/boton_buscar.jpg" /></td>
            </tr>
            <tr>
              <td style="width: 100px">
                  <uc2:ListadoPropiedades ID="ListadoPropiedades1" runat="server" />
              </td>
            </tr>
          </table>
       <br />
          <br />
&nbsp; </td>
    </tr>
  </table>
</form>
        <p><span class="style12">4796-5127<br />
            </span><span class="style15"></span><span class="style16"><a href="mailto:info@pime.com.ar">info@pime.com.ar</a></span><span class="style15"></span></p>
      </div></td>
      <td width="5" valign="top" background="images/fondos%20iimg/LINEA-vert1.jpg" class="style5 style14">&nbsp;</td>
    </tr>
  </table>
  <p>&nbsp;</p>
</div>
<p align="center">&nbsp;</p>
</body>
</html>
