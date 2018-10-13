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
            ProdutoBD produtobd = new ProdutoBD();
            DataSet produtods = produtobd.SelectAll();
            ddlProduto.DataSource = produtods.Tables[0].DefaultView;
            ddlProduto.DataTextField = "prod_nome";
            ddlProduto.DataValueField = "prod_id";
            ddlProduto.DataBind();
            ddlProduto.Items.Insert(0, "Selecione um produto");

            PedidoBD pedidobd = new PedidoBD();
            DataSet pedidods = pedidobd.SelectAllPedidos();
            ddlPedido.DataSource = pedidods.Tables[0].DefaultView;
            ddlPedido.DataTextField = "ped_id";
            ddlPedido.DataValueField = "ped_id";
            ddlPedido.DataBind();

        }

        private void LimparCampos()
        {
            txtQuantidade.Text = "";
            txtSubtotal.Text = "";
            lblMensagem.Text = "";
            //remove seleção do ddl
            for (int i = 0; i < ddlProduto.Items.Count; i++)
            {
                ddlProduto.Items[i].Selected = false;
            }
            //coloca o "Selecione" selecionado
            ddlProduto.Items[0].Selected = true;
        }
        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            ProdutoBD produtobd = new ProdutoBD();
            Produto produto = produtobd.Select(Convert.ToInt32(ddlProduto.SelectedItem.Value));

            PedidoBD pedidobd = new PedidoBD();
            Pedido pedido = pedidobd.Select(Convert.ToInt32(ddlPedido.SelectedItem.Value));


            PedidoProduto pedidoproduto = new PedidoProduto();
            pedidoproduto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            pedidoproduto.Subtotal = Convert.ToDouble(txtSubtotal.Text);

            pedidoproduto.Produto = produto;
            pedidoproduto.Pedido = pedido;

            PedidoProdutoBD pedidoprodutobd = new PedidoProdutoBD();
            int retorno = pedidoprodutobd.Insert(pedidoproduto);
            
            switch (retorno)
            {
                case 0:
                    LimparCampos();
                    ddlProduto.Focus();
                    lblMensagem.Text = "Pedido Finalizado com sucesso";
                    break;
                case 1:
                    //Erro no banco de dados
                    lblMensagem.Text = "Não foi possível realizar o pedido.";
                    break;
                case 2:
                    //Erro geral
                    lblMensagem.Text = "Não foi possível realizar o pedido.";
                    break;
                default:
                    break;
            }
        }
    }
}

