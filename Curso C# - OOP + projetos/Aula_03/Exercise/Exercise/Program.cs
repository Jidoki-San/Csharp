using System;
using System.Globalization;
namespace Exercise
{
    class Program{
        static void Main(string[] args){

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"Produtos: \r\n" +
                $"{produto1}, cujo o preço é $ {preco1:F2} \r\n" +
                $"{produto2}, cujo o preço é $ {preco2:F2} \r\n");

            Console.WriteLine($"Registro: \r\n" +
                $"{idade} anos de idade, código {codigo} e gênero: {genero} \r\n");

            Console.WriteLine($"Oito casas: " +
                $"{medida:F8} \r\n" +
                $"Arredondado: " +
                $"{medida:F3} \r\n" +
                $"separador decimal: " +
                medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
