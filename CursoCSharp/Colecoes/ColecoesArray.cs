using System;

namespace CursoCSharp.CursoCSharp.Colecoes {
     class ColecoesArray {
        public static void Executar() {

            string[] alunos = new string[5]; // Precisa definir o tamanho do array;
                                             // Array só terá elementos do tipo dele, estrutua Homogênia e estática.
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";

            foreach(string aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach(double nota in notas) { 
                somatorio += nota;
            }
            double media = somatorio / notas.Length; // Conta quantos elementos existem no array
            Console.WriteLine(media);
        }
    }
}
