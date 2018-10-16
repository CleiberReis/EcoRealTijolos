using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos.Pages.RefugoMateriaPrima
{
    public partial class ListarRefugoMateria : System.Web.UI.Page
    {
        private void Carrega()
        {
            PerdaMateriaBD bd = new PerdaMateriaBD();
            DataSet ds = bd.SelectAll();
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Carrega();

                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Estoque - Matéria Prima";
            }

        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = 0;
            switch (e.CommandName)
            {
                case "Alterar":
                    codigo = Convert.ToInt32(e.CommandArgument);
                    Session["ID"] = codigo;
                    Response.Redirect("AlterarRefugoMateria.aspx");
                    break;
                case "Deletar":
                    codigo = Convert.ToInt32(e.CommandArgument);
                    PerdaMateriaBD bd = new PerdaMateriaBD();
                    bd.Delete(codigo);
                    Carrega();
                    break;
                default:
                    break;
            }
        }
        protected void BtnNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarRefugoMateria.aspx", false);
        }
    }
}