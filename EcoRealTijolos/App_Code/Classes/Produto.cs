using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcoRealTijolos.App_Code.Classes
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public int QuantidadeTotal { get; set; }
        public Double ValorUnitario { get; set; }

        public Produto()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}