using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;
using System.Data.SqlClient;

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
            ddlProduto.Items.Insert(0, "selecione um produto");

            PedidoBD pedidobd = new PedidoBD();
            DataSet pedidods = pedidobd.SelectAllPedidos();
            ddlPedido.DataSource = pedidods.Tables[0].DefaultView;
            ddlPedido.DataTextField = "ped_id";
            ddlPedido.DataValueField = "ped_id";
            ddlPedido.DataBind();

            ClienteBD bd = new ClienteBD();
            DataSet ds = bd.SelectAll();
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();

        }

        private void LimparCampos()
        {
            txtQuantidade.Text = "";
            txtSubtotal.Text = "";
            txtValorUnitario.Text = "";
            lblMensagem.Text = "";
            //remove seleção do ddl
            for (int i = 0; i < ddlProduto.Items.Count; i++)
            {
                ddlProduto.Items[i].Selected = false;
            }
            //coloca o "Selecione" selecionado
            ddlProduto.Items[0].Selected = true;
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double calcular = Convert.ToDouble(txtValorUnitario.Text) * Convert.ToInt32(txtQuantidade.Text);
            txtSubtotal.Text = calcular.ToString();
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
        /*
        try
        {
            if (e.ColumnIndex == 3)
            {
                decimal cell1 = Convert.ToDecimal(gdvItens.CurrentRow.Cells[2].Value);
                decimal cell2 = Convert.ToDecimal(gdvItens.CurrentRow.Cells[3].Value);
                if (cell1.ToString() != "" && cell2.ToString() != "")
                {
                    gdvItens.CurrentRow.Cells[4].Value = cell1 * cell2;
                }
            }
            decimal valorTotal = 0;
            string valor = "";
            if (gdvItens.CurrentRow.Cells[4].Value != null)
            {
                valor = gdvItens.CurrentRow.Cells[4].Value.ToString();
                if (!valor.Equals(""))
                {
                    for (int i = 0; i <= gdvItens.RowCount - 1; i++)
                    {
                        if (gdvItens.Rows[i].Cells[4].Value != null)
                            valorTotal += Convert.ToDecimal(gdvItens.Rows[i].Cells[4].Value);
                    }
                    if (valorTotal == 0)
                    {
                        MessageBox.Show("Nenhum registro encontrado");
                    }
                    txtTotal.Text = valorTotal.ToString("C");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }*/

    }
}

