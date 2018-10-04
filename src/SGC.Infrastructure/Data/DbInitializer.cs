using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initializer(ClienteContext context)
        {
            if(context.Clientes.Any()) // se tiver algum cliente cadastraedo ele vai dar um return
            {
                return;
            }

            var Clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome ="joao",
                    CPF = "12345678999"

                },

                new Cliente
                {
                    Nome ="Wesley",
                    CPF = "12111118999"

                }
            };

            context.AddRange(Clientes);

            var contato = new Contato[]
            {
                new Contato
                {
                    Nome = "Contato 1",
                    Telefone = "996488067",
                    Email = "thor@gmail.com",
                    Cliente = Clientes[0]
                },

                 new Contato
                {
                    Nome = "Contato 2",
                    Telefone = "5555555",
                    Email = "aranha@gmail.com",
                    Cliente = Clientes[0]
                },
            };

            context.AddRange(contato);
            context.SaveChanges();
            

        }


    }
}
