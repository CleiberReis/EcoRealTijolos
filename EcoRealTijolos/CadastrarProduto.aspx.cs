using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos
{
    public partial class CadastrarProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Estoque - Produtos";
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Nome = txtNome.Text;
            produto.ValorUnitario = Convert.ToDouble(txtValor.Text);
            produto.QuantidadeTotal = Convert.ToInt32(txtQuantidade.Text);
            ProdutoBD bd = new ProdutoBD();
            if (bd.Insert(produto))
            {
                lblMensagem.Text = "Produto cadastrado com sucesso";
                txtNome.Text = "";
                txtValor.Text = "";
                txtQuantidade.Text = "";
                txtNome.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }

        }
    }
}