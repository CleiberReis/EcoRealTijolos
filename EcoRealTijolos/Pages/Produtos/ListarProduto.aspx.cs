﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos.Pages.Produtos
{
    public partial class ListarProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        protected void Carregar()
        {
            ProdutoBD bd = new ProdutoBD();
            DataSet ds = bd.SelectAll();
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = 0;
            switch (e.CommandName)
            {
                case "Alterar":
                    codigo = Convert.ToInt32(e.CommandArgument);
                    Session["ID"] = codigo;
                    Response.Redirect("AlterarProduto.aspx");
                    break;
                case "Excluir":
                    codigo = Convert.ToInt32(e.CommandArgument);
                    ProdutoBD bd = new ProdutoBD();
                    bd.Delete(codigo);
                    Carregar();
                    break;
                default:
                    break;
            }
        }
    }
}