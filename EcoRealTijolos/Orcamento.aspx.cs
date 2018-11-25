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
    public partial class Orcamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Pedidos";
                Carregar();
                CarregaProdutos(Convert.ToInt32(Session["pedidoID"]));
            }
        }

        private void CarregaProdutos(int idpedido)
        {

            PedidoProdutoBD bd = new PedidoProdutoBD();
            DataSet ds = bd.SelectProductID(idpedido);
            Repeater1.DataSource = ds.Tables[0].DefaultView;
            Repeater1.DataBind();
        }

        private void Carregar()
        {
            PedidoBD pedidobd = new PedidoBD();
            DataSet pedidods = pedidobd.SelectAllPedidos();
            ddlPedido.DataSource = pedidods.Tables[0].DefaultView;
            ddlPedido.DataTextField = "ped_id";
            ddlPedido.DataValueField = "ped_id";
            ddlPedido.DataBind();

            ProdutoBD clientebd = new ProdutoBD();
            DataSet clienteds = clientebd.SelectClientByID();
            ddlCliente.DataSource = clienteds.Tables[0].DefaultView;
            ddlCliente.DataTextField = "cli_nome";
            ddlCliente.DataValueField = "ped_id";
            ddlCliente.DataBind();
        }
        protected void ddlPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pedido = Convert.ToInt32(ddlPedido.SelectedItem.Value);
            PedidoBD bd = new PedidoBD();
            DataSet ds = bd.SelectAll();
        }

        protected void btnOrcamento_Click(object sender, EventArgs e)
        {
            int pedidoTotal = Convert.ToInt32(ddlPedido.SelectedItem.Value);
            PedidoProdutoBD db = new PedidoProdutoBD();
            double total = db.GetSomaTotal(pedidoTotal);
            CarregaProdutos(Convert.ToInt32(Session["pedidoID"]));
            lblTotal.Text = "Valor Final Total " + total.ToString("C2");

            //PedidoProdutoBD bd = new PedidoProdutoBD();
            //DataSet ds = bd.SelectProductID(pedidoTotal);
            //Repeater1.DataSource = ds.Tables[0].DefaultView;
            //Repeater1.DataBind();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}