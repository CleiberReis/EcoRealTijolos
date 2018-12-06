﻿using System;
using System.Collections.Generic;
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
            int codigo = Convert.ToInt32(Session["ID"]);
            UsuariosBD bd = new UsuariosBD();
            Usuarios usuarios = bd.Select(codigo);
            if (!IsAdministrador(usuarios.Tipo))

            {
                Response.Redirect("../Erro/AcessoNegado.aspx");
            }
            else
            {
                lblTitulo.Text = "Bem vindo (Administrador) : " + usuarios.Nome;
            }

        }
        private bool IsAdministrador(int tipo)
        {
            bool retorno = false; if (tipo == 0) { retorno = true; }
            return retorno;

        }

        protected void lbSair_Click(object sender, EventArgs e)
        {

            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            Response.Redirect("Login.aspx");


        }
    }
}