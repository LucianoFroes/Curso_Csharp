using System;

namespace CursoCSharp.CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {

            // area da circunferência
            double raio = 5.5;
            const double PI = 3.14; // const = constante; ou seja, PI não pode ser alterado ao longo do cógido.

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Área é " + area); // concatenação

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo ?" + estaChovendo);

            byte idade = 45; // byte só aceita valores positivos
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // aceita valores positivos e negativos,
                                                // MinValue mostra o menor valor de sbyte
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue; // mostra o maior valor de short
            Console.WriteLine("Salário "+ salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; // _ Facilita a leitura
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            float precoComputador = 1299.99f; // float sempre acompanha o valor com um "f"
            Console.WriteLine("Preço Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado dos reais
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue; // Maior armazenamento
            Console.WriteLine("Distância entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string curso = "Seja Bem Vindo ao Curso de C#";
            Console.WriteLine(curso);



        }
    }
}
