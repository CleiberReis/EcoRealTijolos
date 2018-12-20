using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;


namespace EcoRealTijolos
{
    public partial class ListarPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        private void Carregar()
        {
            //PedidoBD bd = new PedidoBD();
            //DataSet ds = bd.SelectAll();
            //GridView1.DataSource = ds.Tables[0].DefaultView;
            //GridView1.DataBind();

            PedidoBD pedidobd = new PedidoBD();
            DataSet pedidods = pedidobd.SelectAll();
            Repeater1.DataSource = pedidods.Tables[0].DefaultView;
            Repeater1.DataBind();
        }
        //protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    int codigo = 0;
        //    switch (e.CommandName)
        //    {
        //        case "Alterar":
        //            codigo = Convert.ToInt32(e.CommandArgument);
        //            Session["ID"] = codigo;
        //            Response.Redirect("AlterarPedido.aspx");
        //            break;
        //        case "Excluir":
        //            codigo = Convert.ToInt32(e.CommandArgument);
        //            PedidoBD bd = new PedidoBD();
        //            bd.Delete(codigo);
        //            Carregar();
        //            break;
        //        default:
        //            break;
        //    }
        //}

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int codigo = 0;
            switch (e.CommandName)
            {
                case "alterar":
                    codigo = Convert.ToInt32(e.CommandArgument);
                    Session["ID"] = codigo;
                    Response.Redirect("AlterarPedido.aspx");
                    break;
                case "excluir":
                    codigo = Convert.ToInt32(e.CommandArgument);
                    PedidoBD bd = new PedidoBD();
                    bd.Delete(codigo);
                    Carregar();
                    break;
                default:
                    break;
            }
            //if (e.CommandName == "alterar")
            //{
            //    int codigo = 0;
            //    codigo = Convert.ToInt32(e.CommandArgument);
            //    Session["ID"] = codigo;
            //    Response.Redirect("AlterarPedido.aspx");
            //}
            //else if(e.CommandName == "excluir")
        }
    }
}
