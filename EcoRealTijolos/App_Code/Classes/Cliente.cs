using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        //construtor
        public Cliente()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}