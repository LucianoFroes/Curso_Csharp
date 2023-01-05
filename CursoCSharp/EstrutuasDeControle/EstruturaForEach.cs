using System;


namespace CursoCSharp.CursoCSharp.EstrutuasDeControle {
     class EstruturaForEach {
        public static void Executar() {

            // for each é mais utilizado para percorrer alguma coisa, principalmente objetos.

            var palavra = "Opa!";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" }; // Array

            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
