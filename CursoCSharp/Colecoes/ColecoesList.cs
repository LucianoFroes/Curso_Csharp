using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.CursoCSharp.Colecoes {

    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    
     class ColecoesList {

        public static void Executar() {

            Produto livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>(); // Uma lista não tem um tamanho definido
            carrinho.Add(livro); // adiciona mais componentes para a lista.

            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count); // Count é tipo o Lenght do array
            carrinho.RemoveAt(3); // remover elemento 3
            carrinho.Add(livro); // O list pode ter dois dados iguais
            carrinho.Insert(1, livro); // Insert vai inserir via indice, não vai substituir apenas empurrar.

            //foreach(var item in carrinho) {
            //    Console.WriteLine(carrinho.IndexOf(item));
            //    Console.WriteLine($"{item.Nome} {item.Preco}");
            //}
        }
    }
}
