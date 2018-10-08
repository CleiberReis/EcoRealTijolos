using FATEC; //para acesso a classe Mapped
using System;
using System.Web;
using EcoRealTijolos.App_Code.Classes; //para acesso a classe Cliente
using System.Data; //para uso de DataSet
using System.Collections.Generic;
using System.Linq;


namespace EcoRealTijolos.App_Code.Persistencia
{
    public class MateriaPrimaBD
    {
        //insert
        public bool Insert(MateriaPrima materia)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_materia(mat_nome, mat_quantidade) VALUES (?nome, ?quantidade)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?nome", materia.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", materia.Quantidade));

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
            objCommand = Mapped.Command("SELECT * FROM tbl_materia", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }
        //select
        /*public MateriaPrima Select(int id)
        {
            MateriaPrima obj = null;

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_materia WHERE mat_id = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new MateriaPrima();
                obj.Codigo = Convert.ToInt32(objDataReader["mat_id"]);
                obj.Nome = Convert.ToString(objDataReader["mat_nome"]);
                obj.Quantidade = Convert.ToInt32(objDataReader["mat_quantidade"]);

                objDataReader.Close();
                objConexao.Close();

                objCommand.Dispose();
                objConexao.Dispose();
                objDataReader.Dispose();

                return obj;
            }
            //update
            public bool Update(MateriaPrima materia)
            {
                System.Data.IDbConnection objConexao;
                System.Data.IDbCommand objCommand;
                string sql = "UPDATE tbl_materia SET mat_nome=?nome, mat_quantidade=?quantidade WHERE mat_id=?codigo";

                objConexao = Mapped.Connection();
                objCommand = Mapped.Command(sql, objConexao);

                objCommand.Parameters.Add(Mapped.Parameter("?nome", materia.Nome));
                objCommand.Parameters.Add(Mapped.Parameter("?quantidade", materia.Quantidade));
                objCommand.Parameters.Add(Mapped.Parameter("?codigo", materia.Codigo));

                objCommand.ExecuteNonQuery();
                objConexao.Close();
                objCommand.Dispose();
                objConexao.Dispose();

                return true;
            }*/
        
    }
}