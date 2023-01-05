using System;
using System.Globalization;

namespace CursoCSharp.CursoCSharp.Fundamentos {
     class FormatandoNumeros {
        public static void Executar() {

            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Formatando para uma casa decimal
            Console.WriteLine(valor.ToString("C")); // Coin, formata a variável para moeda, R$ 15,18
            Console.WriteLine(valor.ToString("P")); // Percentual, multiplica por 100 e coloca percentual.
            Console.WriteLine(valor.ToString("#.##")); // Retorna a variável com duas casas decimais.

            CultureInfo cultura = new CultureInfo("pt-BR"); // Vai retornar as funções padrões do Brasil
            Console.WriteLine(valor.ToString("C2", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //  Coloca zeros a esquerda do número.

        }
    }
}
