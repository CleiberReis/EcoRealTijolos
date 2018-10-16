﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos.Pages.RefugoMateriaPrima
{
    public partial class CadastrarRefugoMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Estoque - Matéria Prima";

                CarregaMateria();
                ddlNomeMateria.Focus();
            }
        }
        private void CarregaMateria()
        {
            MateriaPrimaBD bd = new MateriaPrimaBD();
            DataSet ds = bd.SelectAll();
            ddlNomeMateria.DataSource = ds.Tables[0].DefaultView;
            ddlNomeMateria.DataTextField = "mat_nome";
            ddlNomeMateria.DataValueField = "mat_id";
            ddlNomeMateria.DataBind();
            ddlNomeMateria.Items.Insert(0, "Selecione:");
        }
        private void LimparCampos()
        {
            txtQuantidadePerda.Text = "";
            txtObservacao.Text = "";
            //remove seleção do ddl
            for (int i = 0; i < ddlNomeMateria.Items.Count; i++)
            {
                ddlNomeMateria.Items[i].Selected = false;
            }
            //coloca o "Selecione" selecionado
            ddlNomeMateria.Items[0].Selected = true;
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            MateriaPrimaBD materiaBD = new MateriaPrimaBD();
            MateriaPrima materia = materiaBD.Select(Convert.ToInt32(ddlNomeMateria.SelectedItem.Value));

            PerdaMateria perda = new PerdaMateria();

            perda.Quantidade = Convert.ToInt32(txtQuantidadePerda.Text);
            perda.Observacao = Convert.ToString(txtObservacao.Text);

            perda.MateriaPrima = materia;

            PerdaMateriaBD perdaMateriaBD = new PerdaMateriaBD();
            int retorno = perdaMateriaBD.Insert(perda);
            switch (retorno)
            {
                case 0:

                    LimparCampos();
                    ddlNomeMateria.Focus();
                    lblMensagem.Text = "Refugo de Matéria Prima adicionado";
                    break;
                case 1:
                    //Erro no banco de dados
                    lblMensagem.Text = "Não foi possível inserir o refugo.";
                    break;
                case 2:
                    //Erro geral
                    lblMensagem.Text = "Não foi possível inserir o refugo.";
                    break;
                default:
                    break;
            }
        }

        protected void BtnVoltarLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("../MateriasPrimas/CadastrarMateriaPrima.aspx", false);
        }
    }
}