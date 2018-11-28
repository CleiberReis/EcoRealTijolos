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

       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UsuariosBD bd = new UsuariosBD();
                Usuarios usuario = bd.Select(Convert.ToInt32(Session["ID"]));
                txtConfSenha.Text = usuario.Senha;
                usuario.PriAcesso = "0";
                
            }
            
            

        }
        



        protected void btnSalvaEntra_Click(object sender, EventArgs e)
        {
            
            UsuariosBD bd = new UsuariosBD();
            Usuarios usuario = bd.Select(Convert.ToInt32(Session["ID"]));
            usuario.Senha = txtSenhav.Text;
            if (txtSenhav.Text == txtConfSenha.Text)
            {
                txtConfSenha.Text = usuario.Senha;
            }
            usuario.PriAcesso = "0";
            //bd.Update(usuario);
            if (bd.Update(usuario))
            {
                if (usuario.Tipo == 0)
                {
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    Response.Redirect("IndexUser.aspx");
                }
            }


            //Login passando = new Login();
            //try
            //{
            //   passando.senha = senhav;
            //}
            //finally
            //{
            //  passando.Dispose();
            //}
            
        }
    }
}