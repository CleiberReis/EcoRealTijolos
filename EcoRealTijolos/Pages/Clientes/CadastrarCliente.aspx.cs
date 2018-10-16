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

namespace EcoRealTijolos.Pages.Clientes
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
                ddlEstado.Focus();
            }
        }

        
        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;
            cliente.Estado = ddlEstado.Text;
            cliente.Cidade = ddlCidade.Text;


            ClienteBD bd = new ClienteBD();
            if (bd.Insert(cliente))
            {
                lblMensagem.Text = "Cliente cadastrado com sucesso";

                txtNome.Text = "";
                txtCpf.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                ddlEstado.Text = "";
                ddlCidade.Text = "";

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
            ddlCidade.Items.Insert(0, "Selecione ua Cidade");
        }


    }
    
}