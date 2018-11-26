using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcoRealTijolos
{
    public partial class RelatorioMateria : System.Web.UI.Page
    {

        private void Carrega()
        {
            MateriaPrimaBD bd = new MateriaPrimaBD();
            DataSet ds = bd.SelectAll();
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Relátorio de Matéria Prima";

                Carrega();
                Calculo();
                CapacidadeProducao();
            }
        }

        private void Calculo()
        {
            MateriaPrimaBD bd = new MateriaPrimaBD();

            MateriaPrima mp1 = bd.Select(1);
            double qnt1 = (mp1.Quantidade * 40) / 20;
            txtCimento.Text = qnt1.ToString() + " - Traços";

            MateriaPrima mp2 = bd.Select(2);
            double qnt2 = (mp2.Quantidade * 1000) / 26;
            txtAreia.Text = qnt2.ToString() + " - Traços";
            
            MateriaPrima mp3 = bd.Select(3);
            double qnt3 = (mp3.Quantidade * 1000) / 78;
            txtTerra.Text = qnt3.ToString() + " - Traços";
        }

        private void CapacidadeProducao()
        {
            MateriaPrimaBD bd = new MateriaPrimaBD();

            MateriaPrima mp1 = bd.Select(1);
            double qnt1 = ((mp1.Quantidade * 40) / 20) * 64;
            txtCpCimento.Text = qnt1.ToString() + " - Unidades";

            MateriaPrima mp2 = bd.Select(2);
            double qnt2 = ((mp2.Quantidade * 1000) / 26) * 64;
            txtCpAreia.Text = qnt2.ToString() + " - Unidades";

            MateriaPrima mp3 = bd.Select(3);
            double qnt3 = ((mp3.Quantidade * 1000) / 78) * 64;
            txtCpTerra.Text = qnt3.ToString() + " - Unidades";
        }
    }
}