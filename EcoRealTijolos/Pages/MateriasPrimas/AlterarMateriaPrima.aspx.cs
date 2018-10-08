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
    public partial class AlterarMateriaPrima : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MateriaPrimaBD bd = new MateriaPrimaBD();
                MateriaPrima materia = bd.Select(Convert.ToInt32(Session["ID"]));
                txtNomeMateria.Text = materia.Nome;
                txtQuantidadeMateria.Text = materia.Quantidade;
            }
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            MateriaPrimaBD bd = new MateriaPrimaBD();
            MateriaPrima materia = bd.Select(Convert.ToInt32(Session["ID"]));
            materia.Nome = txtNomeMateria.Text;
            materia.Quantidade = txtQuantidadeMateria.Text;

            if (bd.Update(materia))
            {
                lblMensagem.Text = "Matéria Prima alterada com sucesso";
                txtNomeMateria.Text = "";
                txtQuantidadeMateria.Text = "";
                txtNomeMateria.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }
    }
}