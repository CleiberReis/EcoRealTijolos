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
                            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                <ItemTemplate>
                                    <div>
                                        <p>
                                            Código do Produto:
                                            <asp:Label ID="lblProdId" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "prod_id")%>'></asp:Label>
                                        </p>
                                        <p>
                                            Quantidade do Produto:
                                            <asp:Label ID="lblQuant" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "pedpro_quantidade")%>'></asp:Label>
                                            ------------------------------------------------------------------------ R$
                                            <asp:Label ID="lblSubtotal" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "pedpro_subtotal")%>'></asp:Label>
                                        </p>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                            <div align="center">
                                <asp:Label ID="lblTotal" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Red"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <br />

        </div>
    </section>
</asp:Content>
