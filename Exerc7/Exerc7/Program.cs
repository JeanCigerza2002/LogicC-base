using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Com base na altura de uma pessoa, construa um algoritmo que calcule seu peso ideal, usando
             a seguinte formula: (72.7 x altura) - 58 */

            Console.WriteLine("Insira sua altura: ");
            double altura = (double.Parse(Console.ReadLine()));

            double peso_ideal = (72.7 * altura) - 58;

            Console.WriteLine($"Seu peso ideal é: " + peso_ideal.ToString("F2"));




        }
    }
}
