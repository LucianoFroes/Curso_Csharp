using System;


namespace CursoCSharp.CursoCSharp.ClassesEMetodos {

    public class CalculadoraEstatica {

        public static int Multiplicar(int a, int b) {
            return a * b;
        }
        public int Somar(int a, int b) { //static deixa a variável ou método pertencente a classe e não ao objeto.
            return a + b;
        }
    }
     class MetodosEstaticos {
        public static void Executar() {

            var resultado = CalculadoraEstatica.Multiplicar(2, 2); // Como o método multiplicar pertence a classe
                                                                   // então não é preciso utilizar o new "construtor"
            Console.WriteLine("Resultado: {0}", resultado);

            var calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));

        }
    }
}
