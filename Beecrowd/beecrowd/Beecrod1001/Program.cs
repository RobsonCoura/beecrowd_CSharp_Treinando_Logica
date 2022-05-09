using System;

namespace Beecrod1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, X;

            int.TryParse( Console.ReadLine(), out A);
            int.TryParse( Console.ReadLine(), out B);

            X = A + B;
            Console.WriteLine($"X = {X}");
        }
    }
}
