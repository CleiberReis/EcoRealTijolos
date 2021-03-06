﻿using FATEC; //para acesso a classe Mapped
using System;
using System.Web;
using EcoRealTijolos.App_Code.Classes; //para acesso a classe MateriaPrima
using System.Data; //para uso de DataSet
using System.Collections.Generic;
using System.Linq;

namespace EcoRealTijolos.App_Code.Persistencia
{
    //MateriaPrimaBD

    public class MateriaPrimaBD
    {
        //métodos
        //insert
        public bool Insert(MateriaPrima materia)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_materia(mat_nome, mat_quantidade, mat_estoqueMinimo) VALUES (?nome, ?quantidade, ?estoqueMinimo)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?nome", materia.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", materia.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?estoqueMinimo", materia.EstoqueMin));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
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
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", quantidade));
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

        //selectall Para a tela de PerdaMateria
        public DataSet SelectAllPerda()
        {
            DataSet ds = new DataSet();

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_perdamateria BY per_id DESC LIMIT 1", objConexao);

            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }

        public DataSet GetEstoqueMin()
        {
            DataSet dst = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_materia where mat_quantidade < mat_estoqueMinimo;", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(dst);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return dst;
        }

        //select
        public MateriaPrima Select(int id)
        {
            MateriaPrima obj = null;

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_materia WHERE mat_id=?id", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?id", id));

            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new MateriaPrima();
                obj.Id = Convert.ToInt32(objDataReader["mat_id"]);
                obj.Nome = Convert.ToString(objDataReader["mat_nome"]);
                obj.Quantidade = Convert.ToInt32(objDataReader["mat_quantidade"]);
                obj.EstoqueMin = Convert.ToInt32(objDataReader["mat_estoqueMinimo"]);
            }

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
            string sql = "UPDATE tbl_materia SET mat_nome=?nome, mat_quantidade=?quantidade WHERE mat_id=?id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?nome", materia.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", materia.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?id", materia.Id));

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
            string sql = "DELETE FROM tbl_materia WHERE mat_id=?id";

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
        public MateriaPrimaBD()
        {
            //
            // TODO: Add constructor logic here
            // 
        }
    }
}
