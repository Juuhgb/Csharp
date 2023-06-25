using System;

namespace Programa
{
    class Program
    {
        static void Main(String[] args)
        {
          int a, b, menor, soma;

            Console.WriteLine("Digite dois numeros:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b) {
                menor = b;
                b = a;
                a = menor;
            }
            soma = 0;
            for (int i = a + 1; i < b; i++) {
                if (i % 2 != 0){
                   soma = soma + i; 
                }
            }
            Console.WriteLine("Soma dos impares: " + soma);

        }
    }
}


