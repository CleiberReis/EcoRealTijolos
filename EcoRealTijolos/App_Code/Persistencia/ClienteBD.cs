using FATEC; //para acesso a classe Mapped
using System;
using System.Web;
using EcoRealTijolos.App_Code.Classes; //para acesso a classe Cliente
using System.Data; //para uso de DataSet
using System.Collections.Generic;
using System.Linq;

namespace EcoRealTijolos.App_Code.Persistencia
{
    //ClienteBD

    public class ClienteBD
    {
        //métodos

        //insert
        public bool Insert(Cliente cliente)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_cliente(cli_nome, cli_cpf, cli_telefone, cli_email, cli_estado, cli_cidade, cli_logradouro, cli_bairro, cli_numero) VALUES (?nome, ?cpf, ?telefone, ?email, ?estado, ?cidade, ?logradouro, ?bairro, ?numero)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?nome", cliente.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", cliente.Cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?telefone", cliente.Telefone));
            objCommand.Parameters.Add(Mapped.Parameter("?email", cliente.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?logradouro", cliente.Logradouro));
            objCommand.Parameters.Add(Mapped.Parameter("?estado", cliente.Estado));
            objCommand.Parameters.Add(Mapped.Parameter("?cidade", cliente.Cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?bairro", cliente.Bairro));
            objCommand.Parameters.Add(Mapped.Parameter("?numero", cliente.Numero));


            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }
        //selectall
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_cliente", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }

        //select
        public Cliente Select(int id)
        {
            Cliente obj = null;

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_cliente WHERE cli_id=?id", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?id", id));

            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Cliente();
                obj.Id = Convert.ToInt32(objDataReader["cli_id"]);
                obj.Nome = Convert.ToString(objDataReader["cli_nome"]);
                obj.Cpf = Convert.ToString(objDataReader["cli_cpf"]);
                obj.Telefone = Convert.ToString(objDataReader["cli_telefone"]);
                obj.Email = Convert.ToString(objDataReader["cli_email"]);
                obj.Logradouro = Convert.ToString(objDataReader["cli_logradouro"]);
                obj.Bairro = Convert.ToString(objDataReader["cli_bairro"]);
                obj.Numero = Convert.ToString(objDataReader["cli_numero"]);
                obj.Estado = Convert.ToString(objDataReader["cli_estado"]);
                obj.Cidade = Convert.ToString(objDataReader["cli_cidade"]);

            }

            objDataReader.Close();
            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return obj;
        }
        //update
        public bool Update(Cliente cliente)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_cliente SET cli_nome=?nome, cli_cpf=?cpf, cli_telefone=?telefone, cli_email=?email, cli_estado=?estado, cli_cidade=?cidade, cli_logradouro=?logradouro WHERE cli_id=?id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?nome", cliente.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", cliente.Cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?telefone", cliente.Telefone));
            objCommand.Parameters.Add(Mapped.Parameter("?email", cliente.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?logradouro", cliente.Logradouro));
            objCommand.Parameters.Add(Mapped.Parameter("?estado", cliente.Estado));
            objCommand.Parameters.Add(Mapped.Parameter("?cidade", cliente.Cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?id", cliente.Id));

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
            string sql = "DELETE FROM tbl_cliente WHERE cli_id=?id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?id", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }

        ///construtor
        public ClienteBD()
        {
            //
            // TODO: Add constructor logic here
            // 
        }
    }

}