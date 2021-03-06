﻿<%@ Page Title="" Language="C#" AutoEventWireup="true" MasterPageFile="~/Home.Master" CodeBehind="CadastrarCliente.aspx.cs" Inherits="EcoRealTijolos.CadastrarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">CADASTRO DE CLIENTES</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>NOME:</label>
                            <asp:TextBox ID="txtNome" Width="500px" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>CPF:</label>
                            <asp:TextBox ID="txtCpf" Width="500px" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>TELEFONE:</label>
                            <asp:TextBox ID="txtTelefone" Width="200px" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>E-MAIL:</label>
                            <asp:TextBox ID="txtEmail" Width="500px" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>LOGRADOURO:</label>
                            <asp:TextBox ID="txtLogradouro" Width="500px" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <label>BAIRRO:</label>
                            <asp:TextBox ID="txtBairro" Width="500px" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <label>Nº:</label>
                            <asp:TextBox ID="txtNumero" Width="100px" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <label>ESTADO:</label>
                            <asp:DropDownList ID="ddlEstado" Width="500px" runat="server" CssClass="form-control"></asp:DropDownList>&nbsp
                            <label>CIDADE:</label>
                            <asp:DropDownList ID="ddlCidade" Width="500px" runat="server" CssClass="form-control">
                            </asp:DropDownList>
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

