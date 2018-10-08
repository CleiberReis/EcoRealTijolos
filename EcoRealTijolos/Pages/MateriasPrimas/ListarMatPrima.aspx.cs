using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos.Pages.MateriaPrima
{
    public partial class ListarMatPrima : System.Web.UI.Page
    {
        private void Carrega()
        {
            MateriaPrimaBD bd = new MateriaPrimaBD();
            DataSet ds = bd.SelectAll();
            TabelaMatPrima.DataSource = ds.Tables[0].DefaultView;
            TabelaMatPrima.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Carrega();
        }
    }
}