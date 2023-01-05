using System;

namespace CursoCSharp.CursoCSharp.Fundamentos {
     class OperadoresLogicos {
        public static void Executar() {

            /*
             * 
             * TABELA VERDADE
             * 
             * AND "&&"
             * 
             * V && V = V
             * V && F = F
             * F && V = F
             * F && F = F
             * 
             * OR "||"
             * 
             * V || V = V
             * V || F = V
             * F || V = V
             * F || F = F
             * 
             * XOR "^" "OU EXCLUSIVO"
             * 
             * V ^ V = F
             * V ^ F = V
             * F ^ V = V
             * F ^ F = F
             * 
             */
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete); // ! negação
        }
    }
}
