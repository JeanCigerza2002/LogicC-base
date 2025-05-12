using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Elabore um algoritmo que leia o valor do lado do quadrado
             e calcule a área. Em seguida, calcule o dobro da área. 
             Mostre a área e o dobro.*/


            Console.WriteLine("Insira o valor do lado  do quadrado: ");
            Int32 lado = Convert.ToInt32(Console.ReadLine());

            Int32 area = lado*lado;
            Int32 dobro = area * 2;

            Console.WriteLine($"A area do triangulo é: {area} ");
            Console.WriteLine($"O dobro da area do triangulo é: {dobro} ");

        }
    }
}
