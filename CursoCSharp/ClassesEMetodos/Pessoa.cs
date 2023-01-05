using System;

namespace CursoCSharp.CursoCSharp.ClassesEMetodos {
     class Pessoa {

        public string Nome; // valor padrão é Null
        public int Idade; // valor padrão é 0

        public string Apresentar () { // Como o método apresentar está dentro da classe Pessoa, então não precisamos
                                      // colocar nenhum parâmetro dentro dos parênteses,
                                      // pois temos acesso as variáveis Nome e Idade.
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar()); // Imprimir no console não faz com que o método retorne algo, por isso é void
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }   
}
