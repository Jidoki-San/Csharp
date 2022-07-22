using System;

namespace Exemplo_02{

    class Program{

        static void Main(string[] args){

            int a = 10;
            // This command assigns a number to the variable, thus changing it's origin value, command -> a++
            int b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);

            b--;
            Console.WriteLine(b);
        }
    }
}
