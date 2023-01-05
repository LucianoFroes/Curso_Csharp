using System;

namespace CursoCSharp.CursoCSharp.ClassesEMetodos {

    class Carro {             // Quando você não define nenhum construtor, o construtor padrão é o nome da classe
                              // no caso "Carro"
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string Modelo, string fabricante, int ano) {
            this.Modelo = Modelo; // this é utilizado para referenciar a variável que pertence ao objeto.
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() {

        }
    }
    class Construtores {

        public static void Executar() {

            var carro1 = new Carro(); // mesmo estando na mesma classe é preciso chamar o
                                      // construtor dentro do método Main.
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;

            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro() {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };

            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

        }
    }
}
