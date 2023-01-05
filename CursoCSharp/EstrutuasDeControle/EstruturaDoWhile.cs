using System;


namespace CursoCSharp.CursoCSharp.EstrutuasDeControle {
     class EstruturaDoWhile {
        public static void Executar() {

            string entrada;

            do {                                             // Sempre será executada pelo menos 1 vez
                                                             // diferente do while que pode não ser executado nenhuma vez
                Console.WriteLine("Qual o seu nome ?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo {0}", entrada);
                Console.WriteLine("Deseja continuar?(S/N)");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() == "s");

        }
    }
}
