<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AlterarMateriaPrima.aspx.cs" Inherits="EcoRealTijolos.AlterarMateriaPrima" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">ALTERAÇÃO DE MATÉRIA PRIMA</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>DESCRIÇÃO:</label>
                            <asp:DropDownList ID="ddlNomeMateria" runat="server" CssClass="form-control">
                            </asp:DropDownList>
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
            </tr>
        </table>
        <br />
        <br />
    </div>
</asp:Content>
