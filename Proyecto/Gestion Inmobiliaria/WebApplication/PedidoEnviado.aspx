<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PedidoEnviado.aspx.cs" Inherits="WebApplication.PedidoEnviado" %>

<%@ Register Src="Controles/ListadoPropiedades.ascx" TagName="ListadoPropiedades"
    TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Pedido Enviado!</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        El Pedido se ha enviado correctamente!<br />
        Recibirá notificaciones de las propiedades que se ajustan por e-mail.<br />
        Las siguientes propiedades se ajustan  al pedido que realizo.<br />
        <br />
        &nbsp;<uc1:ListadoPropiedades ID="ListadoPropiedades1" runat="server" />
        </div>
    </form>
</body>
</html>
