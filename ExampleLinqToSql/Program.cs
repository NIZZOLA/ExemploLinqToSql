using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExampleLinqToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Client> list = new List<Client>();
            list.Add(new Client() { ClientId = 1, Name = "Marcio", Active = true });
            list.Add(new Client() { ClientId = 2, Name = "Joao", Active = true });
            list.Add(new Client() { ClientId = 3, Name = "Dito", Active = true });
            list.Add(new Client() { ClientId = 4, Name = "Maria", Active = true });
            list.Add(new Client() { ClientId = 5, Name = "Bento", Active = true });
            list.Add(new Client() { ClientId = 6, Name = "Pafuncio", Active = true });
            list.Add(new Client() { ClientId = 7, Name = "Gerundio", Active = true });
            list.Add(new Client() { ClientId = 8, Name = "Marcio", Active = true });

            var todos = list.ToList().OrderBy(a => a.Name).ThenBy( b=> b.ClientId).ToList();
            Listar(todos);
            
            var marcio = list.Where(x => x.ClientId == 1).ToList();

            var lista2 = list.Where(x => x.Name == "Bento" && x.Name == "Maria" && x.Active ).ToList();
            var qt2 = list.Where(x => x.Name == "Bento" && x.Name == "Maria" && x.Active).Count();

            Console.WriteLine("Lista 2 quantidade:" + lista2.Count());
            
            var codigos = list.Select(a => a.ClientId).ToList();

            var nova = list.Select(a => new { codigo = a.ClientId, nome = a.Name });
            Console.ReadKey();
        }

        public static void Listar(ICollection<Client> clients)
        {
            foreach (var item in clients)
            {
                Console.WriteLine(item.ClientId + " | " + item.Name + " | " + item.Active + " |");
            }
        }

    }
}
