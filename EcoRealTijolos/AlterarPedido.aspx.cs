using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos
{
    public partial class AlterarPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Pedidos";
                PedidoBD bd = new PedidoBD();
                Pedido pedido = bd.Select(Convert.ToInt32(Session["ID"]));
                txtLogradouro.Text = pedido.Logradouro.ToString();
                txtBairro.Text = pedido.Logradouro.ToString();
                txtNumero.Text = pedido.Logradouro.ToString();
                txtData.Text = pedido.Data.ToString();
                txtObs.Text = pedido.Observacao;
            }
        }

        protected void BtnAlterar_Click(object sender, EventArgs e)
        {
            PedidoBD bd = new PedidoBD();
            Pedido pedido = bd.Select(Convert.ToInt32(Session["ID"]));
            pedido.Data = Convert.ToDateTime(txtData.Text);
            pedido.Logradouro = Convert.ToString(txtLogradouro.Text);
            pedido.Observacao = Convert.ToString(txtObs.Text);
            pedido.Cidade = Convert.ToString(ddlCidade.Text);
            pedido.Estado = Convert.ToString(ddlEstado.Text);
            pedido.Bairro = Convert.ToString(txtBairro.Text);
            pedido.Numero = Convert.ToString(txtNumero.Text);

            if (bd.Update(pedido))
            {
                lblMensagem.Text = "Pedido alterado com sucesso";
                txtLogradouro.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao alterar.";
            }

        }
    }
}