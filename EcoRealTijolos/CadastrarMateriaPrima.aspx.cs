using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos
{
    public partial class CadastrarMateriaPrima : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Estoque - Matéria Prima";

            }
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            MateriaPrima materia = new MateriaPrima();
            materia.Nome = txtNomeMateria.Text;
            materia.Quantidade = Convert.ToInt32(txtQuantidadeMateria.Text);

            MateriaPrimaBD bd = new MateriaPrimaBD();
            if (bd.Insert(materia))
            {
                lblMensagem.Text = "Matéria Prima cadastrada com sucesso";

                txtNomeMateria.Text = "";
                txtQuantidadeMateria.Text = "";
                txtNomeMateria.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao Salvar";
            }
        }

        protected void BtnLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarMateriaPrima.aspx", false);
        }

        protected void BtnIncluirPerda_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarRefugoMateria.aspx", false);
        }
    }
}