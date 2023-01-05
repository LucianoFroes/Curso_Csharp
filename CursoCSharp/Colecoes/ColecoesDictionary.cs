using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.CursoCSharp.Colecoes {
     class ColecoesDictionary {
        public static void Executar() {

            var filmes = new Dictionary<int, string>(); // A chave não aceita repetição, porém o valor aceita.
                                                        // Dictionary é a junção do Set na parte da chave o List na parte
                                                        // do valor.

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) { // Contém a chave (...) ?

                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2008)); // Não retorna um erro se não encontrar a chave
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia")); // Contém o valor "Amnésia" ?
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme: {filme2006}");
            
            filmes.TryGetValue(2008, out string filme2008); // Try não retorna erro, apenas um valor vazio
            Console.WriteLine($"Filme: {filme2008}");

            foreach(var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine(filme.Value + " " + filme.Key);
            }

            foreach(var filme in filmes) {
                Console.WriteLine(filme.Value + " " + filme.Key);
            }
        }
    }
}
