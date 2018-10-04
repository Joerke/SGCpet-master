using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.ApplicationCore.Entity
{
    public class Contato
    {
        public Contato()
        {

        }
        public int ContatoId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public int ClienteId { get; set; } // fk
        public Cliente Clientes { get; set; } // propriedade de navegaçao
        public object Cliente { get; set; }
    }
}
