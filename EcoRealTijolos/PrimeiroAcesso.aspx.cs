using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcoRealTijolos
{
    public partial class PrimeiroAcesso : System.Web.UI.Page
    {
        Login senha = new Login();
        string senhav;
        string confsenha;
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            senhav = txtSenhav.Text;
            confsenha = txtConfSenha.Text;

            if (senhav == Login.senha && )
            {

            }
        }
    }
}