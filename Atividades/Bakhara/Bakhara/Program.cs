using System;

namespace Bakhara
{
    class Program
    {
        static void Main(string[] args)
        {

            //Programa que cálcula a fórmula de Baskhara
            // Sendo a formula de delta: b2 - 4 * a * c
            // Formula x1 e x2 = -b +- Sqrt(delta) / 2 * a

            double a = -2, b = 3, c = 6;

            double delta = Math.Pow(b, 2.0) - 4 * a * c;

            double x1 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1.ToString("F2"));
            Console.WriteLine(x2.ToString("F2"));
            
        }
    }
}
