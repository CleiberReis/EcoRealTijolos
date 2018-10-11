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

            CADASTRAR PEDIDOS<br />
            <br />
            <br />

            <asp:Label ID="lblCliente" runat="server" Text="Cliente: "></asp:Label>
            <asp:DropDownList ID="ddlCliente" runat="server" Height="21px" Width="131px">
            </asp:DropDownList>
            <br />
            <br />
            ENDEREÇO PARA ENTREGA:<br />

            <br />
            <asp:Label ID="lblEndereco" runat="server" Text="Endereço Completo:"></asp:Label>
            <br />
            <asp:TextBox ID="txtEndereco" runat="server" Width="562px" Height="24px"></asp:TextBox>
            
            <br />
            <asp:Label ID="lblObsEndereco" runat="server" Font-Size="Smaller" Text="Ex:  (Rua xxxx, 00, Bairro xxx - Cidade (UF))"></asp:Label>
            <br />
            <br />
            FINALIZAR ENTREGA:<br />
            
            <br />
            <asp:Label ID="lblDtPedido" runat="server" Text="Data de Entrega: "></asp:Label>
            <br />
            <asp:TextBox ID="txtData" runat="server" Width="114px" Height="21px"></asp:TextBox>
            <br />
            <br />
            
            <asp:Label ID="lblObsPedido" runat="server" Text="Observação do Pedido: "></asp:Label>
            <br />
            <asp:TextBox ID="txtObsPedido" runat="server" Width="406px" Height="21px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnSalvar" runat="server" OnClick="BtnSalvar_Click" Text="Salvar" />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
