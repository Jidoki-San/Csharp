using System;
using System.Globalization;

namespace Exercício_de_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o seu nome completo: ");
            string fullname = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product price: ");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Escreva o seu último nome, idade e altura");
            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(n1);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
