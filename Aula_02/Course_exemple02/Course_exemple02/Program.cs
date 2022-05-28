using System;

namespace Course_exemple02 {
    class Program {
        static void Main(string[] args) {

            // byte values: 0 to 127 
            byte n1 = 126;
            //bool => Determines whether it is false or true
            bool completo = false;
            // char => Any Unicode character
            char genero = 'F';
            char letra = '\u0041';
            int n2 = 1000;
            int n3 = 2147483647;
            //long for long numbers      L = indicates long number
            long n4 = 215897065L;
            // float => This variable is used place decimal numbers; the 'f' at the end determines that it is decimal
            float n5 = 4.5f;
            // double => If u don't want to put an 'f' the end of the decimal number every time, use this variable
            double n6 = 4.5;
            // String => A unicode string IMMUTABLE (safety, simplicity, thread safe) 
            String nome = "Maria Green";
            // Object => A generic object (every class in C# is a subclass of object) GetType, equals, GetHashCode, ToString
            Object obj1 = "Alex Brown";
            Object obj2 = 4.5f;
            //value modifier: variable++
            n1++;

            // Hint: put 'cw' and hit the tab twice to write Console.WriteLine
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}
