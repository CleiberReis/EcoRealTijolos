<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Content/Master/Home.Master" CodeBehind="CadastrarCliente.aspx.cs" Inherits="EcoRealTijolos.Pages.Clientes.CadastrarCliente" %>

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
    <div class="container-fluid">
        <asp:Label runat="server" Text="Cadastro de Clientes"></asp:Label>
        <br />
        <asp:Label runat="server" Text="Nome:"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="txtNome" Text=""></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="CPF:"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="txtCpf" Text=""></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Telefone:"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="txtTelefone" Text=""></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Email:"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="txtEmail" Text=""></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" ID="lblMensagem" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button runat="server" Text="Salvar" ID="BtnSalvar" OnClick="BtnSalvar_Click" />
        <br />
    </div>
    <div>
        <a href="ListarCliente.aspx">Listar Clientes</a>
    </div>
</asp:Content>

