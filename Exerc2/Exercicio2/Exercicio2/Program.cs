using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota 1: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3: ");
            float n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 4: ");
            float n4 = float.Parse(Console.ReadLine());

            float media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine($"A media do aluno é " + media.ToString("F1"));
        }
    }
}
