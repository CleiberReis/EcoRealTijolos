using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Persistencia;
using EcoRealTijolos.App_Code.Classes;

namespace EcoRealTijolos.Pages.MateriasPrimas
{
    /*public partial class AlterarMateriaPrima : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MateriaPrimaBD bd = new MateriaPrimaBD();
                MateriaPrima materia = bd.Select(Convert.ToInt32(Session["ID"]));
                materia.Quantidade = Convert.ToInt32(txtQuantidadeMateria.Text);

                CarregaMateriaPrima();
                ddlNomeMateria.Focus();
            }
        }
        private void CarregaMateriaPrima()
        {
            MateriaPrimaBD bd = new MateriaPrimaBD();
            DataSet ds = bd.SelectAll();
            ddlNomeMateria.DataSource = ds.Tables[0].DefaultView;
            ddlNomeMateria.DataTextField = "mat_nome";
            ddlNomeMateria.DataValueField = "mat_id";
            ddlNomeMateria.DataBind();
            ddlNomeMateria.Items.Insert(0, "Selecione");
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            MateriaPrimaBD bd = new MateriaPrimaBD();
            MateriaPrima materia = bd.Select(Convert.ToInt32(Session["ID"]));
            materia.Quantidade = Convert.ToInt32(txtQuantidadeMateria.Text);

            if (bd.Update(materia))
            {
                lblMensagem.Text = "Matéria Prima alterada com sucesso";
                txtQuantidadeMateria.Text = "";
                txtQuantidadeMateria.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }
    }*/
}