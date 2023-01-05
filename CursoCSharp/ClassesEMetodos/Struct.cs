using System;

namespace CursoCSharp.CursoCSharp.ClassesEMetodos {

    interface Ponto {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;  
            Y = y;
        }

        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }
     class ExemploStruct {
        public static void Executar() {
            Coordenada coordenadaInicial; // Por enquanto o Struct só é diferente na hora de
                                          // iniciar em comparação com a Classe
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Cordenada Inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada();
            coordenadaFinal.X = 9;
            coordenadaFinal.Y = 1;

            //ou utilizando paramentros nomeados

            var coordenadaFinal1 = new Coordenada(x : 9, y: 1);

            coordenadaFinal.MoverNaDiagonal(10);
            coordenadaFinal1.MoverNaDiagonal(10);
            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal1.Y);
        }
    }
}
