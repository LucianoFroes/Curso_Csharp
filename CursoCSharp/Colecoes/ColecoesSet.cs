using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.CursoCSharp.Colecoes {

     class ColecoesSet {

        public static void Executar() {

            Produto livro = new Produto("Game of Thrones", 49.9); // Set não aceita repetição e também não é indexada.

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo); // Seria o add da List
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);
            carrinho.Add(livro);

            foreach(var item in carrinho) {
               // Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
        }
    }
}
