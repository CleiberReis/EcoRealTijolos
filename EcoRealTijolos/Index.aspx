﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="EcoRealTijolos.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Gerenciamento EcoReal Tijolos</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" />
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="css/theme.css" rel="stylesheet" type="text/css" />
    <link href="css/font-face.css" rel="stylesheet" type="text/css" />
    <link href="css/mdi-font/css/material-design-iconic-font.min.css" rel="stylesheet" type="text/css" />
    <!-- IonIcons -->
    <link href="css/ionicons.min.css" rel="stylesheet" type="text/css" />
    <link href="css/AdminLTE.css" rel="stylesheet" type="text/css" />
    <link href="jAlert/jquery.alerts.css" rel="stylesheet" type="text/css" />
    <!-- DataTables -->
    <link href="css/datatables/dataTables.bootstrap.css" rel="stylesheet" />

    <style>
        html, body {
            min-height: 100%;
            padding: 0;
            margin: 0;
            font-family: 'Source Sans Pro', "Helvetica Neue",
        }

        iframe {
            display: block;
            overflow: auto;
            border: 0;
            margin: 0;
            padding: 0;
            margin: 0;
        }

        .iframe {
            height: 49px;
            margin: 0;
            padding: 0;
            border-bottom: 1px solid #ddd;
        }

        .frame a {
            color: #666;
        }

            .frame a:hover {
                color: #222;
            }

        .frame .buttons a {
            height: 49px;
            line-height: 49px;
            display: inline-block;
            text-align: center;
            width: 50px;
            border-left: 1px solid #ddd;
        }

        .frame .brand {
            color: #444;
            font-size: 20px;
            line-height: 49px;
            display: inline-block;
            padding-left: 10px;
        }

        .iframe .brand small {
            font-size: 14px;
        }

        a, a:hover {
            text-decoration: none;
        }

        .container-fluid {
            padding: 0;
            margin: 0;
        }

        .text-muted {
            color: #999;
        }

        .ad {
            text-align: center;
            position: fixed;
            bottom: 0;
            left: 0;
            background: #222;
            background: rgba(0,0,0,8);
            width: 100%;
            color: #fff;
            display: none;
        }

        #close-ad {
            float: left;
            margin-left: 10px;
            margin-top: 10px;
            cursor: pointer;
        }
    </style>
</head>
<body class="skin-blue">
    <header class="header">
        <!-- CABEÇALHO -->
        <a href="#" class="logo">ECO REAL TIJOLOS</a>
        <nav class="navbar navbar-static-top" role="navigation">
            <a href="#" class="navbar-btn sidebar-toggle" data-toggle="offcanvas" role="button">
                <span class="sr-only">Toggle Navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </a>
        </nav>
    </header>
    <div class="wrapper row-offcanvas row-offcanvas-left">
        <aside class="left-side sidebar-offcanvas">
            <section class="sidebar">
                <div class="user-panel">
                    <div class="pull-left image">
                        <img src="css/images/logo_icon.png" runat="server" class="img-circle" alt="User Image" />
                    </div>
                    <div class="pull-left info">
                        <p>
                            <!--Bem vindo sr(a)<br />
                            <asp:Label runat="server" ID="lblTitulo"></asp:Label> -->
                        </p>
                    </div>
                </div>
                <ul class="sidebar-menu">
                    <li class="active">
                        <a href="Index.aspx">
                            <i class="fa fa-home"></i>
                            <span>Página Inicial</span>
                        </a>
                    </li>
                    <li class="treeview">
                        <a href="#">
                            <i class="fa fa-cart-arrow-down"></i>
                            <span>Pedidos</span>
                            <i class="fa fa-angle-right pull-right"></i>
                        </a>
                        <ul class="treeview-menu">
                            <li>
                                <a href="CadastrarPedido.aspx"><i class="fa fa-angle-double-right"></i>Cadastrar</a>
                                <a href="ListarPedido.aspx"><i class="fa fa-angle-double-right"></i>Listar</a>
                                <a href="Orcamento.aspx"><i class="fa fa-angle-double-right"></i>Orçamento</a>
                            </li>
                        </ul>
                    </li>
                    <li class="treeview">
                        <a href="#">
                            <i class="fa fa-address-card"></i>
                            <span>Clientes</span>
                            <i class="fa fa-angle-right pull-right"></i>
                        </a>
                        <ul class="treeview-menu">
                            <li>
                                <a href="CadastrarCliente.aspx"><i class="fa fa-angle-double-right"></i>Cadastrar</a>
                                <a href="ListarCliente.aspx"><i class="fa fa-angle-double-right"></i>Listar</a>
                            </li>
                        </ul>
                    </li>
                    <li class="treeview">
                        <a href="#">
                            <i class="fa fa-cubes"></i>
                            <span>Estoque</span>
                            <i class="fa fa-angle-right pull-right"></i>
                        </a>
                        <ul class="treeview-menu">
                            <li>
                                <a href="CadastrarProduto.aspx"><i class="fa fa-angle-double-right"></i>Produtos</a>
                                <a href="CadastrarMateriaPrima.aspx"><i class="fa fa-angle-double-right"></i>Matéria Prima</a>
                            </li>
                        </ul>
                    </li>
                    <li class="treeview">
                        <a href="#">
                            <i class="fa fa-line-chart"></i>
                            <span>Relatórios</span>
                            <i class="fa fa-angle-right pull-right"></i>
                        </a>
                        <ul class="treeview-menu">
                            <li>
                                <a href="RelatorioVenda.aspx"><i class="fa fa-angle-double-right"></i>Relatório de Vendas</a>
                                <a href="RelatorioMateria.aspx"><i class="fa fa-angle-double-right"></i>Relatório de Matéria Prima</a>
                            </li>
                        </ul>
                    </li>
                    <li class="treeview">
                        <a href="#">
                            <i class="fa fa-gear"></i>
                            <span>Área do Admim</span>
                            <i class="fa fa-angle-right pull-right"></i>
                        </a>
                        <ul class="treeview-menu">
                            <li>
                                <a href="CadastroUsuario.aspx"><i class="fa fa-angle-double-right"></i>Cadastrar Usuários</a>
                                <a href="ListarUsuarios.aspx"><i class="fa fa-angle-double-right"></i>Listar Usuários</a>
                            </li>
                        </ul>
                    </li>
                    <li class="active" style="background-color:darkred">
                        <a href="Login.aspx">
                            <i class="fa fa-close"></i>
                            <span>Sair do Sistema</span>
                        </a>
                    </li>
                </ul>
            </section>
        </aside>
        <aside class="right-side">
            <section class="content-header">
                <h1>
                    <asp:Label ID="lblOptionMenu" runat="server" Text="Página Inicial"></asp:Label>
                </h1>
            </section>
            <section class="content">
                <form id="form1" runat="server">
                    <div id="container">
                         <%--Comentei só pra ficar esteticamente mais bonito kkk--%>
                       <%-- <div class="text" style="align-content: center">
                            <asp:Button ID="lbSair" runat="server" CssClass="btn btn-sm" OnClick="lbSair_Click" Text="Sair"></asp:Button>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </div>--%>
                        &nbsp;
                        <div class="col-sm-6 col-lg-4">
                            <div class="overview-item overview-item--c3">
                                <div class="overview__inner">
                                    <div class="overview-box clearfix">
                                        <div class="icon">
                                            <i class="zmdi zmdi-alert-triangle">
                                                <div class="text">
                                                    <h2>ALERTA</h2>
                                                </div>
                                            </i>
                                        </div>
                                        <div class="text">
                                            <asp:Label ID="lblAviso" runat="server" Font-Bold="True"></asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-lg-4">
                            <div class="overview-item overview-item--c3">
                                <div class="overview__inner">
                                    <div class="overview-box clearfix">
                                        <div class="icon">
                                            <i class="zmdi zmdi-alert-triangle">
                                                <div class="text">
                                                    <h2>ALERTA</h2>
                                                </div>
                                            </i>
                                        </div>
                                        <div class="text">
                                            <asp:Label ID="lblAvisoMateria" runat="server" Font-Bold="True"></asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </form>
            </section>
        </aside>
    </div>
    <script src="js/jquery.min.js" type="text/javascript"></script>
    <script src="js/bootstrap.min.js" type="text/javascript"></script>
    <script src="js/jquery-ui.min.js" type="text/javascript"></script>
    <script src="js/AdminLTE/app.js" type="text/javascript"></script>
    <script src="jAlert/jquery.alerts.js" type="text/javascript"></script>
    <script src="js/jquery.ui.draggable.js" type="text/javascript"></script>
    <script src="Scripts/umd/popper.min.js" type="text/javascript"></script>
    <script src="js/plugins/datatables/jquery.dataTables.js"></script>
    <script src="js/plugins/datatables/dataTables.bootstrap.js"></script>
</body>
</html>
