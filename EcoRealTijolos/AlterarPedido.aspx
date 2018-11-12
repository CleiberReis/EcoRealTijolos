<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AlterarPedido.aspx.cs" Inherits="EcoRealTijolos.AlterarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">ALTERAÇÃO DE PEDIDO</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>CLIENTE:</label>
                            <asp:DropDownList ID="ddlCliente" runat="server" Height="21px" Width="131px" CssClass="form-control">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group" style="text-align: center">
                            <label style="font-weight: bold">DADOS DA ENTREGA</label>
                        </div>
                        <div class="form-group">
                            <label>ENDEREÇO COMPLETO:</label>
                            <asp:TextBox ID="txtEndereco" Width="562px" Height="24px" runat="server" Text="" CssClass="form-control col-md-6"></asp:TextBox>
                            <label>Ex: Rua xxxx, 00, Bairro xxx - Cidade (UF)</label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>DATA DA ENTREGA:</label>
                            <asp:TextBox ID="txtData" runat="server" Width="114px" Height="21px" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>OBSERVAÇÃO DO PEDIDO:</label>
                            <asp:TextBox ID="txtObsPedido" runat="server" Width="406px" Height="21px" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <table>
                                <tr>
                                    <td>
                                        <asp:Button ID="BtnAlterar" runat="server" CssClass="btn btn-primary" Width="200px" OnClick="BtnAlterar_Click" Text="Alterar" />
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
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
