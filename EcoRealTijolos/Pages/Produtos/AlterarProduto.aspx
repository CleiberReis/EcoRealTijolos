<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlterarProduto.aspx.cs" Inherits="EcoRealTijolos.Pages.Produtos.AlterarProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            ALTERAÇÃO DE PRODUTOS<br />
            <br />
            <br />
            <asp:Label ID="lblNome" runat="server" Text="Nome do Produto:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblValor" runat="server" Text="Valor Unitário do Produto:"></asp:Label>
            <br />
&nbsp;<asp:TextBox ID="txtNome" runat="server" Width="169px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblQuantidade" runat="server" Text="Quantidade em Estoque:"></asp:Label>
            <br />
            <asp:TextBox ID="txtQuantidade" runat="server" Width="170px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="BtnAlterar" runat="server" Text="Alterar Produto" OnClick="BtnAlterar_Click" />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
