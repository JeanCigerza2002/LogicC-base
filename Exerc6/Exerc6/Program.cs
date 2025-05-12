using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia o valor que um funcionário ganha por hora e o número de horas trabalhadas no mês.
             Calcule e mostre o total do seu salário no referido mês.*/

            Console.WriteLine("Insira o quanto ganha por hora: ");
            Int32 SalHor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o quanto de horas trabalhada no mês: ");
            Int32 HorMes = Convert.ToInt32(Console.ReadLine());

            //Calcuclo da formula do salario inteiro
            Int32 SalTotal = HorMes * SalHor;

            Console.WriteLine($"O valor total ganho é: {SalTotal}");

        }
    }
}
