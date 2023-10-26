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
                for(int i = 0; i < input.Length; i++){
                    getallen[i] =Int32.Parse(strings[i]);
                }

                Console.WriteLine(assignment.Multiplication(getallen,0).ToString());
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}