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
                if(input != "")Console.WriteLine(assignment.SearchWords(words,input));
                else throw new Exception();
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}
