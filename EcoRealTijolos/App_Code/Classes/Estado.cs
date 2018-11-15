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
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Uf { get; set; }
        public string Pais { get; set; }

        public Estado()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
   
}