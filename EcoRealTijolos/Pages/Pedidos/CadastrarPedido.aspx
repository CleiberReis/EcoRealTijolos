<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarPedido.aspx.cs" Inherits="EcoRealTijolos.Pages.Pedidos.CadastrarPedido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblCliente" runat="server" Text="Cliente: "></asp:Label>
            <asp:DropDownList ID="ddlCliente" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            ENDEREÇO PARA ENTREGA:<br />
            <br />
            <asp:Label ID="lblCep" runat="server" Text="CEP: "></asp:Label>
            <br />
            <asp:TextBox ID="txtCep" runat="server"></asp:TextBox>

            <br />
            <asp:Label ID="lblRua" runat="server" Text="Rua: "></asp:Label>
            <br />
            <asp:TextBox ID="txtRua" runat="server" Width="393px"></asp:TextBox>
            
            <br />
            <asp:Label ID="lblNumero" runat="server" Text="Numero: "></asp:Label>
            <br />
            <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>

            <br />
            <asp:Label ID="lblEstado" runat="server" Text="Estado: "></asp:Label>
            <br />
            <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>

            <br />
            <asp:Label ID="lblCidade" runat="server" Text="Cidade: "></asp:Label>
            <br />
            <asp:TextBox ID="txtCidade" runat="server" Width="192px"></asp:TextBox>

            <br />
            <asp:Label ID="lblComplemento" runat="server" Text="Complemento: "></asp:Label>
            <br />
            <asp:TextBox ID="txtComplemento" runat="server" Width="192px"></asp:TextBox>
            
            <br />
            <br />
            <br />
            FINALIZAR ENTREGA:<br />
            
            <br />
            <asp:Label ID="lblDtPedido" runat="server" Text="Data de Entrega: "></asp:Label>
            <br />
            <asp:Calendar ID="calPedido" runat="server"></asp:Calendar>
            <br />
            
            <asp:Label ID="lblObsPedido" runat="server" Text="Observação: "></asp:Label>
            <br />
            <asp:TextBox ID="txtObsPedido" runat="server" Width="192px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnSalvar" runat="server" OnClick="BtnSalvar_Click" Text="Salvar" />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
