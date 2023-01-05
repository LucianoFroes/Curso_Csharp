using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.CursoCSharp.Colecoes {
     class ColecoesStack {
        public static void Executar() {
            var pilha = new Stack(); // Stack tem o conceito contrário de fila, o primeiro a entrar é o ultimo a sair
                                     // igual a uma pilha de livros.

            pilha.Push(3); // push adiciona ao topo da pilha
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}"); // O pop vai pegar o que estiver no topo e retirar do Stack

            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}"); // Peek não remove da pilha igual o pop
            Console.WriteLine(pilha.Count);

            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }
        }
    }
}
