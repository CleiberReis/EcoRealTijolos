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
    <div>
        <asp:Label ID="lblCliente" runat="server" Text="Cliente: "></asp:Label>
        <asp:DropDownList ID="ddlCliente" runat="server" Height="21px" Width="131px">
        </asp:DropDownList>
        <br />
        <br />
        DADOS DA ENTREGA:<br />

            <br />
            <asp:Label ID="lblEndereco" runat="server" Text="Endereço Completo:"></asp:Label>
            <br />
            <asp:TextBox ID="txtEndereco" runat="server" Width="562px" Height="24px"></asp:TextBox>
            
            <br />
            <asp:Label ID="lblObsEndereco" runat="server" Font-Size="Smaller" Text="Ex:  (Rua xxxx, 00, Bairro xxx - Cidade (UF))"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblDtPedido" runat="server" Text="Data de Entrega: "></asp:Label>
            <br />
            <asp:TextBox ID="txtData" runat="server" Width="114px" Height="21px"></asp:TextBox>
            <br />
            <br />
            
            <asp:Label ID="lblObsPedido" runat="server" Text="Observação do Pedido: "></asp:Label>
            <br />
            <asp:TextBox ID="txtObsPedido" runat="server" Width="406px" Height="21px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnSalvar" runat="server" OnClick="BtnSalvar_Click" Text="Salvar" />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
            <br />
            <br />
        </div>
        <asp:HyperLink ID="hlListarProdutos" runat="server" NavigateUrl="~/Pages/Pedidos/ListarPedido.aspx">Seleção de Produtos</asp:HyperLink>
</asp:Content>
