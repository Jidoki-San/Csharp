using System;

namespace Exemple_02
{
    class Program
    {
        static void Main(string[] args) {
            // {0}
            int idade = 32;
            // {1}
            double saldo = 10.35784;
            // {2}
            string nome = "Maria";

            // Placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            
            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo a {saldo:F3} reais");

            //Contenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais ");
        }
    }
}
