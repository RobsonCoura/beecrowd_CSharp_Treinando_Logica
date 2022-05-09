using System;

namespace Beecrowd1003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, soma;

            int.TryParse(Console.ReadLine(), out A);
            int.TryParse(Console.ReadLine(),out B);

            soma = A + B;
            Console.WriteLine($"SOMA = {soma}");
        }
    }
}
