using System;

namespace Module_03{
    internal class Program{
        static void Main(string[] args){
            string input = Console.ReadLine();

            Assignment assignment = new Assignment();

            try{
                Console.WriteLine(assignment.Unique(input));
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}