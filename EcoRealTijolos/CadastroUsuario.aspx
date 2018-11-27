<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="EcoRealTijolos.CadastroUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">CADASTRO DE USUÁRIOS</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>NOME:</label>
                            <asp:TextBox ID="txtUser" runat="server" Text="" CssClass="form-control col-md-6"></asp:TextBox>
                        </div>
                        &nbsp;
                        <div class="form-group">
                            <label>E-MAIL:</label>
                            <asp:TextBox ID="txtEmail" runat="server" Text="" CssClass="form-control col-md-6"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>LOGIN:</label>
                            <asp:TextBox ID="txtLogin" runat="server" Text="" CssClass="form-control col-md-6"></asp:TextBox>
                        </div>
                        &nbsp;
                        <div class="form-group">
                            <label>ADMINISTRADOR?</label><asp:CheckBox ID="CbxAdmSim" Text="Sim" runat="server" CssClass="form-control" OnCheckedChanged="CbxAdmSim_CheckedChanged" BorderStyle="None" BorderWidth="0px" Font-Bold="True" Width="89px"></asp:CheckBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <label>ATIVO?        </label><asp:CheckBox ID="CbxAtivo" Text="Sim" runat="server" CssClass="form-control" OnCheckedChanged="CbxAtivo_CheckedChanged" BorderStyle="None" BorderWidth="0px" Width="85px">
                            </asp:CheckBox>
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
                        <asp:Button ID="BtnLista" runat="server" CssClass="btn btn-danger" Width="200px" Text="Lista" OnClick="BtnLista_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
