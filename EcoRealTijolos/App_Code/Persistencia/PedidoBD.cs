using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcoRealTijolos.App_Code.Classes;
using System.Data;
using FATEC;

namespace EcoRealTijolos.App_Code.Persistencia
{
    /// <summary>
    /// Summary description for PedidoBD
    /// </summary>
    public class PedidoBD
    {
        //métodos
        //insert
        public int Insert(Pedido pedido)
        {
            int retorno = 0;
            try
            {
                System.Data.IDbConnection objConexao;
                System.Data.IDbCommand objCommand;
                string sql = "INSERT INTO tbl_pedido(ped_data, ped_logradouro, ped_obs, ped_cidade, ped_estado, ped_bairro, ped_numero, ped_idCliente) VALUES (?data, ?logradouro, ?observacao, ?cidade, ?estado, ?bairro, ?numero, ?idCliente)";
                objConexao = Mapped.Connection();
                objCommand = Mapped.Command(sql, objConexao);
                objCommand.Parameters.Add(Mapped.Parameter("?data", pedido.Data));
                objCommand.Parameters.Add(Mapped.Parameter("?logradouro", pedido.Logradouro));
                objCommand.Parameters.Add(Mapped.Parameter("?observacao", pedido.Observacao));
                objCommand.Parameters.Add(Mapped.Parameter("?cidade", pedido.Cidade));
                objCommand.Parameters.Add(Mapped.Parameter("?estado", pedido.Estado));
                objCommand.Parameters.Add(Mapped.Parameter("?bairro", pedido.Bairro));
                objCommand.Parameters.Add(Mapped.Parameter("?numero", pedido.Numero));
                objCommand.Parameters.Add(Mapped.Parameter("?idCliente", pedido.Cliente.Id));

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
            catch (Exception)
            {
                retorno = -2;
            }
            return retorno;
        }

        public int GetID(DateTime data, int clienteID, String logradouro, String observacao, String cidade, String estado, String bairro, String numero)
        {
            int pedidoID = 0;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            //os campos abaixo são de exemplo. Você pode adicionar mais campos.
            objCommand = Mapped.Command("SELECT * FROM tbl_pedido WHERE ped_data=?data and ped_idCliente=?codigo and ped_logradouro=?logradouro and ped_obs=?observacao and ped_cidade=?cidade and ped_estado=?estado and ped_bairro=?bairro and ped_numero=?numero ORDER BY ped_id DESC LIMIT 1", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?data", data));
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", clienteID));
            objCommand.Parameters.Add(Mapped.Parameter("?logradouro", logradouro));
            objCommand.Parameters.Add(Mapped.Parameter("?observacao", observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?cidade", cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?estado", estado));
            objCommand.Parameters.Add(Mapped.Parameter("?bairro", bairro));
            objCommand.Parameters.Add(Mapped.Parameter("?numero", numero));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                pedidoID = Convert.ToInt32(objDataReader["ped_id"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return pedidoID;
        }

        //selectall
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_pedidoproduto INNER JOIN " +
                "tbl_pedido ON tbl_pedido.ped_id = tbl_pedidoproduto.ped_id INNER JOIN " +
                "tbl_cliente ON tbl_cliente.cli_id = tbl_pedido.ped_idCliente INNER JOIN " +
                "tbl_produto ON tbl_produto.prod_id = tbl_pedidoproduto.prod_id ORDER BY cli_nome;", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

        public DataSet SelectAllPedidos()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_pedido ORDER BY ped_id DESC LIMIT 1", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

        //selectall Para o gráfico
        public DataSet SelectAllGrafico()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT tbl_pedido.ped_data AS datapedido, COUNT(ped_id) AS quantidade FROM tbl_pedido GROUP BY datapedido", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }


        public DataSet SelectAllByDATAS(DateTime dataum, DateTime datadois)
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();

            string sql = @"SELECT ped_data AS datapedido, 
                            COUNT(ped_id) AS quantidade 
                            FROM tbl_pedido 
                            GROUP BY datapedido
                            having datapedido between ?dataum and ?datadois";

            objCommand = Mapped.Command(sql, objConexao);
            //            ("SELECT * FROM tbl_produtofornecedor INNER JOIN
            //tbl_produto ON tbl_produto.pro_codigo = tbl_produtofornecedor.pro_codigo INNER JOIN
            //tbl_fornecedor ON tbl_fornecedor.for_codigo = tbl_produtofornecedor.for_codigo WHERE
            //tbl_produto.pro_codigo =? produto ORDER BY for_nome; ", objConexao);
            //objCommand.Parameters.Add(Mapped.Parameter("?pedido", pedido));
            objCommand.Parameters.Add(Mapped.Parameter("?dataum", dataum));
            objCommand.Parameters.Add(Mapped.Parameter("?datadois", datadois));
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

        //select
        public Pedido Select(int id)
        {
            Pedido obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_pedido WHERE ped_id=?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Pedido();
                obj.Codigo = Convert.ToInt32(objDataReader["ped_id"]);
                obj.Data = Convert.ToDateTime(objDataReader["ped_data"]);
                obj.Logradouro = Convert.ToString(objDataReader["ped_logradouro"]);
                obj.Observacao = Convert.ToString(objDataReader["ped_obs"]);
                obj.Cidade = Convert.ToString(objDataReader["ped_cidade"]);
                obj.Estado = Convert.ToString(objDataReader["ped_estado"]);
                obj.Bairro = Convert.ToString(objDataReader["ped_bairro"]);
                obj.Numero = Convert.ToString(objDataReader["ped_numero"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }

        
        //update
        public bool Update(Pedido pedido)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_pedido SET ped_data=?data, ped_logradouro=?logradouro, ped_obs=?observacao, ped_cidade=?cidade, ped_estado=?estado, ped_bairro=?bairro, ped_numero=?numero WHERE ped_id=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?data", pedido.Data));
            objCommand.Parameters.Add(Mapped.Parameter("?logradouro", pedido.Logradouro));
            objCommand.Parameters.Add(Mapped.Parameter("?observacao", pedido.Observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?cidade", pedido.Cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?estado", pedido.Estado));
            objCommand.Parameters.Add(Mapped.Parameter("?bairro", pedido.Bairro));
            objCommand.Parameters.Add(Mapped.Parameter("?numero", pedido.Numero));
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", pedido.Codigo));
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
            string sql = "DELETE FROM tbl_pedido WHERE ped_id=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //construtor
        public PedidoBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}