using System;
using System.Data;
using FATEC;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

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
                string sql = "INSERT INTO tbl_pedidoproduto(pedpro_quantidade, pedpro_subtotal, ped_id, prod_id) VALUES (?quantidade, ?subtotal, ?idPedido, ?idProduto)";

                objConexao = Mapped.Connection();
                objCommand = Mapped.Command(sql, objConexao);

                objCommand.Parameters.Add(Mapped.Parameter("?quantidade", pedidoproduto.Quantidade));
                objCommand.Parameters.Add(Mapped.Parameter("?subtotal", pedidoproduto.Subtotal));
                objCommand.Parameters.Add(Mapped.Parameter("?idPedido", pedidoproduto.Pedido.Codigo));
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

        public DataSet SelectAllByID(int idpedido)
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_pedidoproduto INNER JOIN tbl_pedido ON tbl_pedido.ped_id = tbl_pedidoproduto.ped_id WHERE tbl_pedidoproduto.ped_id = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", idpedido));
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

        //selectall
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_pedidoproduto", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

        //select
        public PedidoProduto Select(int id)
        {
            PedidoProduto obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_pedidoproduto WHERE pedprod_id=?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new PedidoProduto();
                obj.Id = Convert.ToInt32(objDataReader["pedpro_id"]);
                obj.Pedido.Codigo = Convert.ToInt32(objDataReader["ped_id"]);
                obj.Produto.Id = Convert.ToInt32(objDataReader["prod_id"]);
                obj.Quantidade = Convert.ToInt32(objDataReader["pedpro_quantidade"]);
                obj.Subtotal = Convert.ToDouble(objDataReader["pedpro_subtotal"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }

        //update
        public bool Update(PedidoProduto pedidoproduto)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_pedidoproduto SET pedpro_quantidade=?quantidade, pedpro_subtotal=?subtotal WHERE pedpro_id=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", pedidoproduto.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?subtotal", pedidoproduto.Subtotal));
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", pedidoproduto.Id));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //delete
        public bool Delete(int id)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM tbl_pedidoproduto WHERE pedpro_id=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        //subtrai quantidade da tbl_produto
        public bool UpdateQuantidade(int quantidade, int produtoid)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_produto SET prod_quantTotal = prod_quantTotal - ?quantidade where prod_id = ?codigo;";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", produtoid));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        //calculoValorTotal
        public double GetSomaTotal(int idPedido)
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT SUM(pedpro_subtotal) AS SOMA FROM tbl_pedidoproduto WHERE ped_id=?codigo", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", idPedido));
            objDataAdapter.Fill(ds);
            DataRow dr = ds.Tables[0].Rows[0];
            Double total = Convert.ToDouble(dr["SOMA"]);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return total;
        }

        public PedidoProdutoBD()
        {
            /// Construtor
        }

    }
}