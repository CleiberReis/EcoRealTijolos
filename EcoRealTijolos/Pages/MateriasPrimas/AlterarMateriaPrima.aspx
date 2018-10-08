<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlterarMateriaPrima.aspx.cs" Inherits="EcoRealTijolos.Pages.MateriasPrimas.AlterarMateriaPrima" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Alteração de Matéria Prima</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" Text="Alteração de Matéria Prima"></asp:Label>
        <br />
        <asp:Label runat="server" Font-Names="Arial" Text="Nome: "></asp:Label>
        <br />
        <asp:TextBox ID="txtNomeMateria" runat="server"></asp:TextBox>
        <br />
        <asp:Label runat="server" Font-Names="Arial" Text="Quantidade: "></asp:Label>
        <br />
        <asp:TextBox ID="txtQuantidadeMateria" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Blue"></asp:Label>
        <br />
        <asp:Button ID="BtnSalvar" runat="server" OnClick="BtnSalvar_Click" Text="Salvar" />
        <br />
    </form>
    <a href="ListarMateriaPrima.aspx">Voltar</a>
</body>
</html>
