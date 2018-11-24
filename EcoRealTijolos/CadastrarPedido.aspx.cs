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
    public partial class CadastrarPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Pedidos";
                CarregaEstados();
                CarregaCidades();
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
            ddlCliente.Items.Insert(0, "Selecione um cliente");
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

        private void LimparCampos()
        {
            txtLogradouro.Text = "";
            txtObsPedido.Text = "";
            //remove seleção do ddl
            for (int i = 0; i < ddlCliente.Items.Count; i++)
            {
                ddlCliente.Items[i].Selected = false;
            }
            //coloca o "Selecione" selecionado
            ddlCliente.Items[0].Selected = true;

            //remove seleção do ddl
            for (int i = 0; i < ddlCidade.Items.Count; i++)
            {
                ddlCidade.Items[i].Selected = false;
            }
            //coloca o "Selecione" selecionado
            ddlCidade.Items[0].Selected = true;

            //remove seleção do ddl
            for (int i = 0; i < ddlEstado.Items.Count; i++)
            {
                ddlEstado.Items[i].Selected = false;
            }
            //coloca o "Selecione" selecionado
            ddlEstado.Items[0].Selected = true;
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            ClienteBD clienteBD = new ClienteBD();
            Cliente cliente = clienteBD.Select(Convert.ToInt32(ddlCliente.SelectedItem.Value));

            Pedido pedido = new Pedido();

            pedido.EnderecoEntrega = Convert.ToString(txtLogradouro.Text);
            pedido.Data = Convert.ToDateTime(txtData.Text);
            pedido.Observacao = Convert.ToString(txtObsPedido.Text);

            pedido.Cliente = cliente;

            PedidoBD pedidobd = new PedidoBD();
            int retorno = pedidobd.Insert(pedido);
            int pedidoID = pedidobd.GetID(pedido.Data, pedido.Cliente.Id, pedido.EnderecoEntrega, pedido.Observacao);
            Session["pedidoID"] = pedidoID;
            Response.Redirect("CadastrarPedProduto.aspx");

            switch (retorno)
            {
                case 0:

                    LimparCampos();
                    ddlCliente.Focus();
                    lblMensagem.Text = "Pedido salvo com sucesso";
                    Response.Redirect("CadastrarPedProduto.aspx");
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