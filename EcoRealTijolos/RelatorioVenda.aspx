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
        <div id="chart_div" style="width: 900px; height: 500px;"></div>
    </section>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
