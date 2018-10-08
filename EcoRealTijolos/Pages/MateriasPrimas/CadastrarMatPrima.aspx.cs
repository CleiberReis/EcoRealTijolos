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
    public partial class CadastrarMatPrima : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            /*MateriaPrima materia = new MateriaPrima();
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
            }*/
        }
    }
}