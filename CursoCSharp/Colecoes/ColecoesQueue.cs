using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.CursoCSharp.Colecoes {
     class ColecoesQueue {
        public static void Executar() {

            var fila = new Queue<string>();

            fila.Enqueue("Fulano"); // Enqueue adiciona
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");// Fila aceita repetição.

            Console.WriteLine(fila.Peek()); // Peek pega o primeiro a sair da fila, porém não remove.
            Console.WriteLine(fila.Count()); // O Count é usado nas coleções e Lenght no Array.

            Console.WriteLine(fila.Dequeue()); // Tira a primeira pessoa da fila
            Console.WriteLine(fila.Count());

            foreach(var pessoa in fila) {
                Console.WriteLine(pessoa);
            }


            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Item")); // Contein: salada contém "item" ?
        }
    }
}
