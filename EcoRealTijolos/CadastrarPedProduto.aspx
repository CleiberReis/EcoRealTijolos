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
                            <asp:DropDownList ID="ddlProduto" runat="server" CssClass="form-control-sm"></asp:DropDownList>
                            <br /><br />
                            <label>Quantidade:</label>
                            <asp:TextBox ID="txtQuantidade" runat="server" CssClass="form-control-sm" Width="75px"></asp:TextBox>
                        </div>
                    </div>
                    <div class="box-body">
                        <div class="form-group">
                            <label>Valor Unitário: R$</label>
                            <asp:TextBox ID="txtValorUnitario" runat="server" CssClass="form-control-sm" Width="84px"></asp:TextBox>
                            
                        </div>
                        <div align="left">
                            <asp:Button ID="btnCalcular" runat="server" CssClass="btn btn-danger btn-sm" Width="200px" OnClick="btnCalcular_Click" Text="Calcular Subtotal" />
                        </div>
                        <br />
                        <div class="form-group">
                            <label>Subtotal: R$</label>
                            <asp:TextBox ID="txtSubtotal" runat="server" CssClass="form-control-sm" Width="106px" Enabled="False"></asp:TextBox>
                        </div>
                        <div align="left">
                            <div class="form-group">
                                <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Blue"></asp:Label>
                            </div>
                            <table>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnFinalizar" runat="server" CssClass="btn btn-primary btn-sm" Width="200px" Text="Finalizar Pedido" OnClick="btnFinalizar_Click" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body table-responsive">
                        <h6 class="text-bold">CONSULTA DE PRODUTOS</h6>
                        <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="prod_nome" HeaderText="Nome do Produto" />
                                <asp:BoundField DataField="prod_valorUnitario" HeaderText="Valor Unitário" />
                                <asp:BoundField DataField="prod_quantTotal" HeaderText="Quantidade Disponível" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
         <div class="col-md-12">
                <div class="box box-primary">
                    <div class="box-body table-responsive">
                    </div>
                </div>
            </div>
        </div>


    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
