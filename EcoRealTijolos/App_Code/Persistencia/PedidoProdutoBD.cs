using System;
using System.Data;
using FATEC;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcoRealTijolos.App_Code.Classes;

namespace EcoRealTijolos.App_Code.Persistencia
{
    public class PedidoProdutoBD
    {
        public int Insert(PedidoProduto pedidoproduto)
        {
            int retorno = 0;
            try
            {
                System.Data.IDbConnection objConexao;
                System.Data.IDbCommand objCommand;
                string sql = "INSERT INTO tbl_pedidoproduto(pedpro_quantidade, pedpro_ subtotal, prod_id) VALUES (?quantidade, ?subtotal, ?idProduto)";
                objConexao = Mapped.Connection();
                objCommand = Mapped.Command(sql, objConexao);
                objCommand.Parameters.Add(Mapped.Parameter("?quantidade", pedidoproduto.Quantidade));
                objCommand.Parameters.Add(Mapped.Parameter("?subtotal", pedidoproduto.Subtotal));
                //objCommand.Parameters.Add(Mapped.Parameter("?idPedido", pedidoproduto.Pedido.Codigo));
                objCommand.Parameters.Add(Mapped.Parameter("?idProduto", pedidoproduto.Produto.Id));

                objCommand.ExecuteNonQuery();
                objConexao.Close();
                objCommand.Dispose();
                objConexao.Dispose();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write(ex.ToString());
                retorno = -1;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                retorno = -2;
            }
            return retorno;
        }

    }
}