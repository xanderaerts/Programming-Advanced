using System;
namespace Module_05{
    internal class Program{
        static void Main(string[] args){
            
            List<string> words = File.ReadAllLines("english.txt").ToList();

            string input = Console.ReadLine();

            Assignment assignment = new Assignment();

            try{
                Console.WriteLine(assignment.SearchWords(words,input));
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}