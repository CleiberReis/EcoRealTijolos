﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        int value1;
        int value2;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Usuários";
            }
        }

        protected void CbxAdmSim_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxAdmSim.Checked)
            {
                value1 = 0; //administrador
            }
            else
            {
                value1 = 1; //usuário comum
            }
        }

        protected void CbxAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxAtivo.Checked)
            {
                value2 = 0; //ativo
            }
            else
            {
                value2 = 1; //inativo
            }
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Random senaRandomica = new Random();
            int senhaint = senaRandomica.Next(1, 999999);
            string senha = senhaint.ToString();

            Usuarios usuarios = new Usuarios();
            usuarios.Nome = txtUser.Text;
            usuarios.Email = txtEmail.Text;
            usuarios.PriAcesso = "1";
            //Funcoes.enviaEmail(" ecoreal925@gmail.com", txtEmail.Text, "Bem vindo", senha);
            if (CbxAdmSim.Checked)
            {
                usuarios.Tipo = 0;
            } else
            {
                usuarios.Tipo = 1;
            }
            
            usuarios.Login = txtLogin.Text;
            if (CbxAtivo.Checked)
            {
                usuarios.Ativo = 0;
            }
            else
            {
                usuarios.Ativo = 1;
            }
            
            usuarios.Senha = senha;

            UsuariosBD bd = new UsuariosBD();
            if (bd.Insert(usuarios))
            {
                lblMensagem.Text = "Usuário cadastrado com sucesso";

                txtUser.Text = "";
                txtEmail.Text = "";
                txtLogin.Text = "";

                txtUser.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }

        protected void BtnLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarUsuarios.aspx", false);
        }
    }
}