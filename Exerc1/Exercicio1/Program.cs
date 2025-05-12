using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine($"A soma de {a} + {b} é = {soma}");


        }
    }
}
