using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo para transformar uma distância expressa em milhares para quilometros. Sabe-se que um km corresponde a 0.6214*/

            Console.WriteLine("Informe a distancia em milhares: ");
            double dist = double.Parse(Console.ReadLine());

            double quilometros = dist / 0.6214;

            Console.WriteLine($"O valor em quilometros é:" + quilometros.ToString("F1"));
        }
    }
}
