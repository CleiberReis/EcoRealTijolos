<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="CadastrarPedProduto.aspx.cs" Inherits="EcoRealTijolos.CadastrarPedProduto" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">CADASTRAR PEDIDO - ETAPA PRODUTO</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="box box-primary">
                <div class="box-body">
                    <div class="row">
                        <div class="col-md-5">
                            <div class="form-group">
                                <div id="container">
                                    <div>
                                        <asp:Label ID="lblAviso" runat="server"></asp:Label>
                                    </div>
                                    <asp:Label ID="lblTitulo" runat="server"></asp:Label>
                                    <label>Cliente: </label>
                                    <asp:DropDownList ID="ddlCliente" runat="server" Enabled="False" OnSelectedIndexChanged="ddlCliente_SelectedIndexChanged"></asp:DropDownList>
                                </div>
                                <asp:DropDownList ID="ddlPedido" runat="server" Enabled="False" Visible="False"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label>Selecione o Produto:</label>
                                <asp:DropDownList ID="ddlProduto" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlProduto_SelectedIndexChanged"></asp:DropDownList>
                                <div align="center">
                                    <button type="button" class="btn btn-block align-center" data-toggle="modal" data-target="#modalProduto">
                                        Consultar Estoque
                                    </button>
                                    <div class="modal fade" id="modalProduto" tabindex="-1" role="dialog" aria-labelledby="modalProdutoLabel" aria-hidden="true">
                                        <div class="modal-dialog" role="document">
                                            <div class="modal-content">
                                                <div class="modal-header">
                                                    <h3 class="modal-title" id="modalProdutoLabel" style="color: darkslategray;">Estoque de Produtos</h3>
                                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                        <span aria-hidden="true">&times;</span>
                                                    </button>
                                                </div>
                                                <div class="modal-body">
                                                    <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False">
                                                        <Columns>
                                                            <asp:BoundField DataField="prod_nome" HeaderText="Produto" />
                                                            <asp:BoundField DataField="prod_quantTotal" HeaderText="Estoque Total" />
                                                            <asp:BoundField DataField="prod_estoqueMinimo" HeaderText="Estoque Minimo" />
                                                        </Columns>
                                                    </asp:GridView>
                                                </div>
                                                <div class="modal-footer">
                                                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Voltar</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label>Valor Unitário: R$</label>
                                    <asp:TextBox ID="txtValorUnitario" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                </div>
                                <br />
                                <label>Quantidade:</label>
                                <asp:TextBox ID="txtQuantidade" runat="server" CssClass="form-control"></asp:TextBox>
                                <br />
                                <div class="form-group">
                                    <div align="center">
                                        <asp:Button ID="btnCalcular" runat="server" CssClass="btn btn-facebook" OnClick="btnCalcular_Click" Text="Calcular Subtotal" />
                                    </div>
                                    <label>Subtotal: R$</label>
                                    <asp:TextBox ID="txtSubtotal" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                </div>
                                <div class="box-body">
                                    <div align="center">
                                        <div class="form-group">
                                            <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Blue"></asp:Label>
                                        </div>
                                        <asp:Button ID="btnIncluir" runat="server" CssClass="btn btn-primary" Text="Incluir no Pedido" OnClick="btnIncluir_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-7">
                            <div class="box box-primary">
                                <div class="box-body table-responsive">
                                    <h3>Produtos do Pedido</h3>
                                    <asp:GridView ID="GridView2" runat="server" OnRowCommand="GridView2_RowCommand" CssClass="table table-bordered table-hover" AutoGenerateColumns="False">
                                        <Columns>
                                            <%--<asp:BoundField DataField="ped_id" HeaderText="Pedido" />--%>
                                            <asp:BoundField DataField="prod_nome" HeaderText="Produto" />
                                            <asp:BoundField DataField="pedpro_quantidade" HeaderText="Quantidade de Produto" />
                                            <asp:BoundField DataField="pedpro_subtotal" HeaderText="SubTotal" />
                                            <%--<ItemTemplate>
                                            <asp:LinkButton ID="lbAlterar" runat="server" CssClass="btn btn-dark" CommandName="Alterar" CommandArgument='<%#Bind("pedpro_id")%>'><i class="fa fa-check-square-o" aria-hidden="true"></i></asp:LinkButton>&nbsp;<asp:LinkButton ID="lbExcluir" runat="server" CssClass="btn btn-danger" CommandName="Excluir"
                                                CommandArgument='<%#Bind("pedpro_id")%>'><i class="fa fa-minus-square-o"></i></asp:LinkButton>
                                        </ItemTemplate>--%>
                                        </Columns>
                                    </asp:GridView>
                                    <br />
                                </div>

                            </div>
                            <div align="center">
                                <button type="button" class="btn btn-danger align-center" data-toggle="modal" data-target="#modalAlerta">
                                    Finalizar Pedido</button>
                                <div class="modal fade" id="modalAlerta" tabindex="-1" role="dialog" aria-labelledby="modalAlertaLabel" aria-hidden="true">
                                    <div class="modal-dialog" role="document">
                                        <div class="modal-content">
                                            <div class="modal-header">
                                                <h3 class="modal-title" id="modalAlertaLabel" style="color: crimson;">ATENÇÃO!!!</h3>
                                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                    <span aria-hidden="true">&times;</span>
                                                </button>
                                            </div>
                                            <div class="modal-body">
                                                <p>Deseja realmente encerrar o pedido?</p>
                                                <p>Encerrando não será possível incluir novos produtos!</p>
                                            </div>
                                            <div class="modal-footer">
                                                <button type="button" class="btn btn-secondary" data-dismiss="modal">Voltar</button>
                                                <asp:Button ID="btnFinalizar" runat="server" CssClass="btn btn-danger" Text="Finalizar Mesmo Assim" OnClick="btnFinalizar_Click" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
