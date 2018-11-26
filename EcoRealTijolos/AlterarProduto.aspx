<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AlterarProduto.aspx.cs" Inherits="EcoRealTijolos.AlterarProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">ALTERAÇÃO DE PRODUTOS</h1>
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
                                <label>QUANTIDADE</label>
                                <asp:TextBox ID="txtQuantidade" runat="server" Width="170px" CssClass="form-control"></asp:TextBox>
                                 <label>Quant. Minima:</label>
                                <asp:TextBox ID="txtMinimo" runat="server" Width="170px" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div align="center">
            <div class="form-group">
                <asp:Label ID="lblMensagem" runat="server"  Font-Bold="True" Font-Names="Arial" ForeColor="Blue"></asp:Label>
            </div>
            <br />

            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnAlterar" runat="server" CssClass="btn btn-primary" Width="200px" Text="Alterar Produto" OnClick="btnAlterar_Click" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlListar" runat="server" CssClass="btn btn-danger" NavigateUrl="~/ListarProduto.aspx">Lista de Produtos</asp:HyperLink>
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>


