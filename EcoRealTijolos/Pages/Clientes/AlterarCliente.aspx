<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlterarCliente.aspx.cs" Inherits="EcoRealTijolos.Pages.Clientes.AlterarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Alterar Cadastro de Clientes</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <asp:Label runat="server" Text="Alteração de Cliente"></asp:Label>
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
    </form>
    <div>
        <a href="ListarCliente.aspx">Listar Clientes</a>
    </div>
</body>
</html>
