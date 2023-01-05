using System;


namespace CursoCSharp.CursoCSharp.ClassesEMetodos {
     class Params {

        public static void Recepcionar(params string[] pessoas) { // params faz aceitar vários atributos como um array que
                                                                  // pode armazabar vários.
            foreach(var pessoa in pessoas) {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }

        public static void Executar() {

            Recepcionar("Luciano", "Pedro", "Lucas");

        }
    }
}
