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
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
        

        public Cidade()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }

}