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
            &nbsp;<asp:Label ID="lblPedido" runat="server" OnDataBinding="Page_Load" Visible="False"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlPedido" runat="server" Enabled="False">
            </asp:DropDownList>
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
            <asp:Label ID="lvlValorUnitario" runat="server" Text="Digite o valor do produto selecionado:"></asp:Label>
            <br />
            <asp:TextBox ID="txtValorUnitario" runat="server" Width="84px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular SubTotal" />
            <br />
            <br />
            <asp:Label ID="lblSubTotal" runat="server" Text="SubTotal R$:"></asp:Label>
            <br />
            <asp:TextBox ID="txtSubtotal" runat="server" Width="106px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar Pedido" OnClick="btnFinalizar_Click" />
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="hlProduto" runat="server" NavigateUrl="~/Pages/Produtos/ListarProduto.aspx">Consultar Produtos</asp:HyperLink>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
