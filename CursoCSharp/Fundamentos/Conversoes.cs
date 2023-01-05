using System;


namespace CursoCSharp.CursoCSharp.Fundamentos {
     class Conversoes {
        public static void Executar() {

            int inteiro = 10;
            double quebrado= inteiro;
            Console.WriteLine(quebrado); // Conversão de um inteiro para double não tem problema, double é maior que int

            double nota = 9.7;
            int notaTruncada = (int) nota; // Cast, como double é maior que int, então deve-se fazer o cast de maneira 
            // explícita pois irá haver perda de informação, nesse caso será as casas decimais.
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.WriteLine("Digite a sua idade: ");
            string idadeString = Console.ReadLine();

            int idadeInteiro = int.Parse(idadeString); // outra maneira de fazer o cast
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString); // conversão também
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            Console.WriteLine("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero); // maneira mais segura de conversão
            // TryParse vai tentar fazer o cast da variável palavra e jogar dentro da variável número.
            // Se ele não conseguir ele retorna o valor zero ao invés de dar erro.

            Console.WriteLine($"Resultado 1: {numero}");

            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2); // pode jogar o Read dentro do TryParse,
                                                               // e declarar uma variável
            Console.WriteLine($"Resultado 2: {numero2}");

        }
    }
}
