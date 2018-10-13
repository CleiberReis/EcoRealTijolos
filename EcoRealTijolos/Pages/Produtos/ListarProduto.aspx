<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarProduto.aspx.cs" Inherits="EcoRealTijolos.Pages.Produtos.ListarProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            LISTA DE PRODUTOS<br />
            <br />
            
            <asp:HyperLink ID="hlHome" runat="server" NavigateUrl="../Index.aspx">Home</asp:HyperLink>
            <br /><br />
            <asp:HyperLink ID="hlCadastrar" runat="server" NavigateUrl="~/Pages/Produtos/CadastrarProduto.aspx">Cadastrar um Novo Produto</asp:HyperLink>
            <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="prod_id" HeaderText="ID do Produto" />
                    <asp:BoundField DataField="prod_nome" HeaderText="Nome do Produto" />
                    <asp:BoundField DataField="prod_valorUnitario" HeaderText="Valor Unitário" />
                    <asp:BoundField DataField="prod_quantTotal" HeaderText="Quantidade Total" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar"
                                CommandArgument='<%# Bind("prod_id")%>'>Alterar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lbExcluir" runat="server" CommandName="Excluir"
                                CommandArgument='<%# Bind("prod_id")%>'>Excluir</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            
            <br /><br />
            <asp:HyperLink ID="hlProduto" runat="server" NavigateUrl="~/Pages/Pedidos/CadastrarPedProduto.aspx">Voltar para o pedido em andamento</asp:HyperLink>
        </div>
    </form>
</body>
</html>
