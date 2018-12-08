using EcoRealTijolos.App_Code.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
                lblOptionMenu.Text = "Relatório de Vendas";

                Carrega();
            }
        }

        private void Carrega()
        {
            PedidoBD bd = new PedidoBD();
            DataSet ds = bd.SelectAllGrafico();

            string dados = "";
            //varre linhas do dataset
            dados = dados + "['Data do pedido', 'Quantidade de Pedidos'],";

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                dados = dados + "['" + Convert.ToDateTime(dr["datapedido"]).ToShortDateString() + "', " + Convert.ToInt32(dr["quantidade"]) + "],";
            }

            if (dados == "['Data do pedido', 'Quantidade de Pedidos'],")
            {
                txtMensagem.Text = "Não existem pedidos cadastrados.";
                txtInicial.Text = "";
                txtFinal.Text = "";
                txtInicial.Focus();
            }
            else
            {
                GerarGrafico(dados);
            }
        }

        void GerarGrafico(string dados)
        {
            Literal1.Text = "";
            string grafico = "";
            grafico = grafico + "<script type='text/javascript'>";
            grafico = grafico + "google.load('visualization', '1', {packages:['corechart']});";
            grafico = grafico + "function drawChart() {";
            grafico = grafico + "var data = google.visualization.arrayToDataTable([";
            grafico = grafico + dados;
            grafico = grafico + "]);";
            grafico = grafico + "var options = {";
            grafico = grafico + "title: 'Pedidos realizados',";
            grafico = grafico + "vAxis: {format: 'decimal'},";
            grafico = grafico + "colors: ['#1b9e77']";
            grafico = grafico + "};";
            grafico = grafico + "var chart = new google.visualization.ColumnChart(document.getElementById('chart_div'));";
            grafico = grafico + "chart.draw(data, options);";
            grafico = grafico + "}";
            grafico = grafico + "google.setOnLoadCallback(drawChart);";
            grafico = grafico + "</script>";

            Literal1.Text = grafico;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            PedidoBD bd = new PedidoBD();
           
            DateTime dataIni = DateTime.ParseExact(txtInicial.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime dataFim = DateTime.ParseExact(txtFinal.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            DataSet ds = bd.SelectAllByDATAS(dataIni, dataFim);

            if (dataFim < dataIni)
            {
                txtMensagem.Text = "Data final é menor que Data inicial.";
                txtInicial.Text = "";
                txtFinal.Text = "";
                txtInicial.Focus();
            }
            else
            {
                string dados = "";
                //varre linhas do dataset
                dados = dados + "['Data do pedido', 'Quantidade de Pedidos'],";

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dados = dados + "['" + Convert.ToDateTime(dr["datapedido"]).ToShortDateString() + "', " + Convert.ToInt32(dr["quantidade"]) + "],";
                }

                if (dados == "['Data do pedido', 'Quantidade de Pedidos'],")
                {
                    txtMensagem.Text = "Não existem pedidos nesse intervalo de busca, tente uma nova consulta";
                    txtInicial.Text = "";
                    txtFinal.Text = "";
                    txtInicial.Focus();
                }
                else
                {
                    GerarGrafico(dados);
                }
            }

        }


    }
}