using System;
namespace Module_06{
    internal class Program{
        static void Main(string[] args){
            string input = Console.ReadLine();
            input =  input.Trim();
            

            Assignment assignment = new Assignment();
            
            try{
                Console.WriteLine(assignment.SearchPlace(input));
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}