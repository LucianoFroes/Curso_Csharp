using System;

namespace CursoCSharp.CursoCSharp.ClassesEMetodos {

    public class Produto {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preço, double desconto) {
            Nome = nome;
            Preco = preço;
            Desconto = desconto;
        }
        public Produto() {

        }

        public double CalcularDesconto() {
            return Preco - Preco * Desconto;
        }
    }

     class AtributosEstaticos {
        public static void Executar() {

            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 5.3,
            };

            Console.WriteLine("Preço com desconto {0}",
                produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto {0}",
                produto2.CalcularDesconto());

            Produto.Desconto = 0.5;

            Console.WriteLine("Preço com desconto {0}",
                produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto {0}",
                produto2.CalcularDesconto());


        }
    }
}
