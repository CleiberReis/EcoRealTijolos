using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcoRealTijolos.App_Code.Classes
{
    public class MateriaPrima
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public int EstoqueMin { get; set; }

        //relacionamentos
        public PerdaMateria PerdaMateria { get; set; }

        //contructor
        public MateriaPrima()
        {
            //
            // TODO: Add contructor logic here
            //
        }
    }
}