using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.ApplicationCore.Entity
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public ICollection<Contato> Contatos { get; set; } // coleçao de contatos , 1 OU MUITOS CONTATOS
    }
}
