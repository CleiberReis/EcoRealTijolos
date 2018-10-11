<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarPedido.aspx.cs" Inherits="EcoRealTijolos.Pages.Pedidos.ListarPedido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            LISTA DE PEDIDOS
            <br /><br />
            <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="ped_id" HeaderText="ID do Pedido" />
                    <asp:BoundField DataField="ped_idCliente" HeaderText="ID do Cliente" />
                    <asp:BoundField DataField="ped_idProduto" HeaderText="ID do Produto" />
                    <asp:BoundField DataField="ped_endereco" HeaderText="Endereço de Entrega" />
                    <asp:BoundField DataField="ped_data" HeaderText="Data de Entrega" />
                    <asp:BoundField DataField="ped_obs" HeaderText="Observações do Pedido" />
                    <asp:TemplateField HeaderText="Alteração">
                        <ItemTemplate>
                            <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar Pedido"
                                CommandArgument='<%#Bind("ped_id")%>'>Alterar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Exclusão">
                        <ItemTemplate>
                            <asp:LinkButton ID="lbExcluir" runat="server" CommandName="Excluir Pedido"
                                CommandArgument='<%#Bind("ped_id")%>'>Excluir</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
