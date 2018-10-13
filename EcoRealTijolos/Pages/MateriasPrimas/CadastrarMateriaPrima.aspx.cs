using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos.Pages.MateriasPrimas
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

        [WebMethod]
        public static List<MateriaPrima> ListarMateriaPrima()
        {
            List<MateriaPrima> Lista = null;
            try
            {
                Lista = MateriaPrimaBD.getInstance().ListarMateriaPrima();
            }
            catch (Exception ex)
            {
                Lista = new List<MateriaPrima>();
            }
            return Lista;
        }

        [WebMethod]
        public static bool AtualizarDadosMateria(String nome, String quantidade)
        {
            MateriaPrima objPaciente = new MateriaPrima()
            {
                Nome = nome,
                Quantidade = Convert.ToInt32(quantidade)
            };

            bool ok = MateriaPrimaBD.getInstance().Atualizar(objPaciente);
            return ok;
        }

        [WebMethod]
        public static bool ExcluirDadosMateria(String id)
        {
            Int32 idMateria = Convert.ToInt32(id);

            bool ok = MateriaPrimaBD.getInstance().Excluir(idMateria);

            return ok;

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
    }
}