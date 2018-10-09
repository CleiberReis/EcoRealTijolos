<%@ Page Title="" Language="C#" MasterPageFile="~/Content/Master/Home.Master" AutoEventWireup="true" CodeBehind="IndexMateriaPrima.aspx.cs" Inherits="EcoRealTijolos.Pages.MateriasPrimas.IndexMateriaPrima" %>
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
    <div align="center">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnCadastrar" runat="server" CssClass="btn btn-primary" Width="200px" Text="Cadastrar" OnClick="Page_Load" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnAlterar" runat="server" CssClass="btn btn-danger" Width="200px" Text="Alterar" OnClick="Page_Load" />
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>
