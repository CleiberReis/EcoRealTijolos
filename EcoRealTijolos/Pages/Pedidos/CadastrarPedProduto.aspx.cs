using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos.Pages.Pedidos
{
    public partial class CadastrarPedProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Carregar();
                ddlProduto.Focus();
            }
        }

        private void Carregar()
        {
            ProdutoBD bd = new ProdutoBD();
            DataSet ds = bd.SelectAll();
            ddlProduto.DataSource = ds.Tables[0].DefaultView;
            ddlProduto.DataTextField = "prod_nome";
            ddlProduto.DataValueField = "prod_id";
            ddlProduto.DataBind();
            ddlProduto.Items.Insert(0, "Selecione um produto");
        }
    }
}

