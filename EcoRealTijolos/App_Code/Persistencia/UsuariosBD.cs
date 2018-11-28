using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using EcoRealTijolos.App_Code.Classes;
using System.Web.UI.WebControls;

namespace EcoRealTijolos.App_Code.Persistencia
{
    public class UsuariosBD
    {
        //métodos

        public Usuarios Autentica(string login, string senha)
        {
            Usuarios obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_usuario WHERE usu_login = ?login and usu_senha = ?senha", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?login", login));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", senha));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Usuarios();
                obj.Codigo = Convert.ToInt32(objDataReader["usu_id"]);
                obj.Nome = Convert.ToString(objDataReader["usu_nome"]);
                obj.Login = Convert.ToString(objDataReader["usu_login"]);
                obj.Tipo = Convert.ToInt32(objDataReader["usu_tipo"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        //insert
        public bool Insert(Usuarios usuario)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_usuario(usu_nome, usu_email, usu_login, usu_tipo, usu_ativo, usu_senha, usu_priacesso) VALUES (?nome, ?email, ?login, ?tipo, ?ativo, ?senha, ?priacesso)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?nome", usuario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?email", usuario.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?login", usuario.Login));
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", usuario.Tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?ativo", usuario.Ativo));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", usuario.Senha));
            objCommand.Parameters.Add(Mapped.Parameter("?priacesso", usuario.PriAcesso));

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
                obj.Senha = Convert.ToString(objDataReader["usu_senha"]);
                obj.PriAcesso = Convert.ToString(objDataReader["usu_priacesso"]);
            }

            objDataReader.Close();
            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return obj;
        }

        //update
        public bool Update(Usuarios usuario)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_usuario SET usu_nome=?nome, usu_email=?email, usu_login=?login, usu_tipo=?tipo, usu_ativo=?ativo, usu_senha=?senha, usu_priacesso=?priacesso WHERE usu_id=?codigo";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            
            objCommand.Parameters.Add(Mapped.Parameter("?nome", usuario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?email", usuario.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?login", usuario.Login));
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", usuario.Tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?ativo", usuario.Ativo));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", usuario.Senha));
            objCommand.Parameters.Add(Mapped.Parameter("?priacesso", usuario.PriAcesso));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }

        //delete
        public bool Delete(int codigo)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM tbl_usuario WHERE usu_id=?codigo";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?codigo", codigo));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }
        //contructor
        public UsuariosBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}