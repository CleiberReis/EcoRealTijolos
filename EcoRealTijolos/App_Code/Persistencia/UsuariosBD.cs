using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using EcoRealTijolos.App_Code.Classes;

namespace EcoRealTijolos.App_Code.Persistencia
{
    public class UsuariosBD
    {
        //métodos
        //insert
        public bool Insert(Usuarios usuario)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_usuario(usu_nome, usu_email, usu_login, usu_tipo, usu_ativo) VALUES (?nome, ?email, ?login, ?tipo, ?ativo)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?nome", usuario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?email", usuario.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?login", usuario.Login));
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", usuario.Tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?ativo", usuario.Ativo));

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
            objCommand = Mapped.Command("SELECT * FROM tbl_usuario", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }

        //select
        public Usuarios Select(int codigo)
        {
            Usuarios obj = null;

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_usuario WHERE usu_id=?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", codigo));

            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Usuarios();
                obj.Codigo = Convert.ToInt32(objDataReader["usu_id"]);
                obj.Nome = Convert.ToString(objDataReader["usu_nome"]);
                obj.Email = Convert.ToString(objDataReader["usu_email"]);
                obj.Login = Convert.ToString(objDataReader["usu_login"]);
                obj.Tipo = Convert.ToInt32(objDataReader["usu_tipo"]);
                obj.Ativo = Convert.ToInt32(objDataReader["usu_ativo"]);
            }

            objDataReader.Close();
            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return obj;
        }


    }
}