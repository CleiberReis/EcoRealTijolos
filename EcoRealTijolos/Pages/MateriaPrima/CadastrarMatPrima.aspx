<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarMatPrima.aspx.cs" Inherits="EcoRealTijolos.Pages.MateriaPrima.CadastrarMatPrima" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
            <asp:Button ID="btnSalvar" runat="server" BackColor="#000099" BorderStyle="Solid" Font-Bold="True" ForeColor="White" OnClick="btnSalvar_Click" Text="Salvar" />
        </p>
        <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Blue"></asp:Label>
    </form>
</body>
</html>
