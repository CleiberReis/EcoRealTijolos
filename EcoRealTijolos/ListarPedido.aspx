<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ListarPedido.aspx.cs" Inherits="EcoRealTijolos.ListarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <!-- Datatable Part -->
    <section class="content-header">
        <h1 style="text-align: center">LISTA DE PEDIDOS</h1>
    </section>
    <div class="row">
        <div class="col-md-12">
            <div class="box box-primary">
                <div class="box-body table-responsive">
                    <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" GridLines="None" CssClass="table table-bordered table-hover col-md-12" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="ped_id" HeaderText="ID do Pedido" />
                            <asp:BoundField DataField="ped_idCliente" HeaderText="ID do Cliente" />
                            <asp:BoundField DataField="prod_id" HeaderText="ID do Produto" />
                            <asp:BoundField DataField="ped_endereco" HeaderText="Endereço de Entrega" />
                            <asp:BoundField DataField="ped_data" HeaderText="Data de Entrega" />
                            <asp:BoundField DataField="ped_obs" HeaderText="Observações do Pedido" />
                            <asp:BoundField DataField="pedpro_quantidade" HeaderText="Quant.Produto" />
                            <asp:BoundField DataField="pedpro_subtotal" HeaderText="Subtotal Pedido" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbAlterar" runat="server" CssClass="btn btn-dark" CommandName="Alterar" CommandArgument='<%#Bind("ped_id")%>'><i class="fa fa-check-square-o" aria-hidden="true"></i></asp:LinkButton>&nbsp;<asp:LinkButton ID="lbExcluir" runat="server" CssClass="btn btn-danger" CommandName="Excluir"
                                        CommandArgument='<%#Bind("ped_id")%>'><i class="fa fa-minus-square-o"></i></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
