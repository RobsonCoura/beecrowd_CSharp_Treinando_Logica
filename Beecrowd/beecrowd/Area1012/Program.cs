using System;

namespace Area1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            double areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

            double.TryParse(Console.ReadLine(), out A);
            double.TryParse(Console.ReadLine(), out B);
            double.TryParse(Console.ReadLine(), out C);

            areaTriangulo = (A * C) / 2;
            areaCirculo = (C * C) * 3.14159;
            areaTrapezio = (A + B) * C / 2;
            areaQuadrado = B * B;
            areaRetangulo = A * B;

            Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
            Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
            Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
            Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");
            /*
            double A, B, C;
            double areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

            double.TryParse(Console.ReadLine(), out A);
            double.TryParse(Console.ReadLine(), out B);
            double.TryParse(Console.ReadLine(), out C);

            areaTriangulo = (A * C) / 2;
            Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
            areaCirculo = Math.PI * Math.Pow(C, 2);
            Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
            areaTrapezio = (A + B) * C / 2;
            Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
            areaQuadrado = Math.Pow(B, 2);
            Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
            areaRetangulo = A * B;
            Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");*/
        }
    }
}
