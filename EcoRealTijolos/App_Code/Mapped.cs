using System;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

//Importa funções do MySQL
using MySql.Data.MySqlClient;
//Trabalhar com Dataset
using System.Data;
//Permite visualizar o web.config
using System.Configuration;
 

namespace FATEC
{
    /// <summary>
    /// Summary description for Mapped
    /// </summary>
    public class Mapped
    {
        //Abrir conexao
        public static IDbConnection Connection()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.AppSettings["strConexao"]);
            conn.Open();
            return conn;
        }

        //Executa comando no BD
        public static IDbCommand Command(string query, IDbConnection conexao)
        {
            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = query;
            return comando;
        }

        //Retorna um Adapter (SELECT)
        public static IDataAdapter Adapter(IDbCommand comando)
        {
            IDbDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = comando;
            return adap;
        }

        //Cria parametro da SQL
        public static IDbDataParameter Parameter(string nome, object valor)
        {
            return new MySqlParameter(nome, valor);
        
        }



        public Mapped()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}