using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /* int codigo = Convert.ToInt32(Session["ID"]);
            UsuariosBD bd = new UsuariosBD();
            Usuarios usuarios = bd.Select(codigo);
            if (!IsAdministrador(usuarios.Tipo))

            {
                Response.Redirect("AcessoNegado.aspx");
            }
            else
            {
                lblTitulo.Text = "" + usuarios.Nome;
            }*/
            CarregaAlerta();
        }

        private void CarregaAlerta()
        {
            ProdutoBD produtoBD = new ProdutoBD();
            DataSet ds = produtoBD.GetEstoqueMinimo();

            int quantidadeLinhas = ds.Tables[0].Rows.Count;
            string produtos = "";

            for (int i = 0; i < quantidadeLinhas; i++)
            {
                DataRow dr = ds.Tables[0].Rows[i];
                string nome = Convert.ToString(dr["prod_nome"]);
                produtos = produtos + nome + ",";
            }
            lblAviso.Text = "Produtos abaixo do estoque mínimo: " + produtos;

            MateriaPrimaBD materiaPrimaBD = new MateriaPrimaBD();
            DataSet dst = materiaPrimaBD.GetEstoqueMin();
            int quantidadeLinha = dst.Tables[0].Rows.Count;
            string materia = "";

            for (int i = 0; i < quantidadeLinha; i++)
            {
                DataRow dr = dst.Tables[0].Rows[i];
                string nome = Convert.ToString(dr["mat_nome"]);
                materia = materia + nome + ",";
            }
            lblAvisoMateria.Text = "Matéria Prima abaixo do estoque mínimo: " + materia;
        }

       /* private bool IsAdministrador(int tipo)
        {
            bool retorno = false;
            if (tipo == 0)
            {
                retorno = true;
            }
            return retorno;
        }*/

        protected void lbSair_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }
    }
}