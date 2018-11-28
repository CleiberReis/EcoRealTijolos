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
    public partial class PrimeiroAcesso : System.Web.UI.Page
    {

        public string senhav;
        public string confsenha;
        public string senhafeita;
        public string zero = "0";


        protected void Page_Load(object sender, EventArgs e)
        {
            senhav = Session["senha"].ToString();
            UsuariosBD bd = new UsuariosBD();
            Usuarios usuario = bd.Select(Convert.ToInt32(Session["ID"]));

            senhafeita = usuario.Senha;
            zero = usuario.PriAcesso;

        }




        protected void btnSalvaEntra_Click(object sender, EventArgs e)
        {
            /*Usuarios usuarios = new Usuarios();
            usuarios.Senha = txtConfSenha.Text;
            usuarios.PriAcesso = "0";

            UsuariosBD bd = new UsuariosBD();
            Usuarios usuario = bd.Select(Convert.ToInt32(Session["ID"]));
            bd.Insert(usuarios);

            if (usuarios.Tipo == 0)
            {
                Response.Redirect("Index.aspx");
            }
            else
            {
                Response.Redirect("IndexUser.aspx");
            }*/



            //Login passando = new Login();
            //try
            //{
            //   passando.senha = senhav;
            //}
            //finally
            //{
            //  passando.Dispose();
            //}
            senhafeita = txtSenhav.Text.Trim();
            confsenha = txtConfSenha.Text.Trim();

            if (senhav == txtSenha1.Text && senhafeita == confsenha)
            {
                UsuariosBD bd = new UsuariosBD();
                Usuarios usuario = bd.Select(Convert.ToInt32(Session["ID"]));
                usuario.Senha = senhafeita;
                usuario.PriAcesso = "0";

                Response.Redirect("Index.aspx", true);
            }
        }
    }
}