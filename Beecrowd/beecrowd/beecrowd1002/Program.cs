using System;

namespace beecrowd1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double n = 3.14159;
            double area, raio = 0;

            double.TryParse(Console.ReadLine(), out raio);
            area = Math.Pow(raio, raio) * n;

            Console.WriteLine($"A={area:F4}");
        }
    }
}
