<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="RelatorioVenda.aspx.cs" Inherits="EcoRealTijolos.RelatorioVenda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content">
        <div>
            <h3>Período de Busca do Relatório</h3>
            <br />
            <div class="row">
                <div class="col-md-12">
                    <div class="box box-primary">
                        <div class="box-body">
                            <div class="row">
                                <div class="col-md-4">
                                    <label>Data Inicial:</label>
                                    <br />
                                    <asp:TextBox ID="txtInicial" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-md-4">
                                    <label>Data Final:</label>
                                    <br />
                                    <asp:TextBox ID="txtFinal" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-md-4">
                                    <label></label>
                                    <br />
                                    <asp:Button ID="btnEnviar" runat="server" CssClass="btn btn-primary" Text="Gerar Relatório" OnClick="btnEnviar_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <asp:Label ID="txtMensagem" runat="server" BackColor="#00FF99" ForeColor="Red"></asp:Label>
            <br />
            <br />
        </div>
        <div id="chart_div" style="width: 1000px; height: 500px;"></div>
    </section>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
