<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarMatPrima.aspx.cs" Inherits="EcoRealTijolos.Pages.MateriaPrima.ListarMatPrima" %>

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
        <asp:GridView ID="TabelaMatPrima" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#006600" BorderStyle="Double" Font-Names="Arial">
            <Columns>
                <asp:BoundField DataField="mat_id" HeaderText="Descrição" />
                <asp:BoundField DataField="mat_quantidade" HeaderText="Quantidade" />
            </Columns>
            <EditRowStyle BackColor="White" />
        </asp:GridView>
    </form>
</body>
</html>
