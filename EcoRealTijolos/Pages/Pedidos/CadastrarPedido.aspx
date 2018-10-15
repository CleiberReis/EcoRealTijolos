<%@ Page Title="" Language="C#" MasterPageFile="~/Content/Master/Home.Master" AutoEventWireup="true" CodeBehind="CadastrarPedido.aspx.cs" Inherits="EcoRealTijolos.Pages.Pedidos.CadastrarPedido" %>

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
        <h1 style="text-align: center">CADASTRO DE PEDIDOS</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>CLIENTE:</label>
                            <asp:DropDownList ID="ddlCliente" runat="server" Height="21px" Width="131px" CssClass="form-control">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group" style="text-align: center">
                            <label style="font-weight:bold">DADOS DA ENTREGA</label>
                        </div>
                        <div class="form-group">
                            <label>ENDEREÇO COMPLETO:</label>
                            <asp:TextBox ID="txtEndereco" Width="562px" Height="24px" runat="server" Text="" CssClass="form-control col-md-6"></asp:TextBox>
                            <label>Ex: Rua xxxx, 00, Bairro xxx - Cidade (UF)</label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>DATA DA ENTREGA:</label>
                            <asp:TextBox ID="txtData" runat="server" Width="114px" Height="21px" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>OBSERVAÇÃO DO PEDIDO:</label>
                            <asp:TextBox ID="txtObsPedido" runat="server" Width="406px" Height="21px" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <table>
                                <tr>
                                    <td>
                                        <asp:Button ID="BtnSalvar" runat="server" CssClass="btn btn-primary" Width="200px" OnClick="BtnSalvar_Click" Text="Salvar" />
                                    </td>
                                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                    <td>
                                        <asp:HyperLink ID="hlListarProdutos" runat="server" CssClass="btn btn-dark" Width="200px" NavigateUrl="~/Pages/Pedidos/ListarPedido.aspx">Seleção de Produtos</asp:HyperLink>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div align="center">
            <div class="form-group">
                <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Blue"></asp:Label>
            </div>
        </div>
    </section>
</asp:Content>
