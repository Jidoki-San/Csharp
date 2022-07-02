using System;

namespace Exemplo_01{

    class Program{

        static void Main(string[] args){

            int a = 10;
            Console.WriteLine(a);

            // This command add +2 the original variable (a), command -> +=
            a += 2;
            Console.WriteLine(a);

            // This causes it to multiply the before variable (a = 10+2), command -> *=
            a *= 3;
            Console.WriteLine(a);

            a -= 2;
            Console.WriteLine(a);

            a /= 3;
            Console.WriteLine(a);
        }
    }
}
