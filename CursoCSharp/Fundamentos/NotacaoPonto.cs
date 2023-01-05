using System;

namespace CursoCSharp.CursoCSharp.Fundamentos {
     class NotacaoPonto {
        public static void Executar() {

            var saudacao = "Olá".ToUpper().Insert(3, "World!").Replace("World!", " Mundo!");
            Console.WriteLine(saudacao);
            // Utilizando a notação ponto, existem inúmeras funções disponíveis para te ajudar
            // ToUpper deixa todas letras maiúsculas, Insert vai inserir a palavra na localização desejada
            // "começa na zero", Replace vai substituir a palavra World! para Mundo!

            Console.WriteLine("Teste".Length); // Vai mostrar a quantidade de caracteres que tem na string

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);// ? serve para a linguagem observar se a variável não está vazia
            // se tiver, .Length não será executado.


        }
    }
}
