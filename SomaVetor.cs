using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Programa
{
    class Program
    {
        static void Main(String[] args)
        {
            int N;
            double soma, media;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Quantos numeros vc vai digitar?");
            N = Convert.ToInt32(Console.ReadLine());

            double[] vet = new double[N];


            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vet[i] = Convert.ToDouble(Console.ReadLine(), CI);
            }

            Console.WriteLine("Valores: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(vet[i] + " ");

            }
            Console.WriteLine();
            
            soma = 0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }
            Console.WriteLine("Soma: " + soma.ToString("F2", CI));

            media = (double)soma / N;
            Console.WriteLine("Media:" + media.ToString("F2", CI));

        }
    }
}


