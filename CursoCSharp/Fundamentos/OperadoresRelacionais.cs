using System;


namespace CursoCSharp.CursoCSharp.Fundamentos {
     class OperadoresRelacionais {
        public static void Executar() {

            double nota = 6.0;
            double.TryParse(Console.ReadLine(), out nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida ? {0}", nota > 10.0);
            Console.WriteLine("Nota inválida ? {0}", nota < 10.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por média {0}", nota >= notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);



        }
    }
}
