using System;
using System.Collections.Generic;
namespace Module_04{
    internal class Program{
        static void Main(string[] args){
            Assignment assignment = new Assignment();

            string input = Console.ReadLine();
            List<int> getallen = new List<int>();

            try{
                foreach(string i in input.Split(" ")){
                    getallen.Add(Int32.Parse(i));
                }

                Console.WriteLine(assignment.Minimum(getallen,0).ToString());
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}