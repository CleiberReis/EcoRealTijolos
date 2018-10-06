using System;
using FATEC;
using EcoRealTijolos.App_Code.Classes;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Web;

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
    }
}