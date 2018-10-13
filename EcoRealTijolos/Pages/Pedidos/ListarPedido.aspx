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
            <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="ped_id" HeaderText="ID do Pedido" />
                    <asp:BoundField DataField="ped_idCliente" HeaderText="ID do Cliente" />
                    <asp:BoundField DataField="prod_id" HeaderText="ID do Produto" />
                    <asp:BoundField DataField="ped_endereco" HeaderText="Endereço de Entrega" />
                    <asp:BoundField DataField="ped_data" HeaderText="Data de Entrega" />
                    <asp:BoundField DataField="ped_obs" HeaderText="Observações do Pedido" />
                    <asp:BoundField DataField="pedpro_quantidade" HeaderText="Quant.Produto" />
                    <asp:BoundField DataField="pedpro_subtotal" HeaderText="Subtotal Pedido" />
                    <asp:TemplateField HeaderText="Alteração">
                        <ItemTemplate>
                            <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar"
                                CommandArgument='<%#Bind("ped_id")%>'>Alterar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Exclusão">
                        <ItemTemplate>
                            <asp:LinkButton ID="lbExcluir" runat="server" CommandName="Excluir"
                                CommandArgument='<%#Bind("ped_id")%>'>Excluir</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" ForeColor="Black" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
