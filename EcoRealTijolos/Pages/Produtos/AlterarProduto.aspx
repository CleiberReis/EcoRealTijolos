<%@ Page Language="C#" MasterPageFile="~/Content/Master/Home.Master" AutoEventWireup="true" CodeBehind="AlterarProduto.aspx.cs" Inherits="EcoRealTijolos.Pages.Produtos.AlterarProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <!-- IonIcons -->
    <link href="../../Content/css/ionicons.min.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/css/AdminLTE.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/jAlert/jquery.alerts.css" rel="stylesheet" type="text/css" />
    <!-- DataTables -->
    <link href="../../Content/css/datatables/dataTables.bootstrap.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.min.js" type="text/javascript"></script>
    <script src="../../Scripts/js/jquery-ui.min.js" type="text/javascript"></script>
    <script src="../../Scripts/js/AdminLTE/app.js" type="text/javascript"></script>
    <script src="../../Content/jAlert/jquery.alerts.js" type="text/javascript"></script>
    <script src="../../Scripts/js/jquery.ui.draggable.js" type="text/javascript"></script>
    <script src="../../Scripts/js/plugins/datatables/jquery.dataTables.js"></script>
    <script src="../../Scripts/js/plugins/datatables/dataTables.bootstrap.js"></script>
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
                            <label>NOME DO PRODUTO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtNome" runat="server" Width="169px"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </div>

                        <div class="form-group">
                            <label>VALOR DO PRODUTO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>QUANTIDADE EM ESTOQUE:</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtQuantidade" runat="server" Width="170px"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div align="center">
            <div class="form-group">
                <asp:Label ID="lblMensagem" runat="server"></asp:Label>
            </div>
            <br />

            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnAlterar" runat="server" Text="Alterar Produto" OnClick="btnAlterar_Click" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlListar" runat="server" NavigateUrl="~/Pages/Produtos/ListarProduto.aspx">Lista de Produtos</asp:HyperLink>
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


