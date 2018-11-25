<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="EcoRealTijolos.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div id="container">
        <div class="text" style="align-content:center">
            <asp:Label runat="server" ID="lblTitulo"></asp:Label>
            <asp:Button ID="lbSair" runat="server" CssClass="btn btn-sm" OnClick="lbSair_Click" Text="Sair"></asp:Button>
        </div>
        &nbsp;
        <div class="col-sm-6 col-lg-4">
            <div class="overview-item overview-item--c4">
                <div class="overview__inner">
                    <div class="overview-box clearfix">
                        <div class="icon">
                            <i class="zmdi zmdi-alert-triangle">
                                <div class="text">
                                    <h2>ALERTA</h2>
                                </div>
                            </i>
                        </div>
                        <div class="text">
                            <asp:Label ID="lblAviso" runat="server" Font-Bold="True"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
