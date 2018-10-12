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
    public partial class CadastrarProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Nome = txtNome.Text;
            produto.ValorUnitario = Convert.ToDouble(txtValor.Text);
            produto.Quantidade = txtQuantidade.Text;
            ProdutoBD bd = new ProdutoBD();
            if (bd.Insert(produto))
            {
                lblMensagem.Text = "Funcionário cadastrado com sucesso";
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