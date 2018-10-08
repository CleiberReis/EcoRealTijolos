using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace EcoRealTijolos.App_Code.Classes
{
    public class MateriaPrima
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        //contructor
        public MateriaPrima()
        {
            //
            // TODO: Add contructor logic here
            //
        }
    }
}