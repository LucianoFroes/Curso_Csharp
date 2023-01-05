using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.CursoCSharp.OO {

    public class Carro {

        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) {

            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;

            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;

            } else {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }
        public virtual int Acelerar() { // Utilizando o virtual, é possível que esse método seja reescrito depois.
            return AlterarVelocidade(5);
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro { // Se a classe carro tiver um construtor padrão, ela será chamada automaticamente.
        public Uno() : base(200) { // Se não tiver o construtor padrão, será necessário chamar o base, que é
                                   // que é a classe carro que recebe um parâmetro inteiro, como foi definido
                                   // lá em cima.
        }
    }
    public class Ferrari : Carro {
        public Ferrari() : base(350) {

        }
        public override int Acelerar() { // Utilizando o overside você está sinalizando que irá sobrescrever um método.
            return AlterarVelocidade(15);
        }

        // Oculta o método da classe Pai
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }
    class Heranca {
        public static void Executar() {

            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari(); // Polimosfirsmo
            // Ao invés de utilizar o tipo Ferrari para criar uma Ferrari, utilizando o polimorfismo
            // é possível através da herança utilizar a classe mais genérica para poder criar os carros.
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro...");
            carro3 = new Uno(); // Assim é possível com a mesma variável utilizar outras classes de carros
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
