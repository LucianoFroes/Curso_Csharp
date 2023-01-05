using System;


namespace CursoCSharp.CursoCSharp.Fundamentos {
     class OperadoresUnarios {
        public static void Executar() {

            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); // numero1++ só sera adicionado depois de fazer a comparação
                                                       // pois o ++ está depois da variável, já --numero2 foi decrementado 
                                                       // antes de fazer a comparação pois o decremento veio antes da
                                                       // variável.
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
