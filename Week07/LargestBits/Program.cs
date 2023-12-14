using System;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace Module_07{
    internal class Program{
        static void Main(string[] args){
            

            try{
                int input = Int32.Parse(Console.ReadLine());
                if(input <= 0)  throw new Exception();
                Assignment assignment = new Assignment(input);
                Console.WriteLine(assignment.findBiggest());
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}

