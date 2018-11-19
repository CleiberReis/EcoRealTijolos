<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="CadastrarPedProduto.aspx.cs" Inherits="EcoRealTijolos.CadastrarPedProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">CADASTRAR PEDIDO - ETAPA PRODUTO</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <h6 class="text-bold">SELECIONE OS PRODUTOS DO PEDIDO:</h6>
                            <asp:Label ID="lblPedido" runat="server" OnDataBinding="Page_Load" Visible="False"></asp:Label>
                            <asp:DropDownList ID="ddlPedido" runat="server" Enabled="False" AutoPostBack="True" OnSelectedIndexChanged="ddlPedido_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Produto:</label>
                            <asp:DropDownList ID="ddlProduto" runat="server" CssClass="form-control"></asp:DropDownList>
                            <br />
                            <div align="center">
                                <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal">
                                    Consultar Preço Unitário
                                </button>
                            </div>
                            <!-- Modal -->
                            <div class="modal fade" id="myModal" tabindex="1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                                <div class="modal-dialog modal-dialog-centered" role="document">
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <h4 class="modal-title" id="myModalLabel">Consulta de Preço Unitário</h4>
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Fechar">
                                                <span aria-hidden="true">&times;</span>
                                            </button>
                                        </div>
                                        <div class="modal-body">
                                            <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False">
                                                <Columns>
                                                    <asp:BoundField DataField="prod_nome" HeaderText="Nome do Produto" />
                                                    <asp:BoundField DataField="prod_valorUnitario" HeaderText="Valor Unitário" />
                                                    <asp:BoundField DataField="prod_quantTotal" HeaderText="Quantidade Disponível" />
                                                </Columns>
                                            </asp:GridView>
                                        </div>
                                        <div class="modal-footer">
                                            <button type="button" class="btn btn-default" data-dismiss="modal">Fechar</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="form-group">
                                <label>Valor Unitário: R$</label>
                                <asp:TextBox ID="txtValorUnitario" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Quantidade:</label>
                            <asp:TextBox ID="txtQuantidade" runat="server" CssClass="form-control"></asp:TextBox>
                            <br />
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
                                <div>
                                    <asp:Label ID="lblTotal" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Red"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="box box-primary">
                    <div class="box-body table-responsive">
                        <asp:GridView ID="GridView2" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="ped_id" HeaderText="Código do Pedido" />
                                <asp:BoundField DataField="prod_id" HeaderText="Código do Produto" />
                                <asp:BoundField DataField="pedpro_quantidade" HeaderText="Quantidade de Produto" />
                                <asp:BoundField DataField="pedpro_subtotal" HeaderText="SubTotal" />
                                <asp:BoundField DataField="pedpro_total" HeaderText="Valor Total do Pedido" />
                            </Columns>
                        </asp:GridView>
                        <br />

                    </div>
                </div>
            </div>
        </div>


    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
