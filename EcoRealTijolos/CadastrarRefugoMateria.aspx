<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="CadastrarRefugoMateria.aspx.cs" Inherits="EcoRealTijolos.CadastrarRefugoMateria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">REFUGO DE MATÉRIA PRIMA</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>SELECIONE A MATÉRIA PRIMA:</label>
                            <asp:DropDownList ID="ddlNomeMateria" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>QUANTIDADE DE PERDA:</label>
                            <asp:TextBox ID="txtQuantidadePerda" runat="server" Text="" CssClass="form-control col-md-6"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>OBSERVAÇÕES:</label>
                            <asp:TextBox ID="txtObservacao" runat="server" Text="" CssClass="form-control col-md-6"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <div align="center">
        <div class="form-group">
            <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Blue"></asp:Label>
        </div>
        <table>
            <tr>
                <td>
                    <asp:Button ID="BtnVoltarLista" runat="server" CssClass="btn btn-facebook" Width="80px" Text="Voltar" OnClick="BtnVoltarLista_Click" />
                </td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td>
                    <asp:Button ID="BtnSalvar" runat="server" CssClass="btn btn-primary" Width="200px" OnClick="BtnSalvar_Click" Text="Salvar" />
                </td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td>
                    <asp:Button ID="BtnListar" runat="server" CssClass="btn btn-danger" Width="200px" Text="Lista Refugo" OnClick="BtnListar_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
