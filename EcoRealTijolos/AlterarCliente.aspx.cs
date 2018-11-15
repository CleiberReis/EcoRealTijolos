using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Persistencia;
using EcoRealTijolos.App_Code.Classes;

namespace EcoRealTijolos
{
    public partial class AlterarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Clientes";


                ClienteBD bd = new ClienteBD();
                Cliente cliente = bd.Select(Convert.ToInt32(Session["ID"]));
                txtNome.Text = cliente.Nome;
                txtCpf.Text = cliente.Cpf;
                txtTelefone.Text = cliente.Telefone;
                txtEmail.Text = cliente.Email;
                txtEndereco.Text = cliente.Logradouro;
                ddlEstado.Text = cliente.Estado;
                ddlCidade.Text = cliente.Cidade;

                CarregaEstados();
                CarregaCidades();
                ddlEstado.Focus();

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


        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            ClienteBD bd = new ClienteBD();
            Cliente cliente = bd.Select(Convert.ToInt32(Session["ID"]));
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;
            cliente.Logradouro = txtEndereco.Text;
            cliente.Estado = ddlEstado.Text;
            cliente.Cidade = ddlCidade.Text;

            if (bd.Update(cliente))
            {
                lblMensagem.Text = "Cliente alterado com sucesso";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                txtEndereco.Text = "";
                

                txtNome.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }

        protected void BtnLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarCliente.aspx", false);
        }
    }
}