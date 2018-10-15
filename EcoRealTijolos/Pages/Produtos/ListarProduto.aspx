<%@ Page Language="C#" MasterPageFile="~/Content/Master/Home.Master" AutoEventWireup="true" CodeBehind="ListarProduto.aspx.cs" Inherits="EcoRealTijolos.Pages.Produtos.ListarProduto" %>

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
    <!-- Datatable Part -->
    <section class="content-header">
        <h1 style="text-align: center">LISTA DE PRODUTOS</h1>
    </section>
    <div class="row">
        <div class="col-md-12">
            <div class="box box-primary">
                <div class="box-body table-responsive">
                    <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="prod_id" HeaderText="ID do Produto" />
                            <asp:BoundField DataField="prod_nome" HeaderText="Nome do Produto" />
                            <asp:BoundField DataField="prod_valorUnitario" HeaderText="Valor Unitário" />
                            <asp:BoundField DataField="prod_quantTotal" HeaderText="Quantidade Total" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar"
                                        CommandArgument='<%# Bind("prod_id")%>'>Alterar</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbExcluir" runat="server" CommandName="Excluir"
                                        CommandArgument='<%# Bind("prod_id")%>'>Excluir</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>

                </div>
            </div>
            <asp:Button ID="Button1" runat="server" OnClick="BtnNovo_Click" Text="Button" />
        </div>
    </div>

    <div>
        <div align="center">
            <table>
                <tr>
                    <td>
                        <!-- Retirado o código do botão daqui! -->
                    </td>
                </tr>
            </table>
        </div>
    </div>

    <br />
    <br />

    <br />
    <asp:HyperLink ID="hlHome" runat="server" NavigateUrl="../Index.aspx">Home</asp:HyperLink>
    <br />
    <asp:HyperLink ID="hlCadastrar" runat="server" NavigateUrl="~/Pages/Produtos/CadastrarProduto.aspx">Cadastrar um Novo Produto</asp:HyperLink>
    <br />


    <!-- Scripts -->
    <script src="../../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../../Scripts/jquery.validate.min.js"></script>
    <script src="../../Scripts/popper.min.js"></script>
    <script src="../../Scripts/bootstrap.bundle.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
