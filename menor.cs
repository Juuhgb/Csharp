using System;
using System.Globalization;

namespace Primeiro
{
   class Program
   {
      static void Main(string[] args)
      {
         int a, b, c;

         Console.WriteLine("Primeiro valor: ");
         a = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Segundo valor: ");
         b = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Terceiro valor: ");
         c = Convert.ToInt32(Console.ReadLine());

         if (a < b && a < c)
         {
            Console.WriteLine("MENOR=" + a);
         }
         else if (b < c)
         {
            Console.WriteLine("MENOR=" + b);
         }
         else
         {
            Console.WriteLine("MENOR=" + c);
         }
      }
   }
}