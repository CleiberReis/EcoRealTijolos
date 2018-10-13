<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Content/Master/Home.Master" CodeBehind="CadastrarPedProduto.aspx.cs" Inherits="EcoRealTijolos.Pages.Pedidos.CadastrarPedProduto" %>

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
    <title></title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">

    <section class="content-header">
        <h1 style="text-align: center">CADASTRAR PEDIDO - ETAPA PRODUTO</h1>
    </section>
    <br />
    &nbsp;<asp:Label ID="lblPedido" runat="server" OnDataBinding="Page_Load" Visible="False"></asp:Label>
    <br />
    <asp:DropDownList ID="ddlPedido" runat="server" Enabled="False">
    </asp:DropDownList>
    <br />
    <asp:Label ID="lblProduto" runat="server" Text="Produto:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblQuantidade" runat="server" Text="Quantidade:"></asp:Label>
    <br />
    <asp:DropDownList ID="ddlProduto" runat="server">
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQuantidade" runat="server" Width="75px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblSubTotal" runat="server" Text="SubTotal R$:"></asp:Label>
    <br />
    <asp:TextBox ID="txtSubtotal" runat="server" Width="106px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar Pedido" OnClick="btnFinalizar_Click" />
    <br />
    <asp:Label ID="lblMensagem" runat="server"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    </div>
</asp:Content>
