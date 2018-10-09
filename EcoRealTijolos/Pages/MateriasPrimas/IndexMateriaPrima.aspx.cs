using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcoRealTijolos.Pages.MateriasPrimas
{
    public partial class IndexMateriaPrima : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarMateriaPrima.aspx");
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}