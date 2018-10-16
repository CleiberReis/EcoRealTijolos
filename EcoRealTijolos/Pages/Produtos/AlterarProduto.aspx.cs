using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos.Pages.Produtos
{
    public partial class AlterarProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Estoque - Produtos";

                ProdutoBD bd = new ProdutoBD();
                Produto produto = bd.Select(Convert.ToInt32(Session["ID"]));
                txtNome.Text = produto.Nome;
                txtValor.Text = produto.ValorUnitario.ToString();
                txtQuantidade.Text = produto.QuantidadeTotal.ToString();
            }
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            ProdutoBD bd = new ProdutoBD();
            Produto produto = bd.Select(Convert.ToInt32(Session["ID"]));
            produto.Nome = txtNome.Text;
            produto.ValorUnitario = Convert.ToDouble(txtValor.Text);
            produto.QuantidadeTotal = Convert.ToInt32(txtQuantidade.Text);
            if (bd.Update(produto))
            {
                lblMensagem.Text = "Produto alterado com sucesso";
                txtNome.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }
    }
}