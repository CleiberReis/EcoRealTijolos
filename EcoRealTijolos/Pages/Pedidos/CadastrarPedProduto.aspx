<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarPedProduto.aspx.cs" Inherits="EcoRealTijolos.Pages.Pedidos.CadastrarPedProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CADASTRAR PEDIDO - ETAPA PRODUTO<br />
            <br />
            <asp:Label ID="lblProduto" runat="server" Text="Produto:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblQuantidade" runat="server" Text="Quantidade:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlProduto" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQuantidade" runat="server" Width="75px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblSubTotal" runat="server" Text="SubTotal R$:"></asp:Label>
            <br />
            <asp:Label ID="lblSubValor" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar Pedido" />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
