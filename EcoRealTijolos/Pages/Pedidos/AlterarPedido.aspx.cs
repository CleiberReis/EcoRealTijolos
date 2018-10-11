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
    public partial class AlterarPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PedidoBD bd = new PedidoBD();
                Pedido pedido = bd.Select(Convert.ToInt32(Session["ID"]));
                txtEndereco.Text = pedido.EnderecoEntrega.ToString();
                txtData.Text = pedido.Data.ToString();
                txtObsPedido.Text = pedido.Observacao;
            }
        }

        protected void BtnAlterar_Click(object sender, EventArgs e)
        {
            PedidoBD bd = new PedidoBD();
            Pedido pedido = bd.Select(Convert.ToInt32(Session["ID"]));
            pedido.EnderecoEntrega = Convert.ToString(txtEndereco.Text);
            pedido.Data = Convert.ToDateTime(txtData.Text);
            pedido.Observacao = Convert.ToString(txtObsPedido.Text);

            if (bd.Update(pedido))
            {
                lblMensagem.Text = "Pedido alterado com sucesso";
                txtEndereco.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao alterar.";
            }

        }
    }
}
