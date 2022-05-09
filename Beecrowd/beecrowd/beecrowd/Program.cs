using System;

namespace beecrowd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distanciaKm;
            double gastoCombustivel, consumoMedio;

            int.TryParse(Console.ReadLine(), out distanciaKm);
            double.TryParse(Console.ReadLine(), out gastoCombustivel);

            consumoMedio = distanciaKm / gastoCombustivel;

            Console.WriteLine($"{consumoMedio:F3} km/l");
        }
    }
}
