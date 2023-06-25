using System;
using System.Globalization;

namespace Programa
{
    class Program
    {
        static void Main(String[] args)
        {
            int N, negativo;

            Console.Write("Qual eh a ordem da matriz? ");
            N = Convert.ToInt32(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("ELEMENTO[" + i + "," + j + "]:");
                    mat[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();

            negativo = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        negativo++;
                    }
                }
            }
            Console.WriteLine("QUANTIDADE DE NEGATIVOS: " + negativo);
        }
    }
}


