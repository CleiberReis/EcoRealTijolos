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
                txtBairro.Text = pedido.Bairro.ToString();
                txtNumero.Text = pedido.Numero.ToString();
                ddlCidade.Text = pedido.Estado;
                ddlEstado.Text = pedido.Cidade;
                txtData.Text = pedido.Data.ToString();
                txtObsPedido.Text = pedido.Observacao;

                CarregaEstados();
                CarregaCidades();
                txtLogradouro.Focus();
            }
        }

        private void CarregaEstados()
        {
            EstadoBD bd = new EstadoBD();
            DataSet ds = bd.SelectAll();
            ddlEstado.DataSource = ds.Tables[0].DefaultView;
            ddlEstado.DataTextField = "nome";
            ddlEstado.DataValueField = "nome";
            ddlEstado.DataBind();
            ddlEstado.Items.Insert(0, "Selecione um Estado");
        }

        private void CarregaCidades()
        {
            CidadeBD bd = new CidadeBD();
            DataSet ds = bd.SelectAll();
            ddlCidade.DataSource = ds.Tables[0].DefaultView;
            ddlCidade.DataTextField = "nome";
            ddlCidade.DataValueField = "nome";
            ddlCidade.DataBind();
            ddlCidade.Items.Insert(0, "Selecione uma Cidade");
        }


        protected void BtnAlterar_Click(object sender, EventArgs e)
        {
            PedidoBD bd = new PedidoBD();
            Pedido pedido = bd.Select(Convert.ToInt32(Session["ID"]));
            pedido.Data = Convert.ToDateTime(txtData.Text);
            pedido.Logradouro = Convert.ToString(txtLogradouro.Text);
            pedido.Observacao = Convert.ToString(txtObsPedido.Text);
            pedido.Cidade = ddlCidade.Text;
            pedido.Estado = ddlEstado.Text;
            pedido.Bairro = Convert.ToString(txtBairro.Text);
            pedido.Numero = Convert.ToString(txtNumero.Text);

            if (bd.Update(pedido))
            {
                lblMensagem.Text = "Pedido alterado com sucesso";
                txtLogradouro.Text = "";
                txtBairro.Text = "";
                txtNumero.Text = "";
                ddlCidade.Text = "";
                ddlEstado.Text = "";
                txtData.Text = "";
                txtObsPedido.Text = "";
                txtLogradouro.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao alterar.";
            }

        }
    }
}