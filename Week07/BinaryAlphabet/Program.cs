using System;

namespace Module_07 {
    internal class Program{
        static void Main(string[] args){
            
            try{
                int input = Int32.Parse(Console.ReadLine());

                Assignment assignment = new Assignment();

                Console.WriteLine(assignment.PrintAlphabet(input));
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}