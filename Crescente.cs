using System;

namespace crescente
{
	class Program
	{
		static void Main(string[] args)
		{
			int a, b;

			Console.WriteLine("Digite dois numeros:");
			a = Convert.ToInt32(Console.ReadLine());
			b = Convert.ToInt32(Console.ReadLine());

			while (a != b)
			{
				if (a > b)
				{
					Console.WriteLine("Decrescente");
				}
				else
				{
					Console.WriteLine("Crescente");
				}

				Console.WriteLine("Digite outros dois numeros:");
				a = Convert.ToInt32(Console.ReadLine());
				b = Convert.ToInt32
                (Console.ReadLine());
			}
		}
	}
}

