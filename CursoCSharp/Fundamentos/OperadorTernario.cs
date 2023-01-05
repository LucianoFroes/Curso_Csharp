using System;


namespace CursoCSharp.CursoCSharp.Fundamentos {
     class OperadorTernario {
        public static void Executar() {

            var nota = 7.0;
            bool bomComportamento = true;
            var resultado = nota >= 7.0 && bomComportamento 
                ? "Aprovado" : "Reprovado"; // se nota for maior ou igual a 7 e tiver bom comportamento 
                                            // atribua Aprovado para resultado se não atribua Reprovado
                                            // o : executa a função de "se não". "else"
            Console.WriteLine(resultado);
        }
    }
}
