using System;

namespace CursoCSharp.CursoCSharp.ClassesEMetodos {

    public class Cliente {

        public string Nome;
        public readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) { // O construtor sempre será void! O construtor não retorna nada.
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
     class Readonly {
        public static void Executar() {

            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

            Console.WriteLine(novoCliente.Nome = "Luciano");

        }

        //O modificador readonly impede que o campo seja substituído por uma instância diferente do tipo de referência

    }
}
