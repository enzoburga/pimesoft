<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListadoPropiedades.ascx.cs" Inherits="WebApplication.Controles.ListadoPropiedades" %>
<asp:Label ID="lMensaje" runat="server"></asp:Label><br />
<br />
<asp:DataList id="DataList1" runat="server" Font-Underline="False" Font-Strikeout="False" Font-Overline="False" Font-Italic="False" Font-Bold="False" ForeColor="#333333" CellPadding="4">
<FooterStyle BackColor="Red" ForeColor="White" HorizontalAlign="Right" Font-Bold="True"></FooterStyle>

<SelectedItemStyle BackColor="#CCCCCC" ForeColor="#333333" Font-Bold="True"></SelectedItemStyle>
<ItemTemplate>
                    <table cellpadding="10" style="font: 10pt verdana" width="730">
                      <tr>
                        <td valign="top" style="width: 220px; height: 220px; text-align: center"> 
                            <%# DataBinder.Eval(Container.DataItem, "Reservado") %>
                            <img alt="Foto Fachada" align="top" src='<%# DataBinder.Eval(Container.DataItem, "Thumbnail")%>' /> <br  />
                            <a href='<%# DataBinder.Eval(Container.DataItem, "Link") %>'>Ver Ficha</a> </td>
                        <td valign="top" align="left"> <b>Detalles</b><br  />
                            <br  />
                            <%# DataBinder.Eval(Container.DataItem, "Detalles") %><br  />
                            <br  />
                            <b>C&oacute;digo: </b><%# DataBinder.Eval(Container.DataItem, "Codigo") %><br  />
                            <br  />
                            <b>Ubicaci&oacute;n: </b><%# DataBinder.Eval(Container.DataItem, "Ubicacion") %><br  />
                            <br  />
                            <b>Calle: </b><%# DataBinder.Eval(Container.DataItem, "Direccion") %><br  />
                            <br  />
                            <b>Valor: </b><%# DataBinder.Eval(Container.DataItem, "Valor") %><br  />
                        </td>
                      </tr>
                    </table>
                  
</ItemTemplate>

<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>

<ItemStyle BackColor="#EEEEEE"></ItemStyle>

<SeparatorStyle ForeColor="Blue" Font-Italic="False" Font-Strikeout="False" Font-Underline="False" Font-Overline="False" Font-Bold="False"></SeparatorStyle>
<HeaderTemplate>
<div style="font: 10pt verdana"> <%= GetPaginacion() %> </div>
</HeaderTemplate>

<HeaderStyle BackColor="Red" ForeColor="White" HorizontalAlign="Right" Font-Bold="True"></HeaderStyle>
<FooterTemplate>
 <div style="font: 10pt verdana"> <%= GetPaginacion() %> </div>
</FooterTemplate>
</asp:DataList>