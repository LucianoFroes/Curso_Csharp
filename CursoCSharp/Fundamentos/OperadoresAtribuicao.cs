﻿using System;


namespace CursoCSharp.CursoCSharp.Fundamentos {
     class OperadoresAtribuicao {
        public static void Executar() {

            var num1 = 3;
            num1 = 10; // substituiu o valor 3 por 10
            num1 += 10; // num1 = num1 + 10; 
            num1 -= 3; // num1 = num1 + 10; 
            num1 *= 5; // num1 = num * 10;
            num1 /= 2; // num1 = num / 10;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1;
            b--; // b = b - 1;

            Console.WriteLine($"{a} {b}");

            // Referencia por objeto

            dynamic c  = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);

        }
    }
}
