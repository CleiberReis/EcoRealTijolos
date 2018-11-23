<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Orcamento.aspx.cs" Inherits="EcoRealTijolos.Orcamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">ORÇAMENTO FINAL</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <asp:Label ID="lblPedido" runat="server" OnDataBinding="Page_Load" Visible="true"></asp:Label>
                            <asp:DropDownList ID="ddlPedido" runat="server" Enabled="False" AutoPostBack="True" OnSelectedIndexChanged="ddlPedido_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div align="center">
                            <asp:Button ID="btnOrcamento" runat="server" CssClass="btn btn-primary" Text="Gerar Orçamento" OnClick="btnOrcamento_Click" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-12">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField DataField="ped_id" HeaderText="Código do Pedido" />
                                    <asp:BoundField DataField="prod_id" HeaderText="Código do Produto" />
                                    <asp:BoundField DataField="pedpro_quantidade" HeaderText="Quantidade de Produto" />
                                    <asp:BoundField DataField="pedpro_subtotal" HeaderText="SubTotal" />
                                </Columns>
                            </asp:GridView>
                            <div align="center">
                                <asp:Label ID="lblTotal" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Red"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
