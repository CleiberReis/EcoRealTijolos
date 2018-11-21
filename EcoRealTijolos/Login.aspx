<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EcoRealTijolos.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnLogar" runat="server" OnClick="btnLogar_Click" Text="Entrar" />
        </p>
        <p>
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
