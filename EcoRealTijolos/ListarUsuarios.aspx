﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ListarUsuarios.aspx.cs" Inherits="EcoRealTijolos.ListarUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <!-- Datatable Part -->
    <section class="content-header">
        <h1 style="text-align: center">LISTA DE USUÁRIOS</h1>
    </section>
    <div class="row">
        <div class="col-md-12">
            <div class="box box-primary">
                <div class="box-body table-responsive">
                    <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" CssClass="table table-bordered table-hover" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="usu_nome" HeaderText="Nome" />
                            <asp:BoundField DataField="usu_email" HeaderText="E-mail" />
                            <asp:BoundField DataField="usu_login" HeaderText="Login" />
                            
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbAlterar" runat="server" CssClass="btn btn-dark" CommandName="Alterar" CommandArgument='<%# Bind("usu_id")%>'><i class="fa fa-check-square-o" aria-hidden="true"></i></asp:LinkButton>
                                    &nbsp;
                                    <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar" CssClass="btn btn-danger" CommandArgument='<%# Bind("usu_id")%>'><i class="fa fa-minus-square-o"></i></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
    <!-- End Datatable -->
    <div>
        <div align="center">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="BtnNovo" runat="server" CssClass="btn btn-primary" Width="200px" Text="Novo Cadastro" OnClick="BtnNovo_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
