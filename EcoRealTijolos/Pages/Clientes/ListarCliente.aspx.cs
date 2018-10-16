using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Persistencia;
using System.Data;

namespace EcoRealTijolos.Pages.Clientes
{
    public partial class ListarCliente : System.Web.UI.Page
    {

        private void Carrega()
        {
            ClienteBD bd = new ClienteBD();
            DataSet ds = bd.SelectAll();
            GridView1.DataSource = ds.Tables[0].DefaultView;

            EstadoBD bd2 = new EstadoBD();
            DataSet ds2 = bd.SelectAll();
            GridView1.DataSource = ds.Tables[0].DefaultView;

            CidadeBD bd3 = new CidadeBD();
            DataSet ds3 = bd.SelectAll();
            GridView1.DataSource = ds.Tables[0].DefaultView;


            GridView1.DataBind();

            Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
            lblOptionMenu.Text = "Listar - Clientes";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Carrega();

                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Clientes";
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
                    Response.Redirect("AlterarCliente.aspx");
                    break;
                case "Deletar":
                    codigo = Convert.ToInt32(e.CommandArgument);
                    ClienteBD bd = new ClienteBD();
                    bd.Delete(codigo);
                    Carrega();
                    break;
                default:
                    break;
            }
        }

        protected void BtnNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarCliente.aspx", false);
        }
    }
}