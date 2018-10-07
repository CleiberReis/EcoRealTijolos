<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarPedido.aspx.cs" Inherits="EcoRealTijolos.Pages.CadastrarPedido" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title></title>
    
    <script src="../../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../../Scripts/bootstrap.bundle.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />

    <style type="text/css">
        body{
            margin:0px;
            padding:0px;
        }
    </style>
</head>
<body>
    <div class="jumbotron">
            <h1 class="text-center">Alteração de Pedidos</h1>
            <p class="text-center">
                <asp:HyperLink ID="hlAlterar" runat="server" NavigateUrl="~/Pages/Pedidos/AlterarPedido.aspx">Alteração de Pedido | </asp:HyperLink>
                <asp:HyperLink ID="hlCadastrar" runat="server" NavigateUrl="~/Pages/Pedidos/CadastrarPedido.aspx">Cadastro de Pedido</asp:HyperLink>
            </p>
        </div>
    <div class="container-fluid">
        <form id="form1" runat="server" class="form-group">
            <div class="row">
                <div class="col">
                    <%--Cliente--%>
                    <h3 class="text-center">Escolha do Cliente</h3>
                    <asp:Label ID="lblCliente" runat="server" Text="Cliente"></asp:Label>
                    <asp:DropDownList ID="ddlCliente" runat="server" CssClass="form-control" Width="415px">
                    </asp:DropDownList>
                </div>
                <br />
                <div class="col">
                    <%--Endereço--%>
                    <h3 class="text-center">Endereço para entrega</h3>
                    <asp:Label ID="lblCep" runat="server" Text="CEP"></asp:Label>
                    <asp:TextBox ID="txtCep" runat="server" CssClass="form-control" Width="415px"></asp:TextBox>

                    <asp:Label ID="lblRua" runat="server" Text="Rua"></asp:Label>
                    <asp:TextBox ID="txtRua" runat="server" CssClass="form-control" Width="415px"></asp:TextBox>


                    <asp:Label ID="lblNumero" runat="server" Text="Número"></asp:Label>
                    <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control" Width="50px"></asp:TextBox>

                    <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
                    <asp:DataList ID="dtlEstado" runat="server"></asp:DataList>

                    <asp:Label ID="lblCidade" runat="server" Text="Cidade"></asp:Label>
                    <asp:TextBox ID="txtCidade" runat="server" CssClass="form-control" Width="415px"></asp:TextBox>

                    <asp:Label ID="lblComplemento" runat="server" Text="Complemento"></asp:Label>
                    <asp:TextBox ID="txtComplemento" runat="server" CssClass="form-control" Width="415px"></asp:TextBox>
                </div>

                <br />

                <div class="col">
                    <%--Produtos--%>
                    <h3 class="text-center">Produtos</h3>
                    <asp:Label ID="lblTijolo" runat="server" Text="Tijolo"></asp:Label>
                    <asp:TextBox ID="txtTijolo" runat="server" CssClass="form-control" Width="50px"></asp:TextBox>

                    <asp:Label ID="lblPalha" runat="server" Text="Palha Trançada"></asp:Label>
                    <asp:TextBox ID="txtPalha" runat="server" CssClass="form-control" Width="50px"></asp:TextBox>

                    <asp:Label ID="lblPaver" runat="server" Text="Paver"></asp:Label>
                    <asp:TextBox ID="txtPaver" runat="server" CssClass="form-control" Width="50px"></asp:TextBox>

                </div>

                <br />
            </div>

          <br /><br />
            <div class="row">
                <div class="col">
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-block btn-success" />
                </div>
            </div>

            <div class="row">
                <div class="col alert alert-success">
                    <asp:Label ID="lblMensagem" runat="server" CssClass=""></asp:Label>
                </div>
            </div>
        </form>

    </div>

</body>
</html>
