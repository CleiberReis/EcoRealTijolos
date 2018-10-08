using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos.Pages.MateriaPrima
{
    public partial class CadastrarMatPrima : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            MateriaPrima materia = new MateriaPrima();
            materia.Nome = txtNomeMateria.Text;
            materia.Quantidade = Convert.ToUInt16(txtQuantiMateria.Text);

            MateriaPrimaBD bd = new MateriaPrimaBD();
            if (bd.Insert(materia))
            {
                lblMensagem.Text = "Matéria Prima cadastrada com sucesso";

                txtNomeMateria.Text = "";
                txtQuantiMateria.Text = "";
                txtNomeMateria.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar";
            }
        }
    }
}