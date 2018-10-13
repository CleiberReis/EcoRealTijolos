using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Persistencia;
using EcoRealTijolos.App_Code.Classes;

namespace EcoRealTijolos.Pages.Clientes
{
    public partial class AlterarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ClienteBD bd = new ClienteBD();
                Cliente cliente = bd.Select(Convert.ToInt32(Session["ID"]));
                txtNome.Text = cliente.Nome;
                txtCpf.Text = cliente.Cpf;
                txtTelefone.Text = cliente.Telefone;
                txtEmail.Text = cliente.Email;
            }
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            ClienteBD bd = new ClienteBD();
            Cliente cliente = bd.Select(Convert.ToInt32(Session["ID"]));
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;

            if (bd.Update(cliente))
            {
                lblMensagem.Text = "Cliente alterado com sucesso";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                txtNome.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }
    }
}