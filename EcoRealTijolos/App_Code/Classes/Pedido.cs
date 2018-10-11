using System;
using System.Data;
using FATEC;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcoRealTijolos.App_Code.Classes;
using EcoRealTijolos.App_Code.Persistencia;

namespace EcoRealTijolos.App_Code.Classes
{
    public class Pedido
    {
        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public String EnderecoEntrega { get; set; }
        public String Observacao { get; set; }
        
        //Relacionamentos 

        public Cliente Cliente { get; set; } //(1 pedido só pode ter 1 um cliente, e um cliente pode ter N vários pedidos)
                              // public List <Produto> Produtos { get; set; } (1 pedido pode ter N varios produtos, e um produtos pode estar em N varios pedidos)

        //construtor
        public Pedido()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}