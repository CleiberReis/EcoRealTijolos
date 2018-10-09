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
    public partial class CadastrarPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregaClientes();
                ddlCliente.Focus();
            }
        }

        private void CarregaClientes()
        {
            ClienteBD bd = new ClienteBD();
            DataSet ds = bd.SelectAll();
            ddlCliente.DataSource = ds.Tables[0].DefaultView;
            ddlCliente.DataTextField = "cli_nome";
            ddlCliente.DataValueField = "cli_id";
            ddlCliente.DataBind();
            ddlCliente.Items.Insert(0, "Selecione");
        }

        private void LimparCampos()
        {
            txtCep.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtEstado.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtObsPedido.Text = "";
            //remove seleção do ddl
            for (int i = 0; i < ddlCliente.Items.Count; i++)
            {
                ddlCliente.Items[i].Selected = false;
            }
            //coloca o "Selecione" selecionado
            ddlCliente.Items[0].Selected = true;
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            ClienteBD clienteBD = new ClienteBD();
            Cliente cliente = clienteBD.Select(Convert.ToInt32(ddlCliente.SelectedItem.Value));

            Pedido pedido = new Pedido();
            pedido.Cep = Convert.ToString(txtCep.Text);
            pedido.Rua = Convert.ToString(txtRua.Text);
            pedido.Numero = Convert.ToString(txtNumero.Text);
            pedido.Estado = Convert.ToString(txtEstado.Text);
            pedido.Cidade = Convert.ToString(txtCidade.Text);
            pedido.Complemento = Convert.ToString(txtComplemento.Text);
            pedido.Data = Convert.ToDateTime(calPedido);
            pedido.Observacao = Convert.ToString(txtObsPedido.Text);
            pedido.Cliente = pedido;

            PedidoBD pedidobd = new PedidoBD();
            int retorno = pedidobd.Insert(pedido);
            switch (retorno)
            {
                case 0:
                    LimparCampos();
                    ddlCliente.Focus();
                    lblMensagem.Text = "Pedido salvo com sucesso";
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