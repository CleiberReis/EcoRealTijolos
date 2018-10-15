<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Content/Master/Home.Master" CodeBehind="CadastrarProduto.aspx.cs" Inherits="EcoRealTijolos.Pages.Produtos.CadastrarProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <!-- IonIcons -->
    <link href="../../Content/css/ionicons.min.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/css/AdminLTE.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/jAlert/jquery.alerts.css" rel="stylesheet" type="text/css" />
    <!-- DataTables -->
    <script src="../../Scripts/bootstrap.min.js" type="text/javascript"></script>
    <script src="../../Scripts/js/jquery-ui.min.js" type="text/javascript"></script>
    <script src="../../Scripts/js/AdminLTE/app.js" type="text/javascript"></script>
    <script src="../../Content/jAlert/jquery.alerts.js" type="text/javascript"></script>
    <script src="../../Scripts/js/jquery.ui.draggable.js" type="text/javascript"></script>
    <script src="../../Scripts/js/plugins/datatables/jquery.dataTables.js"></script>
    <link href="../../Content/css/datatables/dataTables.bootstrap.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/js/plugins/datatables/dataTables.bootstrap.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">CADASTRO DE PRODUTOS</h1>
    </section>
    <section class="content ">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>NOME DO PRODUTO:</label>
                            <asp:TextBox ID="txtNome" runat="server" Width="169px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>VALOR UNITÁRIO:</label>
                            <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
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
                                <label>QUANTIDADE</label>
                                <asp:TextBox ID="txtQuantidade" runat="server" Width="170px"></asp:TextBox>
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
                            <asp:HyperLink ID="hlListar" runat="server" NavigateUrl="~/Pages/Produtos/ListarProduto.aspx">Lista de Produtos</asp:HyperLink>
                        </td>
                    </tr>
                </table>
            </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
