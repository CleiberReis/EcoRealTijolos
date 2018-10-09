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
            string sql = "INSERT INTO tbl_pedido (ped_data, ped_rua, ped_obs, ped_cep, ped_numero, ped_estado, ped_complemento, ped_cidade, ped_idCliente) VALUES (?data, ?rua, ?observacao, ?cep, ?numero, ?estado, ?complemento, ?cidade, ?idCliente)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?data", pedido.Data));
            objCommand.Parameters.Add(Mapped.Parameter("?rua", pedido.Rua));
            objCommand.Parameters.Add(Mapped.Parameter("?observacao", pedido.Observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?cep", pedido.Observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?numero", pedido.Observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?estado", pedido.Observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?complemento", pedido.Observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?cidade", pedido.Observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?idCliente", pedido.Cliente.Id));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                retorno = -1;
            }
            catch (Exception)
            {
                retorno = -2;
            }
            return retorno;
        }

        //selectall
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_pedido", objConexao);
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
                obj.Codigo = Convert.ToInt32(objDataReader["ped_codigo"]);
                obj.Data = Convert.ToDateTime(objDataReader["ped_data"]);
                obj.Rua = Convert.ToString(objDataReader["ped_rua"]);
                obj.Observacao = Convert.ToString(objDataReader["ped_obs"]);
                obj.Observacao = Convert.ToString(objDataReader["ped_cep"]);
                obj.Observacao = Convert.ToString(objDataReader["ped_numero"]);
                obj.Observacao = Convert.ToString(objDataReader["ped_estado"]);
                obj.Observacao = Convert.ToString(objDataReader["ped_complemento"]);
                obj.Observacao = Convert.ToString(objDataReader["ped_cidade"]);
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
            string sql = "UPDATE tbl_pedido SET ped_data=?data, ped_rua=?rua, ped_obs=?observacao, ped_cep=?cep, ped_numero=?numero, ped_estado=?, ped_complemento=?complemento, ped_cidade=?cidade WHERE ped_id=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?data", pedido.Data));
            objCommand.Parameters.Add(Mapped.Parameter("?rua", pedido.Rua));
            objCommand.Parameters.Add(Mapped.Parameter("?observacao", pedido.Observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?cep", pedido.Observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?numero", pedido.Observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?estado", pedido.Observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?complemento", pedido.Observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?cidade", pedido.Observacao));
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