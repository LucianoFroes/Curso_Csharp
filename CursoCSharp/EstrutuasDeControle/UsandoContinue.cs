using System;

namespace CursoCSharp.CursoCSharp.EstrutuasDeControle {
     class UsandoContinue {
        public static void Executar() {

            int intervalo = 50;
            Console.WriteLine("Números pares entre 1 e {0}!", intervalo);

            for(int i = 1; i <= intervalo; i++) {
                if(i % 2 == 1) {
                    continue; // O continue faz com que a instrução atual seja interrompida e
                              // passe para a proxima iteração do laço de repetição.
                }

                Console.Write(i + " ");
            }
        }
    }
}
