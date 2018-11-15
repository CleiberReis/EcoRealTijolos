using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcoRealTijolos.App_Code.Classes
{
    public class Usuarios
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Tipo { get; set; }
        public string Login { get; set; }
        public string PriAcesso { get; set; }
        public string Senha { get; set; }
        public int Ativo { get; set; }

        //contructor
        public Usuarios()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}