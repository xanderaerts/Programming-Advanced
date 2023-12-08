using System;
namespace Module_05{
    internal class Program{
        static void Main(string[] args){
            
            List<string> words = File.ReadAllLines("english.txt").ToList();

            string input = Console.ReadLine();

            Assignment assignment = new Assignment();

            try{
               // input = input.Replace(" ","");
                input = input.ToLower();
               
                assignment.SearchWords(words,input);
                Console.WriteLine(assignment);
                
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}