using System;
using System.Data;
using FATEC;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace EcoRealTijolos.App_Code.Classes
{
    public class Cliente
    {
        //propriedades da classe
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public Pedido Pedido { get; set; }



        
        //construtor
        public Cliente()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}