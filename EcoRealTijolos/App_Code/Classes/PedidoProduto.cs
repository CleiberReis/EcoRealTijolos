using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcoRealTijolos.App_Code.Classes
{
    public class PedidoProduto
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public Double Subtotal { get; set; }
        //public Double Total { get; set; }

        //Relacionamentos
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }

        public PedidoProduto()
        {

        }
    }
}