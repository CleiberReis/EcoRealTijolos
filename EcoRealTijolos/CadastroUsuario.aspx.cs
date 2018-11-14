using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Usuários";
            }
        }

        protected void cbxAdmSim_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAdmSim.Checked)
            {

            }
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Nome = txtNome.Text;
            usuarios.Email = txtEmail.Text;
            usuarios.Tipo = cbxAdmSim.Text;
            usuarios.Login = txtLogin.Text;
            usuarios.Senha = txtSenha.Text;
            usuarios.Ativo = cbxAtivo.Text;


            UsuariosBD bd = new UsuariosBD();
            if (bd.Insert(usuarios))
            {
                lblMensagem.Text = "Usuário cadastrado com sucesso";

                txtNome.Text = "";
                txtEmail.Text = "";
                txtTelefone.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";

                txtNome.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }
    }
}