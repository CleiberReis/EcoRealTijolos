<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="RelatorioMateria.aspx.cs" Inherits="EcoRealTijolos.RelatorioMateria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">

    <section class="content-header">
        <h1 style="text-align: center">RELÁTORIO DE MATÉRIA PRIMA</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-primary">
                    <div class="box-body table-responsive">
                        <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="mat_nome" HeaderText="Descrição" />
                                <asp:BoundField DataField="mat_quantidade" HeaderText="Quantidade em estoque" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
