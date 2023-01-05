using System;

namespace CursoCSharp.CursoCSharp.ClassesEMetodos {

    public enum Genero {  Acao, Aventura, Terro, Animacao, Comedia }; // Enum é um tipo que declara um conjunto
                                                                      // estabelecido de constantes nomeadas.

    public class Filme {

        public string Titulo;
        public Genero GeneroDoFilme;
    }
     class ExemploEnum {
        public static void Executar() {

            int id = (int)Genero.Animacao; // Assim você está atribuindo um número ao Enum,
                                           // que no caso é a localização dentro de Genero.
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknando 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        }
    }
}
