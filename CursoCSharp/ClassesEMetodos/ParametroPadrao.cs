using System;


namespace CursoCSharp.CursoCSharp.ClassesEMetodos {

     class ParametroPadrao {

        public static int Somar(int a = 1, int b = 1) {
            return a + b;

        }
        public static void Executar() {

            Console.WriteLine(Somar(10, 23));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b : 7));

            // Não precisa passar os dois parâmetros, pois vai assumir o valor de 1.
        }
    }
}
