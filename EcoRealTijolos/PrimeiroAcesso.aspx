<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrimeiroAcesso.aspx.cs" Inherits="EcoRealTijolos.PrimeiroAcesso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Gerenciamento EcoReal Tijolos</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="css/AdminLTE.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-box" id="login-box">
            <layouttemplate>
                    <div class="header">Acesso ao Sistema</div>
                    <div class="body bg-gray">
                        
                        <div class="form-group">
                            <asp:TextBox ID="txtSenha" runat="server" CssClass="form-group" style="width:100%" placeholder="Insira a senha recebida no seu E-mail" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtSenhav" runat="server" CssClass="form-group" style="width:100%" placeholder="Insira sua nova senha" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtConfSenha" runat="server" CssClass="form-group" style="width:100%" placeholder="Insira novamente sua nova senha" TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                    <div class="footer">
                        <asp:Button ID="btnLogar" runat="server" CssClass="btn bg-olive btn-block" OnClick="btnLogar_Click" Text="Salvar e entrar" />
                
                    </div>
                </layouttemplate>
        </div>
    </form>
</body>
</html>
