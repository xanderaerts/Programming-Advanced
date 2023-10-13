using System;
using extraOef;

namespace ExtraOef{
    internal class Program{
        static void Main(string [] args){

            Sum sum = new Sum();
            CountDigits countDigits = new CountDigits();
            ReverseString reverseString = new ReverseString();


            Console.WriteLine($"Sum: {sum.Iterative(5)}");
            Console.WriteLine($"Sum: {sum.Recursive(5)}");


            Console.WriteLine($"Count: {countDigits.Iterative(12345)}");
            Console.WriteLine($"Count: {countDigits.Recursive(12345)}");

            Console.WriteLine($"Reverse string: {reverseString.Iterative("test")}");
            Console.WriteLine($"Reverse string: {reverseString.Recursive("test")}");


            countDigits.For(0,new int[]{1,2,3,4,5,6,7});

        }
        
    }
}