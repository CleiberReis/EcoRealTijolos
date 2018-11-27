using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool IsPreenchido(string str)
        {
            bool retorno = false;
            if (str != string.Empty)
            {
                retorno = true;
            }
            return retorno;
        }
        private bool UsuarioEncontrado(Usuarios usuario)
        {
            bool retorno = false;
            if (usuario != null)
            {
                retorno = true;
            }
            return retorno;
        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string senha = txtSenha.Text.Trim();
            if (!IsPreenchido(login))
            {
                lblMensagem.Text = "Preencha o login";
                txtLogin.Focus();
                return;
            }
            if (!IsPreenchido(senha))
            {
                lblMensagem.Text = "Preencha a senha";
                txtSenha.Focus();
                return;
            }
            UsuariosBD bd = new UsuariosBD();
            Usuarios usuarios = new Usuarios();
            usuarios = bd.Autentica(login, senha);
            if (!UsuarioEncontrado(usuarios))
            {
                lblMensagem.Text = "Usuário não encontrado";
                txtLogin.Focus();
                return;
            }
            Session["ID"] = usuarios.Codigo;
            switch (usuarios.Tipo)
            {
                case 0:
                    Response.Redirect("Index.aspx");
                    break;
                case 1:
                    Response.Redirect("IndexUser.aspx");
                    break;
                default:
                    break;
            }

        }
    }
    

}