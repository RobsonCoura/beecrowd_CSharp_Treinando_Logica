using System;

namespace GastoDeCombustivel1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas, velocidadeMedia;
            double litros, kmL = 12.00;

            int.TryParse(Console.ReadLine(), out horas);
            int.TryParse(Console.ReadLine(), out velocidadeMedia);

            litros = (horas * velocidadeMedia) / kmL;
            Console.WriteLine($"{litros:F3}");
        }
    }
}
