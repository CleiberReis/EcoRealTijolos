<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="CadastrarMateriaPrima.aspx.cs" Inherits="EcoRealTijolos.CadastrarMateriaPrima" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">CADASTRO DE MATÉRIA PRIMA</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>DESCRIÇÃO:</label>
                            <asp:TextBox ID="txtNomeMateria" runat="server" Text="" CssClass="form-control col-md-6"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>QUANTIDADE:</label>
                            <asp:TextBox ID="txtQuantidadeMateria" runat="server" Text="" CssClass="form-control col-md-6"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div align="center">
            <div class="form-group">
                <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Blue"></asp:Label>
            </div>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="BtnSalvar" runat="server" CssClass="btn btn-primary" Width="200px" OnClick="BtnSalvar_Click" Text="Salvar" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="BtnIncluirPerda" runat="server" CssClass="btn btn-dark" Width="200px" Text="Incluir Perda" OnClick="BtnIncluirPerda_Click" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="BtnLista" runat="server" CssClass="btn btn-danger" Width="200px" Text="Lista" OnClick="BtnLista_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
