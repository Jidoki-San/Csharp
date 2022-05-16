using System;

namespace Course_exemple02 {
    class Program {
        static void Main(string[] args) {

            // byte values: 0 to 127 
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            //long for long numbers      L = indicates long number
            long n4 = 215897065L;

            //value modifier: variable++
            n1++;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}
