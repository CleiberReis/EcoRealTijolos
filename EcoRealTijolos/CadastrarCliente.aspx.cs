using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace EcoRealTijolos
{
    public partial class CadastrarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Clientes";
                CarregaEstados();
                CarregaCidades();
                txtNome.Focus();
            }
        }

        private void LimparCidade()
        {
            //remove seleção do ddl
            for (int i = 0; i < ddlCidade.Items.Count; i++)
            {
                ddlCidade.Items[i].Selected = false;
            }
            //coloca o "Selecione" selecionado
            ddlCidade.Items[0].Selected = true;
        }

        private void LimparEstado()
        {
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
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;
            cliente.Logradouro = txtEndereco.Text;
            cliente.Estado = ddlEstado.Text;
            cliente.Cidade = ddlCidade.Text;


            ClienteBD bd = new ClienteBD();
            if (bd.Insert(cliente))
            {
                lblMensagem.Text = "Cliente cadastrado com sucesso";

                LimparCidade();
                LimparEstado();
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

        protected void txtEmail0_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {

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


    }
    
}