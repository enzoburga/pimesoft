<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Propiedades.aspx.cs" Inherits="WebApplication.Propiedades" %>

<%@ Register Src="Controles/ctrlBuscadorPropiedades.ascx" TagName="ctrlBuscadorPropiedades"
    TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Buscador de propiedades</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;</div>
        <br />
        <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; height: 100%">
            <tr>
                <td style="height: 50px; width: 1039px;">
                    Buscar Propiedades</td>
            </tr>
            <tr >
                <td style="height: 100%; text-align: center; width: 1039px;" >
                    &nbsp;<table>
                        <tr>
                            <td align="center" style="height: 100%">
        <uc1:ctrlBuscadorPropiedades id="CtrlBuscadorPropiedades1" runat="server">
        </uc1:ctrlBuscadorPropiedades>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <asp:ImageButton ID="ibBuscar" runat="server" OnClick="ibBuscar_Click" ImageUrl="~/imagenes/boton_buscar.jpg" /></td>
                        </tr>
                        <tr>
                            <td align="left" style="width: 100px; height: 21px">
                    <asp:Label ID="lMensaje" runat="server" Width="813px" Font-Names="Arial" Font-Size="Small"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 100px">
                    <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" HorizontalAlign="Right" />
                        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <AlternatingItemStyle BackColor="White" />
                        <ItemStyle BackColor="#EFF3FB" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" HorizontalAlign="Right" />
                        <HeaderTemplate>
                            <%= GetPaginacion() %>
                        </HeaderTemplate>                        
                        <ItemTemplate>

                            <table cellpadding="10" style="font: 10pt verdana" width="800">
                              <tr>

                                <td valign="top" style="width: 220px; height: 220px; text-align: center">                              
                                
                                  <img alt="Foto Fachada" align="top" src='<%# DataBinder.Eval(Container.DataItem, "Thumbnail")%>'/>  <br />
                                    <a href='<%# DataBinder.Eval(Container.DataItem, "Link") %>'>Ver Ficha</a>
                                </td>

                                <td valign="top" align="left">
                                  <b>Detalles</b><br><br><%# DataBinder.Eval(Container.DataItem, "Detalles") %><br><br> 
                                  <b>Código: </b><%# DataBinder.Eval(Container.DataItem, "Codigo") %><br><br>
                                  <b>Ubicación: </b><%# DataBinder.Eval(Container.DataItem, "Ubicacion") %><br><br>
                                  <b>Calle: </b><%# DataBinder.Eval(Container.DataItem, "Direccion") %><br><br>  
                                  <b>Valor: </b><%# DataBinder.Eval(Container.DataItem, "Valor") %><br>
                                  
                                </td>
                              </tr>
                            </table>

                        </ItemTemplate>
                        <FooterTemplate>
                            <%= GetPaginacion() %>	                              
                        </FooterTemplate>
                        <SeparatorStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" ForeColor="Blue" />
                    </asp:DataList></td>
                        </tr>
                    </table>
                    &nbsp;
                    &nbsp;&nbsp;&nbsp;<br />
                    <br />
                    &nbsp;
                    </td>
            </tr>
        </table>
    </form>
</body>
</html>
