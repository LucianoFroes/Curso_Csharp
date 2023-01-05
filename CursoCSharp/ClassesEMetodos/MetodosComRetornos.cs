using System;

namespace CursoCSharp.CursoCSharp.ClassesEMetodos {
    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }

        public int Substrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }
    }
    class CalculadoraCadeia {
            int memoria;

            public CalculadoraCadeia Somar(int a) {
                memoria += a;
                return this; // o this vai desencadear várias chamadas dentro da outra
            }

            public CalculadoraCadeia Multiplicar(int a) {
                memoria *= a;
                return this;
            }

            public CalculadoraCadeia Limpar() {
                memoria = 0;
                return this;
            }

            public CalculadoraCadeia Imprimir() {
                Console.WriteLine(memoria);
                return this;
            }

            public int Resultado() {
                return memoria;
            }
        }
     class MetodosComRetornos {
        public static void Executar() {

            var calculadoraComum = new CalculadoraComum();
            int resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Substrair(2, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

        }
    }
}
