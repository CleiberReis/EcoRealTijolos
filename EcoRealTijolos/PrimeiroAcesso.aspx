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
                            &nbsp;
                            <asp:TextBox ID="txtSenha1" runat="server" CssClass="form-group" placeholder="Insira a senha recebida no seu E-mail" TextMode="Password" Height="20px" Width="296px"></asp:TextBox>
                        &nbsp;</div>
                        <div class="form-group">
                            &nbsp;&nbsp;
                            <asp:TextBox ID="txtSenhav" runat="server" CssClass="form-group" placeholder="Insira sua nova senha" TextMode="Password" Width="289px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            &nbsp;&nbsp;
                            <asp:TextBox ID="txtConfSenha" runat="server" CssClass="form-group" placeholder="Insira novamente sua nova senha" TextMode="Password" Width="290px" OnTextChanged="txtConfSenha_TextChanged"></asp:TextBox>
                        &nbsp;<asp:Label ID="lblMensagem" runat="server" Width="250px"></asp:Label>
                        </div>
                    </div>
                    <div class="footer">
                        <asp:Button ID="btnSalvaEntra" runat="server" CssClass="btn bg-olive btn-block" OnClick="btnSalvaEntra_Click" Text="Salvar e entrar" />
                
                    </div>
                </layouttemplate>
        </div>
    </form>
</body>
</html>