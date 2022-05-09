using System;

namespace O_Maior1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorAB, maiorABC;

            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);

            maiorAB = (a + b + Math.Abs(a - b)) /2;
            maiorABC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;
            Console.WriteLine($"{maiorABC} eh o maior");
        }
    }
}
