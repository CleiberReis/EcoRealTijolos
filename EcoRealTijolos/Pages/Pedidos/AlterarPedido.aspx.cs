using System;
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
                txtCep.Text = pedido.Cep;
                txtRua.Text = pedido.Rua;
                txtNumero.Text = pedido.Numero;
                txtEstado.Text = pedido.Estado;
                txtCidade.Text = pedido.Cidade;
                txtComplemento.Text = pedido.Complemento;
                txtData.Text = pedido.Data.ToString();
                txtObsPedido.Text = pedido.Observacao;
            }
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            PedidoBD bd = new PedidoBD();
            Pedido pedido = bd.Select(Convert.ToInt32(Session["ID"]));
            pedido.Cep = Convert.ToString(txtCep.Text);
            pedido.Rua = Convert.ToString(txtRua.Text);
            pedido.Numero = Convert.ToString(txtNumero.Text);
            pedido.Estado = Convert.ToString(txtEstado.Text);
            pedido.Cidade = Convert.ToString(txtCidade.Text);
            pedido.Complemento = Convert.ToString(txtComplemento.Text);
            pedido.Data = Convert.ToDateTime(txtData.Text);
            pedido.Observacao = Convert.ToString(txtObsPedido.Text);

            if (bd.Update(pedido))
            {
                lblMensagem.Text = "Pedido alterado com sucesso";
                txtCep.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao alterar.";
            }

        }
    }
}
