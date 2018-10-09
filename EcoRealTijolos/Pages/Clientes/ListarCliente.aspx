<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarCliente.aspx.cs" Inherits="EcoRealTijolos.Pages.Clientes.ListarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Lista de Clientes</title>

    <!--  -->
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/jquery.validate.bootstrap.css" rel="stylesheet" />
    <link href="../../Content/font-awesome.min.css" rel="stylesheet" />
  
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar" CommandArgument='<%# Bind("cli_id")%>'>Alterar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar" CommandArgument='<%# Bind("cli_id")%>'>Excluir</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
    <br />
    <a href="CadastrarCliente.aspx">Cadastro de Clientes</a>

    <!-- Scripts -->
    <script src="../../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../../Scripts/jquery.validate.min.js"></script>
    <script src="../../Scripts/popper.min.js"></script>
    <script src="../../Scripts/bootstrap.bundle.min.js"></script>
     <script src="../../Scripts/bootstrap.min.js"></script>
</body>
</html>
