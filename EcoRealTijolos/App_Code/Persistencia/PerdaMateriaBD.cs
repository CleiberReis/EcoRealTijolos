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
                string sql = "INSERT INTO tbl_perdamateria(per_quantidade, per_observacao, mat_idperda) VALUES (?quantidade, ?observacao, ?idMmateria)";

                objConexao = Mapped.Connection();
                objCommand = Mapped.Command(sql, objConexao);

                objCommand.Parameters.Add(Mapped.Parameter("?quantidade", perda.Quantidade));
                objCommand.Parameters.Add(Mapped.Parameter("?observacao", perda.Observacao));
                objCommand.Parameters.Add(Mapped.Parameter("?idMateria", perda.MateriaPrima.Id));

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

        public int GetID(int materiaID, int quantidade, String observacao)
        {
            int perdaID = 0;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            //os campos abaixo são de exemplo. Você pode adicionar mais campos.
            objCommand = Mapped.Command("SELECT * FROM tbl_perdamateria WHERE mat_idperda=?codigo and per_quantidade=?quantidade and per_observacao=?observacao ORDER BY per_id DESC LIMIT 1", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", materiaID));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?observacao", observacao));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                perdaID = Convert.ToInt32(objDataReader["per_id"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return perdaID;
        }

        //selectAll Tela Cadastro de PerdaMateria
        public DataSet SelectAllPerda()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_perdamateria", objConexao);
            // objCommand.Parameters.Add(Mapped.Parameter("?nome", )); //parei aqui. Não sei continuar

            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }

        //select
        public PerdaMateria Select(int id)
        {
            PerdaMateria obj = null;

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_perdamateria WHERE per_id=?id", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?id", id));

            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new PerdaMateria();
                obj.Codigo = Convert.ToInt32(objDataReader["per_id"]);
                obj.Quantidade = Convert.ToInt32(objDataReader["per_quantidade"]);
                obj.Observacao = Convert.ToString(objDataReader["per_observacao"]);
            }

            objDataReader.Close();
            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return obj;
        }
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