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
                string sql = "INSERT INTO tbl_pedido(ped_data, ped_endereco, ped_obs, ped_idCliente) VALUES (?data, ?enderecoEntrega, ?observacao, ?idCliente)";
                objConexao = Mapped.Connection();
                objCommand = Mapped.Command(sql, objConexao);
                objCommand.Parameters.Add(Mapped.Parameter("?data", pedido.Data));
                objCommand.Parameters.Add(Mapped.Parameter("?enderecoEntrega", pedido.EnderecoEntrega));
                objCommand.Parameters.Add(Mapped.Parameter("?observacao", pedido.Observacao));
                objCommand.Parameters.Add(Mapped.Parameter("?idCliente", pedido.Cliente.Id));

                objCommand.ExecuteNonQuery();
                objConexao.Close();
                objCommand.Dispose();
                objConexao.Dispose();
            }
            catch (MySql.Data.MySqlClient.MySqlException /*ex*/)
            {
                //.Write(ex.ToString());
                retorno = -1;
            }
            catch (Exception)
            {
                retorno = -2;
            }
            return retorno;
        }

        public int GetID(DateTime data, int clienteID, String endereco, String observacao)
        {
            int pedidoID = 0;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            //os campos abaixo são de exemplo. Você pode adicionar mais campos.
            objCommand = Mapped.Command("SELECT * FROM tbl_pedido WHERE ped_data=?data and ped_idCliente=?codigo and ped_endereco=?endereco and ped_obs=?observacao ORDER BY ped_id DESC LIMIT 1", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?data", data));
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", clienteID));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?observacao", observacao));
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
            objCommand = Mapped.Command("SELECT * FROM tbl_pedidoproduto INNER JOIN tbl_pedido ON tbl_pedido.ped_id = tbl_pedidoproduto.ped_id", objConexao);
            //            ("SELECT * FROM tbl_produtofornecedor INNER JOIN
            //tbl_produto ON tbl_produto.pro_codigo = tbl_produtofornecedor.pro_codigo INNER JOIN
            //tbl_fornecedor ON tbl_fornecedor.for_codigo = tbl_produtofornecedor.for_codigo WHERE
            //tbl_produto.pro_codigo =? produto ORDER BY for_nome; ", objConexao);
            //objCommand.Parameters.Add(Mapped.Parameter("?pedido", pedido));
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }



        //selectall Para A tela de PedidoProduto
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
                obj.EnderecoEntrega = Convert.ToString(objDataReader["ped_endereco"]);
                obj.Observacao = Convert.ToString(objDataReader["ped_obs"]);
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
            string sql = "UPDATE tbl_pedido SET ped_data=?data, ped_endereco=?enderecoEntrega, ped_obs=?observacao WHERE ped_id=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?data", pedido.Data));
            objCommand.Parameters.Add(Mapped.Parameter("?enderecoEntrega", pedido.EnderecoEntrega));
            objCommand.Parameters.Add(Mapped.Parameter("?observacao", pedido.Observacao));
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