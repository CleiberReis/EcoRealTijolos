using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcoRealTijolos.App_Code.Classes
{
    public class PerdaMateria
    {
        public int Codigo { get; set; }
        public int Quantidade { get; set; }
        public string Observacao { get; set; }

        //relacionamentos
        public MateriaPrima MateriaPrima { get; set; }
    }
}