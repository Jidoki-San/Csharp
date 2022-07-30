using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            // Int - -156 to 32334
            // Float - -15.6 to 232.132
            // Bool - true or false
            // String - "type text"
            // Char -  unique character 'a'
            // Var - define the variable

            // A - Z
            // 0 - 9 ==> only in the middle or end of the variable 
            // @ $ . ==> prohibited

            int data_WW2 = 1942;
            string cor_favorita = "cinza";
            float velocidade_F1 = 294.48f;
            bool data_WW2_aconteceu = true;

            Console.WriteLine(data_WW2);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidade_F1);
            Console.WriteLine(data_WW2_aconteceu);

            // Caso queira mudar o valores das variavei, não precisa colocar o comand na frente dele

            velocidade_F1 = 543.55f;
            cor_favorita = "azul";

            Console.WriteLine(velocidade_F1);
            Console.WriteLine(cor_favorita);
        }
    }
}
