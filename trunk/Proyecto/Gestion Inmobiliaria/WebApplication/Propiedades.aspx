<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Propiedades.aspx.cs" Inherits="WebApplication.Propiedades" %>

<%@ Register Src="Controles/ctrlBuscadorPropiedades.ascx" TagName="ctrlBuscadorPropiedades"
    TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;</div>
        <br />
        <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; height: 100%">
            <tr>
                <td style="height: 50px">
                    HEADER</td>
            </tr>
            <tr>
                <td>
        <uc1:ctrlBuscadorPropiedades id="CtrlBuscadorPropiedades1" runat="server">
        </uc1:ctrlBuscadorPropiedades>
                    &nbsp;<br />
                    <br />
                    &nbsp;
                    <asp:DataList ID="DataList1" runat="server" CellPadding="4"
                        ForeColor="#333333">
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <AlternatingItemStyle BackColor="White" />
                        <ItemStyle BackColor="#EFF3FB" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <ItemTemplate>
                             Product name:
                          <asp:Label ID="ProductNameLabel" 
                            runat="server" 
                            Text='<%# Eval("ProductName") %>' >
                          </asp:Label><br />

                        </ItemTemplate>
                    </asp:DataList><asp:ObjectDataSource ID="Propiedad" runat="server" SelectMethod="ToArray"
                        TypeName="GI.BR.Propiedades.Propiedades"></asp:ObjectDataSource>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
