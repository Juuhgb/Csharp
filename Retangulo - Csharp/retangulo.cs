using System;
using System.Globalization;

namespace Primeiro {
 class Program {
 static void Main(string[] args) {

    CultureInfo CI = CultureInfo.InvariantCulture;

    double largura, altura, area, perimetro, diagonal;

 Console.WriteLine("Base do retangulo:");
    largura = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Altura do retangulo:");
    altura = Convert.ToDouble(Console.ReadLine());

    area = largura * altura;
    perimetro = 2 * (largura + altura);
    diagonal = Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
    
    Console.WriteLine("Area do retangulo:" + area.ToString("F4", CI));
    Console.WriteLine("Perimetro do retangulo:" + perimetro.ToString("F4", CI));
    Console.WriteLine("Diagonal do retangulo:" + diagonal.ToString("F4", CI));

 }
 }
}