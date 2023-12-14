using System;
using System.Collections.Generic;
namespace Module_06{
    internal class Program{
        static void Main(string[] args){
            string raw = Console.ReadLine();

            List<int> list = new List<int>();
            Assignment assignment = new Assignment();

            try{
                foreach(string nr in raw.Split(" ")){
                    list.Add(Int32.Parse(nr));
                }
                 Console.WriteLine(assignment.Missing(list));
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}