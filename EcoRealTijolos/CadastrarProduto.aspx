<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Home.Master" CodeBehind="CadastrarProduto.aspx.cs" Inherits="EcoRealTijolos.CadastrarProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">CADASTRO DE PRODUTOS</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>NOME DO PRODUTO:</label>
                            <asp:TextBox ID="txtNome" runat="server" Width="169px" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>VALOR UNITÁRIO:</label>
                            <asp:TextBox ID="txtValor" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <asp:Label ID="lblQuantidade" runat="server" Text="QUANTIDADE EM ESTOQUE:"></asp:Label>
                            <div class="form-group">
                                <br />
                                <label>QUANTIDADE EM ESTOQUE:</label>
                                <asp:TextBox ID="txtQuantidade" runat="server" Width="170px" CssClass="form-control"></asp:TextBox>
                                 <label>QUANTIDADE DE ESTOQUE MINIMO:</label>
                                <asp:TextBox ID="txtMinimo" runat="server" Width="170px" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div align="center">
            <div class="form-group">
                <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Blue"></asp:Label>
            </div>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnSalvar" runat="server" CssClass="btn btn-primary" Width="200px" Text="Salvar Produto" OnClick="btnSalvar_Click" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlListar" runat="server" CssClass="btn btn-danger" NavigateUrl="~/ListarProduto.aspx">Lista de Produtos</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
