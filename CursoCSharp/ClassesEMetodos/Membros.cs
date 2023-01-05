using System;

namespace CursoCSharp.CursoCSharp.ClassesEMetodos {
     class Membros {
        public static void Executar() {

        Pessoa sicrano = new Pessoa(); // o construtor chama a outra classe e todos atributos e métodos dentro dela.
            sicrano.Nome = "Renato"; // notação ponto é a maneira que tem de acessar os membros de uma classe.
            sicrano.Idade = 21;

            Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 32;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);

        }
    }
}
