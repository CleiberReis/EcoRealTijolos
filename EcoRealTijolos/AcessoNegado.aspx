<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcessoNegado.aspx.cs" Inherits="EcoRealTijolos.AcessoNegado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ACESSO NEGADO PARÇA"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Voltar para tela de Login</asp:HyperLink>
        </p>
    </form>
</body>
</html>
