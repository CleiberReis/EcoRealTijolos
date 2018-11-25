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

namespace EcoRealTijolos
{
    public partial class CadastrarPedProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Pedidos";
                Carregar();
                CarregaProdutos(Convert.ToInt32(Session["pedidoID"]));
                ddlProduto.Focus();
            }
        }

        private void CarregaProdutos(int idpedido)
        {

            PedidoProdutoBD bd = new PedidoProdutoBD();
            DataSet ds = bd.SelectAllByID(idpedido);
            GridView2.DataSource = ds.Tables[0].DefaultView;
            GridView2.DataBind();
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

            ProdutoBD clientebd = new ProdutoBD();
            DataSet clienteds = clientebd.SelectClientByID();
            ddlCliente.DataSource = clienteds.Tables[0].DefaultView;
            ddlCliente.DataTextField = "cli_nome";
            ddlCliente.DataValueField = "ped_id";
            ddlCliente.DataBind();

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
            btnIncluir.Focus();
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = 0;
            switch (e.CommandName)
            {
                case "Alterar":
                    codigo = Convert.ToInt32(e.CommandArgument);
                    Session["ID"] = codigo;
                    Response.Redirect("CadastrarPedProduto.aspx");
                    break;
                case "Excluir":
                    codigo = Convert.ToInt32(e.CommandArgument);
                    PedidoProdutoBD bd = new PedidoProdutoBD();
                    bd.Delete(codigo);
                    Carregar();
                    break;
                default:
                    break;
            }
        }

        protected void btnIncluir_Click(object sender, EventArgs e)
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
                    lblMensagem.Text = "Produto Incluso";

                    pedidoprodutobd.UpdateQuantidade(pedidoproduto.Quantidade, pedidoproduto.Produto.Id);

                    Carregar();
                    CarregaProdutos(Convert.ToInt32(Session["pedidoID"]));
                    break;
                case 1:
                    //Erro no banco de dados
                    lblMensagem.Text = "Não foi possível incluir o produto no pedido.";
                    break;
                case 2:
                    //Erro geral
                    lblMensagem.Text = "Não foi possível incluir o produto no pedido.";
                    break;
                default:
                    break;
            }
        }

        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            
            CarregaProdutos(Convert.ToInt32(Session["pedidoID"]));
            Response.Redirect("Orcamento.aspx");
           
        }

        protected void ddlProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ddlProduto.SelectedItem.Text != "Selecione um produto")
            {
                ProdutoBD bd = new ProdutoBD();
                Produto produto = bd.Select(Convert.ToInt32(ddlProduto.SelectedItem.Value));
                txtValorUnitario.Text = produto.ValorUnitario.ToString();
            }
        }

        protected void ddlCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}