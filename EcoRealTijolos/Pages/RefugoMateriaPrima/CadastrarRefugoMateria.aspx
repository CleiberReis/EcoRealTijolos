﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Content/Master/Home.Master" AutoEventWireup="true" CodeBehind="CadastrarRefugoMateria.aspx.cs" Inherits="EcoRealTijolos.Pages.RefugoMateriaPrima.CadastrarRefugoMateria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <!-- IonIcons -->
    <link href="../../Content/css/ionicons.min.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/css/AdminLTE.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/jAlert/jquery.alerts.css" rel="stylesheet" type="text/css" />
    <!-- DataTables -->
    <link href="../../Content/css/datatables/dataTables.bootstrap.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.min.js" type="text/javascript"></script>
    <script src="../../Scripts/js/jquery-ui.min.js" type="text/javascript"></script>
    <script src="../../Scripts/js/AdminLTE/app.js" type="text/javascript"></script>
    <script src="../../Content/jAlert/jquery.alerts.js" type="text/javascript"></script>
    <script src="../../Scripts/js/jquery.ui.draggable.js" type="text/javascript"></script>
    <script src="../../Scripts/js/plugins/datatables/jquery.dataTables.js"></script>
    <script src="../../Scripts/js/plugins/datatables/dataTables.bootstrap.js"></script>
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
            </tr>
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>