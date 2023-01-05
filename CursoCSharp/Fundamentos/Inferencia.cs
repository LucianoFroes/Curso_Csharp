using System;


namespace CursoCSharp.CursoCSharp.Fundamentos {
     class Inferencia {
        public static void Executar() {

            var nome = "Leonardo";
            // nome = 123;
            Console.WriteLine(nome);
            // A linguagem detectou que é tipo string, mas você não pode
            // atribuir depois valores de outros tipos.

            var idade = 32; //com o Var é necessário inicializar a variável.
            Console.WriteLine(idade);

            int a; // pode inicializar a variável em outra linha;
            a = 3;
            int b = 2;

            Console.WriteLine(a + b);

        }
    }
}
