using System;
using System.Globalization;


namespace CursoCSharp.CursoCSharp.Fundamentos {
     class LendoDados {
        public static void Executar() {

            Console.Write("Qual o seu nome ?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade ?");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual o seu salário?");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // utilizando o System.Globalization, e utilizando ", CultureInfo.InvariantCulture"
            // O console vai reconhecer tanto o ponto e a vírgula.

            Console.WriteLine($"{nome} {idade} R${salario}");

        }

    }
}
