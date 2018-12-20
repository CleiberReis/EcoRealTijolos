<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ListarPedido.aspx.cs" Inherits="EcoRealTijolos.ListarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <!-- Datatable Part -->
    <section class="content-header">
        <h1 style="text-align: center">LISTA DE PEDIDOS</h1>
    </section>
    <%--<div class="row">
        <div class="col-md-12">
            <div class="box box-primary">
                <div class="box-body table-responsive">
                    <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" GridLines="None" CssClass="table table-bordered table-hover" AutoGenerateColumns="False" Visible="True">
                        <Columns>
                            <asp:BoundField DataField="ped_id" HeaderText="ID do Pedido" />
                            <asp:BoundField DataField="cli_nome" HeaderText="Cliente" />
                            <asp:BoundField DataField="ped_idCliente" HeaderText="ID do Cliente" />
                            <asp:BoundField DataField="prod_id" HeaderText="ID do Produto" />
                            <asp:BoundField DataField="ped_logradouro" HeaderText="Logradouro" />
                            <asp:BoundField DataField="ped_numero" HeaderText="Nº" />
                            <asp:BoundField DataField="ped_bairro" HeaderText="Bairro" />
                            <asp:BoundField DataField="ped_cidade" HeaderText="Cidade" />
                            <asp:BoundField DataField="ped_estado" HeaderText="UF" />
                            <asp:BoundField DataField="ped_data" HeaderText="Data de Entrega" />
                            <asp:BoundField DataField="ped_obs" HeaderText="Observações do Pedido" />
                            <asp:BoundField DataField="pedpro_quantidade" HeaderText="Quant.Produto" />
                            <asp:BoundField DataField="pedpro_subtotal" HeaderText="Subtotal Pedido R$" />
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
    </div>--%>
    <div class="form-group">
        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
                <div>
                    <p>
                        <span style="font-weight: bold">Cliente:</span>
                        <asp:Label ID="lblCli" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "cli_nome")%>'></asp:Label>
                    </p>
                    <p>
                        <span style="font-weight: bold">Entrega:</span>
                        <asp:Label ID="lblLog" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ped_logradouro")%>'></asp:Label>,
                        <asp:Label ID="Label8" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ped_numero")%>'></asp:Label>
                        -
                        <asp:Label ID="lblSubtotal" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "ped_bairro")%>'></asp:Label>
                        <asp:Label ID="Label1" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "ped_cidade")%>'></asp:Label>
                        -
                        <asp:Label ID="Label2" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "ped_estado")%>'></asp:Label>
                    </p>
                    <p>
                        <span style="font-weight: bold">Data de Entrega:</span>
                        <asp:Label ID="Label3" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "ped_data")%>'></asp:Label>
                    </p>
                    <p>
                        <span style="font-weight: bold">Observação:</span>
                        <asp:Label ID="Label4" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "ped_obs")%>'></asp:Label>
                    </p>
                    <p>
                        <span style="font-weight: bold">Produto:</span>
                        <asp:Label ID="Label5" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "prod_nome")%>'></asp:Label>
                        <span style="font-weight: bold">Quantidade:</span>
                        <asp:Label ID="Label6" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "pedpro_quantidade")%>'></asp:Label>
                        <span style="font-weight: bold">SubTotal:</span> R$
                        <asp:Label ID="Label7" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "pedpro_subtotal")%>'></asp:Label>
                    </p>
                    <p>
                        <asp:LinkButton ID="btnExcluir" runat="server" Text="Excluir"
                            CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ped_id") %>'
                            CommandName="excluir" CausesValidation="false" CssClass="btn btn-danger"><i class="fa fa-check-square-o" aria-hidden="true"></i>
                        </asp:LinkButton>
                         <asp:LinkButton ID="btnAlterar" runat="server" Text="Alterar"
                            CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ped_id") %>'
                            CommandName="alterar" CausesValidation="false" CssClass="btn btn-facebook"><i class="fa fa-minus-square-o"></i>
                         </asp:LinkButton>
                        <br />
                    </p>
                </div>
                <p>---------------------------------------------------------------------------</p>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
