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
            }
        }

        private void Carregar()
        {
            PedidoBD pedidobd = new PedidoBD();
            DataSet pedidods = pedidobd.SelectAllPedidos();
            ddlPedido.DataSource = pedidods.Tables[0].DefaultView;
            ddlPedido.DataTextField = "ped_id";
            ddlPedido.DataValueField = "ped_id";
            ddlPedido.DataBind();
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
            PedidoBD bd = new PedidoBD();
            DataSet ds = bd.SelectAll();
            PedidoProdutoBD db = new PedidoProdutoBD();
            double total = db.GetSomaTotal(pedidoTotal);
            lblTotal.Text = total.ToString("C2");

            PedidoProdutoBD pedprodbd = new PedidoProdutoBD();
            DataSet pedprodds = pedprodbd.SelectAll();
            GridView1.DataSource = pedprodds.Tables[0].DefaultView;
            GridView1.DataBind();
        }
    }
}