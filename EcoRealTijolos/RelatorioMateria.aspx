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
        <div class="content">
            <asp:Label ID="Label1" runat="server" Text="Capacidade de traços com estoque atual:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Cimento: "></asp:Label>
            <asp:TextBox ID="txtCimento" runat="server" Visible="True" ReadOnly="True"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Label ID="Label4" runat="server" Text="Areia: "></asp:Label>
            <asp:TextBox ID="txtAreia" runat="server" Visible="True" ReadOnly="True"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Label ID="Label5" runat="server" Text="Terra: "></asp:Label>
            <asp:TextBox ID="txtTerra" runat="server" Visible="True" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Capacidade possível de produção com o estoque atual:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Tijolos ecológicos:"></asp:Label>
            <br />

            <asp:Label ID="Label7" runat="server" Text="Cimento: "></asp:Label>
            <asp:TextBox ID="txtCpCimento" runat="server" Visible="True" ReadOnly="True"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Label ID="Label8" runat="server" Text="Areia: "></asp:Label>
            <asp:TextBox ID="txtCpAreia" runat="server" Visible="True" ReadOnly="True"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Label ID="Label9" runat="server" Text="Terra: "></asp:Label>
            <asp:TextBox ID="txtCpTerra" runat="server" Visible="True" ReadOnly="True"></asp:TextBox>

            <br />
            <br />
        </div>
    </section>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
