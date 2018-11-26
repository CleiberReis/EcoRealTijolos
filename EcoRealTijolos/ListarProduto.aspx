<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ListarProduto.aspx.cs" Inherits="EcoRealTijolos.ListarProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <!-- Datatable Part -->
    <section class="content-header">
        <h1 style="text-align: center">LISTA DE PRODUTOS</h1>
    </section>
    <div class="row">
        <div class="col-md-12">
            <div class="box box-primary">
                <div class="box-body table-responsive">
                    <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" CssClass="table table-bordered table-hover" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="prod_nome" HeaderText="Nome do Produto" />
                            <asp:BoundField DataField="prod_valorUnitario" HeaderText="Valor Unitário" />
                            <asp:BoundField DataField="prod_quantTotal" HeaderText="Quantidade Total" />
                            <asp:BoundField DataField="prod_estoqueMinimo" HeaderText="Quantidade Total" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbAlterar" runat="server" CssClass="btn btn-dark" CommandName="Alterar" CommandArgument='<%# Bind("prod_id")%>'><i class="fa fa-check-square-o" aria-hidden="true"></i></asp:LinkButton>&nbsp;<asp:LinkButton ID="lbExcluir" runat="server" CssClass="btn btn-danger" CommandName="Excluir"
                                        CommandArgument='<%# Bind("prod_id")%>'><i class="fa fa-minus-square-o"></i></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
           
        </div>
    </div>
    <div>
        <div align="center">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="BtnNovo" runat="server" CssClass="btn btn-primary" Width="200px" Text="Novo Produto" OnClick="BtnNovo_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
