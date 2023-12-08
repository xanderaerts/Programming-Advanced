using System;

namespace Module_05{
    internal class Program{
        static void Main(string[] args){
            string input = Console.ReadLine();

            Assignment assignment = new Assignment();

            try{
                int inputInt = Int32.Parse(input);
                assignment.PrintCombinations(inputInt);            
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}

