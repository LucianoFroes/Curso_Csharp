using System;


namespace CursoCSharp.CursoCSharp.EstrutuasDeControle {
     class UsandoBreak {
        public static void Executar() {

            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}.", numero);

            for(int i = 1; i <= 50; i++) {
                Console.WriteLine($"{i} é o número que queremos?");
                if(i == numero) {
                    Console.WriteLine("Sim!");
                    break; // o break vai quebrar o for após a condição ser executada.

                } else {
                    Console.WriteLine("Não!");
                }
            }
            Console.WriteLine("Fim");
        }
    }
}
