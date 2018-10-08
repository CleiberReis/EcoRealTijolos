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
            string sql = "INSERT INTO tbl_cliente(cli_nome, cli_cpf, cli_telefone, cli_email) VALUES (?nome, ?cpf, ?telefone, ?email)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?nome", cliente.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", cliente.Cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?telefone", cliente.Telefone));
            objCommand.Parameters.Add(Mapped.Parameter("?email", cliente.Email));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }
        //selectall

        //select

        //update

        //delete

        ///construtor
        public ClienteBD()
        {
            //
            // TODO: Add constructor logic here
            // 
        }
    }

}