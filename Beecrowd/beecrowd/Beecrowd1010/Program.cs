using System;

namespace Beecrowd1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca01, codigoPeca02, numeroPeca01, numeroPeca02;
            double valorPeca01, valorPeca02, valorTotal;

            int.TryParse(Console.ReadLine(), out codigoPeca01);
            int.TryParse(Console.ReadLine(), out numeroPeca01);
            double.TryParse(Console.ReadLine(), out valorPeca01);
            int.TryParse(Console.ReadLine(), out codigoPeca02);
            int.TryParse(Console.ReadLine(), out numeroPeca02);
            double.TryParse(Console.ReadLine(), out valorPeca02);

            valorTotal = (numeroPeca01 * valorPeca01) +(numeroPeca02 * valorPeca02);

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal:F2} ");
        }
    }
}
