using System;

namespace DistanciaEntreDoisPontos1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double x1, y1, x2, y2, distancia;

            double.TryParse(Console.ReadLine(), out x1);
            double.TryParse(Console.ReadLine(), out y1);
            double.TryParse(Console.ReadLine(), out x2);
            double.TryParse(Console.ReadLine(), out y2);

            distancia = Math.Sqrt(Math.Pow(x2 - x1 , 2) + Math.Pow(y2 - y1 , 2));
            Console.WriteLine($"{distancia:F4}");

        }
    }
}
