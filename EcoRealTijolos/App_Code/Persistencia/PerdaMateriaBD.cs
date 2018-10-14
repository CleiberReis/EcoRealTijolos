using FATEC; //para acesso a classe Mapped
using System;
using System.Web;
using EcoRealTijolos.App_Code.Classes; //para acesso a classe MateriaPrima
using System.Data; //para uso de DataSet
using System.Collections.Generic;
using System.Linq;

namespace EcoRealTijolos.App_Code.Persistencia
{
    public class PerdaMateriaBD
    {
        //insert
        public int Insert(PerdaMateria perda)
        {
            int retorno = 0;

            try
            {
                System.Data.IDbConnection objConexao;
                System.Data.IDbCommand objCommand;
                string sql = "INSERT INTO tbl_perdamateria(per_id, per_quantidade, per_observacao, mat_id) VALUES (?id, ?quantidade, ?observacao, ?materia)";

                objConexao = Mapped.Connection();
                objCommand = Mapped.Command(sql, objConexao);

                objCommand.Parameters.Add(Mapped.Parameter("?id", perda.Codigo));
                objCommand.Parameters.Add(Mapped.Parameter("?quantidade", perda.Quantidade));
                objCommand.Parameters.Add(Mapped.Parameter("?observacao", perda.Observacao));
                objCommand.Parameters.Add(Mapped.Parameter("?materia", perda.MateriaPrima.Id));

                objCommand.ExecuteNonQuery();
                objConexao.Close();
                objCommand.Dispose();
                objConexao.Dispose();
            }
            catch (MySql.Data.MySqlClient.MySqlException) { retorno = -1; }
            catch (Exception) { retorno = -2; }

            return retorno;
        }
        //selectAll

        //select

        //update

        //delete

        //constructor
        public PerdaMateriaBD()
        {
            //
            // TODO: Add constructor logic here
            // 
        }
    }
}