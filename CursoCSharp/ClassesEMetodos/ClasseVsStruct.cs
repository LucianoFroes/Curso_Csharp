using System;

namespace CursoCSharp.CursoCSharp.ClassesEMetodos {

    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }

     class ClasseVsStruct {
        public static void Executar() {

            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // Atribuição por VALOR!!! Não apontam para o mesmo local de memória
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X:{0}", copiaPonto1.X);

            // DIFERENÇA ENTRE STRUCT E CLASSE É QUE O STRUCT SE FEITO UMA CÓPIA, ELAS NÃO APONTAM PARA O MESMO
            // LOCAL DE MEMÓRIA, DIFERENTEMENTE DE CLASSE QUE VAI APONTAR PARA O MESMO.

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaDoPonto2 = ponto2; // Atribuição por referência.
            ponto2.X = 4;

            Console.WriteLine("Ponto 1 X:{0}", ponto2.X);
            Console.WriteLine("Copia Ponto 1 X:{0}", copiaDoPonto2.X);

        }
    }
}
