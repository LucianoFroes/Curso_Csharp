using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.CursoCSharp.Colecoes {
     class Igualdade {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);

            var p3 = p2;

            Console.WriteLine(p1 == p2); // É comparação de referência de memória
            Console.WriteLine(p3 == p2);

            // Para ter uma comparação por valor é necessário implementar um HashSet e um HashCode
            // Pois objetos se comparados com a igualdade só vão olhar para o apontamento da memória
            // HashSet é a maneira mais rápida de busca, porém mais "imprecisa", ela é utilizada primeiro para
            // Eliminar opções que obviamente não são iguais ao que você procura, assim é necessário utilizar o
            // HashCode.

        }
    }
}
