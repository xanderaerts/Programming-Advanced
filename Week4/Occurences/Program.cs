using System;
using Occurences;
namespace Module_03{
    internal class Program{
        static void Main(string[] args){
            string getal = Console.ReadLine();
            string input = Console.ReadLine();

            Assignment assignment = new Assignment();

            try{
                string[] inputs = input.Split(" ");
                Console.WriteLine(assignment.Occurences(getal,inputs));
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}