<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="RelatorioVenda.aspx.cs" Inherits="EcoRealTijolos.RelatorioVenda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">

    <section class="content-header">
        <h1 style="text-align: center">RELÁTORIO DE VENDAS</h1>
    </section>
    <section class="content">
        <div>
            <label>Período de busca do relatório</label>
            <br />
            <br />
            <label>Data Inicial:</label>
            <br />
            <asp:TextBox ID="txtInicial" runat="server"></asp:TextBox>
            <br />
            <br />
            <label>Data Final:</label>
            <br />
            <asp:TextBox ID="txtFinal" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="txtMensagem" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnEnviar" runat="server" Text="Gerar Relatório" OnClick="btnEnviar_Click" />
            <br />
            <br />
        </div>
        <div id="chart_div" style="width: 900px; height: 500px;"></div>
    </section>
</asp:Content>
 
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
