using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma medida em metros: ");
            float metros = float.Parse(Console.ReadLine()); // Lê como float

            float centimetros = metros * 100; // Converte metros para centímetros

            Console.WriteLine("Seu valor em centímetros é: " + centimetros);
        }
    }
}
