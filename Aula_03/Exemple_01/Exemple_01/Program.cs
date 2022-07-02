using System;
using System.Globalization;
namespace Exemple_01
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            // The Console.Write command, making everything that will appear on the screen be togheter, it does not contain the line break
            Console.Write("Good Morning");
            // You can write in parentheses in the Console.WriteLine
            Console.WriteLine("Good Afternoon");
            Console.WriteLine("----------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            // ToString -> The ToString method, serves to overwrite any type of variable, such as this Console.WriteLine
            Console.WriteLine(saldo.ToString("F2"));
            // .ToString("F") -> We use the "F" inside the ToString to determines the number of decimal places that can enter the console screen
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4"));

        }
    }
}
