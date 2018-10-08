<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarMatPrima.aspx.cs" Inherits="EcoRealTijolos.Pages.MateriasPrimas.CadastrarMatPrima" Title="" MasterPageFile="~/Content/Master/Home.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <!-- IonIcons -->
    <link href="../../Content/css/ionicons.min.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/css/AdminLTE.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/jAlert/jquery.alerts.css" rel="stylesheet" />
    <!-- DataTables -->
    <link href="../css/datatables/dataTables.bootstrap.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
    <script src="../Scripts/bootstrap.min.js" type="text/javascript"></script>
    <script src="../../Scripts/js/jquery-ui.min.js" type="text/javascript"></script>
    <script src="../../Scripts/js/AdminLTE/app.js" type="text/javascript"></script>
    <script src="../jAlert/jquery.alerts.js" type="text/javascript"></script>
    <script src="../../Scripts/js/jquery.ui.draggable.js" type="text/javascript"></script>
    <script src="../../Scripts/js/plugins/datatables/jquery.dataTables.js"></script>
    <script src="../../Scripts/js/plugins/datatables/dataTables.bootstrap.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="Server">
    <div>
    </div>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" Text="Cadastro de Matéria Prima"></asp:Label>
    <p>
        <asp:Label ID="txtNomeMateria" runat="server" Font-Names="Arial" Text="Nome: "></asp:Label>
        <asp:TextBox ID="nomeMateria" runat="server"></asp:TextBox>
    </p>
    <asp:Label ID="txtQuantiMateria" runat="server" Font-Names="Arial" Text="Quantidade: "></asp:Label>
    <asp:TextBox ID="QuantiMateria" runat="server"></asp:TextBox>
    <p>
        <asp:Button ID="BtnSalvar" runat="server" BackColor="#000099" BorderStyle="Solid" Font-Bold="True" ForeColor="White" OnClick="BtnSalvar_Click" Text="Salvar" />
    </p>
    <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Blue"></asp:Label>
</asp:Content>
