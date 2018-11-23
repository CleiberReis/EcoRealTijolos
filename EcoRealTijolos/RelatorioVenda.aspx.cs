using EcoRealTijolos.App_Code.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcoRealTijolos
{
    public partial class RelatorioVenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label lblOptionMenu = Master.FindControl("lblOptionMenu") as Label;
                lblOptionMenu.Text = "Relátorio de Vendas";

                Carrega();
            }
        }

        private void Carrega()
        {
            PedidoBD bd = new PedidoBD();
            DataSet ds = bd.SelectAllGrafico();

            string dados = "";
            //varre linhas do dataset
            dados = dados + "['Quantidade de Clientes', 'Quantidade de Pedidos'],";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dr = ds.Tables[0].Rows[i];

                int qntCli = Convert.ToInt32(dr["Quantidade de clientes"]);
                int qntPed = Convert.ToInt32(dr["Quantidade de Pedidos"]);

                dados = dados + "['" + qntCli + "', " + qntPed + "],";

            }

            string grafico = "";
            grafico = grafico + "<script type='text/javascript'>";
            grafico = grafico + "google.load('visualization', '1', {packages:['corechart']});";
            grafico = grafico + "function drawChart() {";
            grafico = grafico + "var data = google.visualization.arrayToDataTable([";
            grafico = grafico + dados;
            grafico = grafico + "]);";
            grafico = grafico + "var options = {";
            grafico = grafico + "title: 'Pedidos realizados',";
            grafico = grafico + "is3D: true ";
            grafico = grafico + "};";
            grafico = grafico + "var chart = new google.visualization.ColumnChart(document.getElementById('chart_div'));";
            grafico = grafico + "chart.draw(data, options);";
            grafico = grafico + "}";
            grafico = grafico + "google.setOnLoadCallback(drawChart);";
            grafico = grafico + "</script>";

            Literal1.Text = grafico;


        }


    }
}