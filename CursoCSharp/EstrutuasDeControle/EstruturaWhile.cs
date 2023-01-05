using System;


namespace CursoCSharp.CursoCSharp.EstrutuasDeControle {
    class EstruturaWhile {
        public static void Executar() {

            int palpite = 0;
            Random random = new Random(); // função que gera número aleatório, é preciso chamar usando o new
                                          // e depois atribuir a uma variável usando random.Next(x, y);

            int numeroSecreto = random.Next(1, 16); // intervalo de 1 a 15
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green; // Muda a cor do terminal
                    Console.WriteLine("Número encopntrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior; // Retorna a cor original

                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);

                } else {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);
                }
            }

        }
    }
}
