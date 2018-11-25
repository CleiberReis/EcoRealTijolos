<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="CadastrarPedido.aspx.cs" Inherits="EcoRealTijolos.CadastrarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">CADASTRO DE PEDIDOS</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>CLIENTE:</label>
                            <asp:DropDownList ID="ddlCliente" Width="500px" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label style="font-weight: bold">DADOS DA ENTREGA</label>
                        </div>
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
                        <div class="form-group">
                            <label>DATA DA ENTREGA:</label>
                            <asp:TextBox ID="txtData" runat="server" Width="120px" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>OBSERVAÇÃO DO PEDIDO:</label>
                            <asp:TextBox ID="txtObsPedido" runat="server" Width="500px" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <table>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnProximo" runat="server" CssClass="btn btn-primary" Width="200px" OnClick="btnProximo_Click" Text="Próximo" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div align="center">
            <div class="form-group">
                <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Blue"></asp:Label>
            </div>
        </div>
    </section>
</asp:Content>
