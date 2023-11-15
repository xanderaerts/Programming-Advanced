using System;
using System.IO;
using System.Collections.Generic;
namespace Module_06{
    internal class Program{
        static void Main(string[] args){
            
            string[] words = File.ReadAllLines("english.txt");

            string input = Console.ReadLine();
            input = input.ToLower();
            


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
