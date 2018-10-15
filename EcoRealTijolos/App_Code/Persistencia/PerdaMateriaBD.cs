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
        public int Insert(PerdaMateria perdamateria)
        {
            int retorno = 0;

            try
            {
                System.Data.IDbConnection objConexao;
                System.Data.IDbCommand objCommand;
                string sql = "INSERT INTO tbl_perdamateria(per_quantidade, per_observacao, mat_idperda) VALUES (?quantidade, ?observacao, ?idMmateria)";

                objConexao = Mapped.Connection();
                objCommand = Mapped.Command(sql, objConexao);

                objCommand.Parameters.Add(Mapped.Parameter("?quantidade", perdamateria.Quantidade));
                objCommand.Parameters.Add(Mapped.Parameter("?observacao", perdamateria.Observacao));
                objCommand.Parameters.Add(Mapped.Parameter("?idMateria", perdamateria.MateriaPrima.Id));

                objCommand.ExecuteNonQuery();
                objConexao.Close();
                objCommand.Dispose();
                objConexao.Dispose();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write(ex.ToString());
                retorno = -1;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
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
            objCommand = Mapped.Command("SELECT * FROM tbl_perdamateria", objConexao);
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
                obj.MateriaPrima.Id = Convert.ToInt32(objDataReader["mat_idperda"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }

        //update
        public bool Update(PerdaMateria perdamateria)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_perdamateria SET per_quantidade=?quantidade, per_observacao=?observacao WHERE per_id=?id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", perdamateria.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?observacao", perdamateria.Observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?id", perdamateria.Codigo));

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
            string sql = "DELETE FROM tbl_perdamateria WHERE per_id=?codigo";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }

        //constructor
        public PerdaMateriaBD()
        {
            //
            // TODO: Add constructor logic here
            // 
        }
    }
}