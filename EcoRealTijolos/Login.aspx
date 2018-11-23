<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EcoRealTijolos.Login" %>

<!DOCTYPE html>

<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Gerenciamento EcoReal Tijolos</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="css/AdminLTE.css" rel="stylesheet" type="text/css" />
</head>
<body class="bg-black">
    <form id="form1" runat="server">
        <div class="form-box" id="login-box">
            <layouttemplate>
                    <div class="header">Acesso ao Sistema</div>
                    <div class="body bg-gray">
                        <div class="form-group" title="Login">
                            <asp:TextBox ID="txtLogin" runat="server" CssClass="form-group" style="width:100%" placeholder="Inserir login..."></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtSenha" runat="server" CssClass="form-group" style="width:100%" placeholder="Inserir senha..." TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                    <div class="footer">
                        <asp:Button ID="btnLogar" runat="server" CssClass="btn bg-olive btn-block" OnClick="btnLogar_Click" Text="Entrar" />
                <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Black"></asp:Label>
                    </div>
                </layouttemplate>
        </div>
    </form>
</body>
<script src="js/jquery-3.1.0.min.js"></script>
<script src="js/bootstrap.min.js" type="text/javascript"></script>
</html>
