using System;
using System.Collections.Generic;
namespace Module_03{
    internal class Program{
        static void Main(string[] args){
            Assignment assignment = new Assignment();

            string input = Console.ReadLine();
            int[] getallen = new int[2];

            try{
                string[] strings = input.Split(" ");
                Console.WriteLine(assignment.Multiplication(strings,0));
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}